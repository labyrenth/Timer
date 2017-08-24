using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TIMER
{
    public partial class TimerCalenderForm : Form
    {
        CalTime caltime = new CalTime();
        private Exception f;
        private List<string> timeStringArray;

        public TimerCalenderForm(List<string> timerDataArray)
        {
            InitializeComponent();
            this.timeStringArray = timerDataArray;
        }

        private void Form2_End_Click(object sender, EventArgs e)
        {
            // 닫기 버튼을 눌렀을시 form2를 끝낸다.
            this.Close();
        }

        private void Search_Start_Click(object sender, EventArgs e)
        {
            // 바운더리 제작.
            int startfrontline = Startfrontline(StartDate.Value.Year, StartDate.Value.Month, StartDate.Value.Day);
            int endfrontline = Endfrontline(EndDate.Value.Year, EndDate.Value.Month, EndDate.Value.Day);
            try
            {
                // 시작일이 종료일보다 클경우 실행을 막음
                if (EndDate.Value.CompareTo(StartDate.Value) < 0)
                {
                    MessageBox.Show("시작일이 종료일보다 큽니다.");
                    throw f;
                }
                // 스크립트 자체에서 클릭하는거 막기. 바운더리 기준.
                if (startfrontline != 0 || endfrontline != 0)
                {
                    MessageBox.Show("해당일자에 해당하는 시간이 없습니다. 첫번째 데이터는 " + timeStringArray[0] + "이고 \r\n 마지막 데이터는 "
                        + timeStringArray[timeStringArray.Count - 1] + "입니다.");
                    throw f;
                }
                // 위 사항을 전부 통과했을경우 SearchDate를 실행.
                SearchDate();
            }
            catch (Exception)
            {

            }
        }

        void SearchDate()
        {
            int H = 0;
            int M = 0;
            int S = 0;
            int StartCount = FindDate(StartDate.Value, true);
            int EndCount = FindDate(EndDate.Value, false);
            // 시작 기준부터 끝까지 시간을 더해서 출력.
            for (int i = StartCount; i <= EndCount; i++)
            {
                string[] temp = timeStringArray[i].Split('.');
                H += int.Parse(temp[3]);
                M += int.Parse(temp[4]);
                S += int.Parse(temp[5]);
                caltime.GetTimer(ref H, ref M, ref S);
            }

            ShowTimeLine.Text = "총 공부시간은 " + H + "시간 " + M + "분 " + S + "초입니다.";
        }

        public int FindDate(DateTime date, bool start)
        {
            int count = -1;
            string[] temp;

            for (int i = 0; i < timeStringArray.Count; i++)
            {
                temp = timeStringArray[i].Split('.');

                if (date.Year == int.Parse(temp[0]) && date.Month == int.Parse(temp[1]) && date.Day == int.Parse(temp[2]))
                {
                    count = i;
                }
            }
            // count의 변화가 없다 = 해당 데이터가 없을때
            // 1) start가 true == 기준이 시작일이라면? 가장 가까운 데이터 중 큰 값을 고른다.
            if (count == -1 && start == true)
            {
                // 재귀함수 사용. 큰 값이 나와서 값을 대입할때까지 계속.
                count = FindDate(date.AddDays(1), true);
            }
            // 2) start가 false == 기준이 마지막일이라면? 가장 가까운 데이터 중 작은 값을 고른다.
            else if (count == -1 && start == false)
            {
                // 재귀함수 사용. 작은 값이 나와서 값을 대입할때까지 계속.
                count = FindDate(date.AddDays(-1), false);
            }
            return count;
        }
        // 시작일의 바운더리 제작.
        public int Startfrontline(int Year, int Month, int Day)
        {
            int result = 0;
            string[] StartPoint = timeStringArray[0].Split('.');
            string[] EndPoint = timeStringArray[timeStringArray.Count - 1].Split('.');
            // 검사 시작(작은지?)
            if (Year > int.Parse(StartPoint[0]))
                result = 0;
            else if (Year < int.Parse(StartPoint[0]))
                result = -1;
            else
            {
                if (Month > int.Parse(StartPoint[1]))
                    result = 0;
                else if (Month < int.Parse(StartPoint[1]))
                    result = -1;
                else
                {
                    if (Day < int.Parse(StartPoint[2]))
                        return -1;
                    else
                        return 0;
                }
            }
            // 작으면 -1, 크거나 같으면 0을 반환.
            return result;
        }
        // 종료일의 바운더리 제작.
        public int Endfrontline(int Year, int Month, int Day)
        {
            int result = 0;
            string[] StartPoint = timeStringArray[0].Split('.');
            string[] EndPoint = timeStringArray[timeStringArray.Count - 1].Split('.');
            // 검사 시작(작은지?)
            if (Year > int.Parse(EndPoint[0]))
                result = 1;
            else if (Year < int.Parse(EndPoint[0]))
                result = 0;
            else
            {
                if (Month > int.Parse(EndPoint[1]))
                    result = 1;
                else if (Month < int.Parse(EndPoint[1]))
                    result = 0;
                else
                {
                    if (Day > int.Parse(EndPoint[2]))
                        return 1;
                    else
                        return 0;
                }
            }
            // 작거나 같으면 0, 크면 1을 반환.
            return result;
        }
    }
}
