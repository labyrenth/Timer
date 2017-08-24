using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace TIMER
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isNew = true;
            Mutex mutex = new Mutex(true, "MyTimer", out isNew);

            if (isNew == false)
            {
                //종료.
                MessageBox.Show("이미 프로그램이 실행중에 있습니다.");
                Application.Exit();
            }
            else
            {
                // 실행
                mutex.ReleaseMutex();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainTimerForm());
            }

            
        }

    }
}
