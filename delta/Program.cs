using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delta
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 5;
            double[] inputs = new double[N] { 1, 4, 5, 3, 2 };
            double[] weights = new double[N] { 0.2, 0.3, 1, 0.03, 0 };
            int K = 1000000;
            double step = 0.00001;
            int k = 0;
            double output = 0;
            double desiredOutput = 15;
            while (k <= K)
            {
                output = 0;
                for (int i = 0; i < N; i++)
                {
                    output += weights[i] * inputs[i];
                }

                for (int i = 0; i < N; i++)
                {
                    weights[i] = weights[i] + step * (desiredOutput - output) * inputs[i];
                }

                k++;

            }


            int count = 1;
            foreach (var weight in weights)
            {
                
                Console.WriteLine("Waga {0}: {1}", count++, weight);

            }
            Console.WriteLine("Wyjście: {0}", output);
            Console.WriteLine("W kroku {0}", k);
        }
    }
}
