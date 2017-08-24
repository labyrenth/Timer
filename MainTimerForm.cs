using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
namespace TIMER
{
    public partial class MainTimerForm : Form
    {
        private enum FormState
        {
            IDLE,
            RUN
        }

        // Data 저장용
        private int second;
        private int minute;
        private int hour;
        // 처음본 함수. Visual Studio에서 기본 제공하는 Timer 관련 함수인것 같다.
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        CalTime caltime = new CalTime();
        GetArray readArr = new GetArray();
        SaveArray saveArr = new SaveArray();
        private List<String> timerDataSavedArray;
        private string myDocumentsPath;
        private string studyTimeTextPath;
        private FormState formState;
        private FileStream timerDataSavedFileStream;
        private StreamReader timerDataStreamReader;
        private StreamWriter timerDataStreamWriter;
        public MainTimerForm()
        {
            // 초기화.

                InitializeComponent();
                hour = 0;
                second = 0;
                minute = 0;
                timerDataSavedArray = new List<String>();
                myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                studyTimeTextPath = myDocumentsPath + @"\MyTimer\StudyTime.txt";

                try
                {
                    if (File.Exists(myDocumentsPath + "\\MyTimer") == false)
                    {
                        DirectoryInfo di = new DirectoryInfo(myDocumentsPath + "\\MyTimer");
                        di.Create();
                        //The File.Create method creates the file and opens a FileStream on the file. So your file is already open. -> File.Create().Close() 해주어야 Process 사용 오류메세지가 뜨지 않음.
                        //File.Create(studyTimeTextPath).Close();
                    }
                    timerDataSavedFileStream = File.Open(studyTimeTextPath, FileMode.OpenOrCreate);
                    timerDataStreamReader = new StreamReader(timerDataSavedFileStream);
                    timerDataStreamWriter = new StreamWriter(timerDataSavedFileStream);
                    //초기화
                    readArr.Read(ref timerDataSavedArray, timerDataStreamReader);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                this.Resize += Form1_Resize;
                notifyIcon1.ContextMenuStrip = contextMenuStrip1;
                formState = FormState.IDLE;

        }

        // 시간을 계산해서 출력하는 함수.
        void timer_Tick(object sender, EventArgs e)

        {
            SECOND.Text = second.ToString();
            MINUTE.Text = minute.ToString();
            HOUR.Text = hour.ToString();
            second++;
            caltime.GetTimer(ref hour, ref minute, ref second);
        }
        // timer.Tick이 중복되지 않게 하는게 관건이었다. 중복될경우 Interval이 중첩되서 2초 3초씩 막 증가하고 난리가 아니었다.
        // 그리고 timer.Tick은 += 혹은 -=밖에 먹질 않아서... Start_Stop을 잘 이용해서 처리 했다.
        private void START_Click(object sender, EventArgs e)
        {
            // timer.Tick중복 대책.
            if (formState.Equals(FormState.IDLE))
            {

                timer.Interval = 1000; // 1초 -> x ms가 지날 경우..!
                // 지정된 타이머 간격이 지날경우 EventHandler 항목에 있는 항목을 실행하는 것을 timer.Tick에 더한다.
                timer.Tick += new EventHandler(timer_Tick);
                // 타이머 실행.
                timer.Start();
                formState = FormState.RUN;
            }
        }

        private void STOP_Click(object sender, EventArgs e)
        {
            // timer.Tick 중복 대책.
            if (formState.Equals(FormState.RUN))
            {
                // timer.Tick을 감소시킨다.
                timer.Tick -= new EventHandler(timer_Tick);
                // 타이머 정지.
                timer.Stop();
                formState = FormState.IDLE;
            }
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            // 내용 초기화
            hour = 0;
            second = 0;
            minute = 0;
            HOUR.Text = "";
            MINUTE.Text = "";
            SECOND.Text = "";
            // STOP_CLICK을 클릭한 것과 같은 내용을 실행.
            if (formState.Equals(FormState.RUN))
            {
                STOP_Click(sender, e);
            }
        }

        private void SAVE_TIMER_CLICK(object sender, EventArgs e)
        {
            // 장대한 저장데이터 관리의 시작. count는 중복된 내용이 있어서 교체가 이루어 졌는지 아닌지를 판단!
            int count = 0;

            for (int i = 0; i < timerDataSavedArray.Count; i++)
            {
                // Array[i]는 TXT파일이 한줄씩 들어가있는 string[] 형식. 이때 string[] TempToday는 Array의 내용을 . 을 기준으로 분리한다.
                string[] TempToday = timerDataSavedArray[i].Split('.');
                // 날짜 기준으로 중복되는 내용이 있을시
                if (TempToday[0] == DateTime.Now.Year.ToString() &&
                    TempToday[1] == DateTime.Now.Month.ToString() &&
                    TempToday[2] == DateTime.Now.Day.ToString())
                {
                    // temphour,tempminute,tempsecond에 값을 저장.
                    int temphour = int.Parse(TempToday[3]) + hour;
                    int tempminute = int.Parse(TempToday[4]) + minute;
                    int tempsecond = int.Parse(TempToday[5]) + second;
                    // 시간 계산.
                    caltime.GetTimer(ref temphour, ref tempminute, ref tempsecond);
                    // Array[i]에 덮어쓴다!
                    timerDataSavedArray[i] = TempToday[0] + "." + TempToday[1] + "." + TempToday[2] + "." +
                        temphour.ToString() + "." + tempminute.ToString() + "." + tempsecond.ToString();

                    // count를 증가시켜 변경이 이루어졌다는 것을 확인.
                    count++;
                }
            }

            // 저장 버튼을 클릭했을 때, 해당하는 위치에 Report에 저장된 내용을 저장하는 함수.
            if (count == 0)
            {
                // 변경이 이루어지지 않았을때는 파일이 없거나 아예 다른 날 실행을 했다는 뜻이므로, 새로운 줄을 추가한다.
                // \r\n은 줄바꿈 상수이다. 기억하자.
                string Report = DateTime.Now.Year.ToString()
                + "." + DateTime.Now.Month.ToString()
                + "." + DateTime.Now.Day.ToString()
                + "." + HOUR.Text
                + "." + MINUTE.Text
                + "." + SECOND.Text + "\r\n";
                timerDataSavedArray.Add(Report);
            }
            saveArr.Save(this.timerDataStreamWriter,this.timerDataSavedArray);
            // RESET_CLICK을 클릭한것과 같은 내용을 실행. 메소드를 불러오니까 같은 내용을 중복해서 쓸 필요가 없다.
            RESET_Click(sender, e);
        }

        private void SHOW_TIMER_Click(object sender, EventArgs e)
        {
            bool isMessageBoxShow = false;
            for (int i = 0; i < timerDataSavedArray.Count; i++)
            {
                string[] TempToday = timerDataSavedArray[i].Split('.');
                // 오늘의 날짜와 맞는 날짜에 해당하는 시간을 골라서 messagebox를 띄워준다.
                if (TempToday[0] == DateTime.Now.Year.ToString() &&
                    TempToday[1] == DateTime.Now.Month.ToString() &&
                    TempToday[2] == DateTime.Now.Day.ToString())
                {
                    MessageBox.Show("오늘의 공부 시각은 " + TempToday[3] + "시간 " + TempToday[4] + "분 " + TempToday[5] + "초입니다.");
                    isMessageBoxShow = true;
                    break;
                }
            }
            if (!isMessageBoxShow)
            {
                MessageBox.Show("오늘 공부를 하지 않으셨습니다.");
            }
        }

        private void SEARCH_TIMER_Click(object sender, EventArgs e)
        {
            TimerCalenderForm ab = new TimerCalenderForm(this.timerDataSavedArray);     //About 폼을 객체화
            ab.ShowDialog();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true; // tray icon 표시
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
                this.ShowInTaskbar = true; // 작업 표시줄 표시
            }
        }

        private void ReOpenProgram(object sender, EventArgs e)
        {
            this.Visible = true; // 폼의 표시
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal; // 최소화를 멈춘다
            this.Activate(); // 폼을 활성화 시킨다
        }

        private void EndProgram(object sender, EventArgs e)
        {
            EndProgramSequence();
        }

        private void EndProgramSequence()
        {
            notifyIcon1.Visible = false;
            Application.ExitThread();
            timerDataStreamReader.Close();
            timerDataStreamWriter.Close();
            timerDataSavedFileStream.Close();
            Application.Exit();
        }
    }
}


