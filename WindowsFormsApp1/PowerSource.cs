using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PowerSource
    {
        public float voltage;
        public bool enabled;
        public bool noiseEnabled;
        public float noiseCoefficient;
        public float maliciousShift;
        public float verticalShift;
        Random random;

        public PowerSource()
        {
            voltage = 0;
            enabled = false;
            noiseEnabled = false;
            random = new Random();
            noiseCoefficient = 1;
            maliciousShift = 0;
        }

        public float readVoltage()
        {
            float outputVoltage = voltage;
            if (noiseEnabled)
            {
                outputVoltage += ((float)random.NextDouble() - (float)0.5) * ((float)10.2 - noiseCoefficient) / 13;
            }
            outputVoltage += maliciousShift;
            return outputVoltage;
        }
    }
}
