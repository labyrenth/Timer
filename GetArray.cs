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
        public void Get(ref List<String> array, string targetPath)
        {
            try
            {
                array = new List<String>(File.ReadAllLines(targetPath));
            }
            catch
            {
                array = new List<string>();
            }
        }
    }
}
