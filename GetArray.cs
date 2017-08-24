using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TIMER
{
    class GetArray
    {
        public void Read(ref List<String> array, StreamReader streamReader)
        {
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            try
            {
                array.Clear();
                while (!streamReader.EndOfStream)
                {
                    array.Add(streamReader.ReadLine());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\nGetArray과정에서 문제가 생겼습니다.");
                MessageBox.Show(e.Source);
            }
        }
    }
}
