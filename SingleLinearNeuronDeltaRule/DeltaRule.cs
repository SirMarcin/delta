using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinearNeuronDeltaRule
{
    public class DeltaRule
    {   


        public DeltaRule(int number, int nx)
        {
            NumberOfTrainingPatterns = number;
            Nx = nx;
            Weights = new double[Nx];
            CollectionOfTrainingPatterns = new List<TrainingPattern>();
            int seed = 1;

            for (int i = 0; i < NumberOfTrainingPatterns; i++)
            {
                CollectionOfTrainingPatterns.Add(new TrainingPattern(Nx, seed));
                seed += 1;
            }

            Random randomNumberForWeights = new Random();
            for (int i = 0; i < Nx; i++)
            {
                Weights[i] = randomNumberForWeights.Next(-100, 100);
            }
        }


        public static int Nx { get; set; }
        public int NumberOfTrainingPatterns { get; set; }
        public double[] Weights { get; set; }
        public List<TrainingPattern> CollectionOfTrainingPatterns { get; set; }
    }
}
