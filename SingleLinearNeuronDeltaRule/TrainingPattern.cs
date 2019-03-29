using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinearNeuronDeltaRule
{
    public class TrainingPattern
    {
        public TrainingPattern(int ny)
        {
            Ny = ny;
            
            Random randomNumber = new Random();

            for (int i = 0; i < Ny; i++)
            {
                Inputs[i] = randomNumber.Next(-100000, 100000);
            }

            DesiredOutput = randomNumber.Next(-100000, 100000);
        }

        public int Ny { get; set; }
        public double[] Inputs { get; set; }
        public double DesiredOutput { get; set; }
    }
}
