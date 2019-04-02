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
            TrainingPattern tablica = new TrainingPattern(10, 5);


            Console.Write("Wejścia treningowe: ");
            for (int i = 0; i < tablica.Inputs.GetLength(0); i++)
            {
                Console.Write(tablica.Inputs[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Wyjście treningowe: " + tablica.DesiredOutput);
        }
    }
}
