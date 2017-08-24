using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TIMER
{
    class SaveArray
    {
        public void Save(StreamWriter writer, List<string> writeArray)
        {
            writer.AutoFlush = true;
            // Gets or sets a value indicating whether the StreamWriter 
            // will flush its buffer to the underlying stream after every  
            // call to StreamWriter.Write.
            foreach (string timerData in writeArray)
            {
                writer.WriteLine(timerData);
            }
        }
    }
}
