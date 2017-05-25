using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Oscilloscope
    {
        public List<float> values;
        public int dots;
        public float scale = 1;
        public float verticalShift = 0;

        public Oscilloscope() {
            dots = 200;
            values = new List<float>(dots);
            for (int i = 0; i < dots; i++)
                values.Add(0);
        }

        public void newValue(float value) {
            values.RemoveAt(0);
            values.Add(value);
            
        }
    }
}
