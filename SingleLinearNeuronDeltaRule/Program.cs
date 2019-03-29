using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinearNeuronDeltaRule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Set a number of training patterns: ");
            int numberOfTrainingPatterns = Convert.ToInt32(Console.ReadLine());

            Console.Write("Set a size of training patterns: ");
            int sizeOfTrainingPatterns = Convert.ToInt32(Console.ReadLine());

            Console.Write("Set a number of training epochs: ");
            int numberOfTrainingEpochs = Convert.ToInt32(Console.ReadLine());

            Console.Write("Set a size of training step: ");
            double sizeOfTrainingsteps = Convert.ToDouble(Console.ReadLine());

        }
    }
}
