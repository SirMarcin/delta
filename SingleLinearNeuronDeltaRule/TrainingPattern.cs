using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinearNeuronDeltaRule
{
    public class TrainingPattern
    {
        public TrainingPattern(int nx, int seed)
        {
            Nx = nx;
            Inputs = new double[Nx];

            Random randomNumberForTrainingPatterns = new Random(seed);
            for (int i = 0; i < Nx; i++)
            {
                Inputs[i] = randomNumberForTrainingPatterns.Next(-100, 100);
            }
            DesiredOutput = randomNumberForTrainingPatterns.Next(-100, 100);
        }

        public static int Nx { get; set; }
        public double DesiredOutput { get; set; }
        public double[] Inputs { get; set; }

    }
}
