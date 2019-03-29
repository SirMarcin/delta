using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinearNeuronDeltaRule
{
    class DeltaRule
    {

        public int TrainingEpochs { get; set; }
        public int Epoch { get; set; }
        public double Step { get; set; }
        public List<TrainingPattern> TrainingPatterns { get; set; }
        public double[] Weights { get; set; }
        public double Output { get; set; }
        public int Nx { get; set; }
        public int Ny { get; set; }

        public void PerformLearning(int nx, int trainingEpochs, double step, int sizeOfTrainingPatterns)
        {
            Epoch= 0;
            Nx = nx;
            TrainingEpochs = trainingEpochs;
            Step = step;
            Ny = sizeOfTrainingPatterns;

            Random randomNumber = new Random();
            for (int i = 0; i < Ny; i++)
            {
                Weights[i] = randomNumber.Next(-100000, 100000);
            }
            
        }
    }
}
