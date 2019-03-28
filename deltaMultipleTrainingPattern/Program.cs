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
            const int Ny = 5;                                                                    
            const int Nx = 2;                                                                    
            double[,] inputs = new double[Nx, Ny] { { 1, 3, 6, 3, 7 }, { 3, 5, 8, 2, 1 } };                                  
            double[] weights = new double[Ny] { 0.2, 0.3, 1, 0.03, 0 };
            int K = 10000000;                                                                   
            double step = 0.000001;                                                  
            int k = 0;                                                                     
            double output = 0;
            double[] desiredOutput = new double[Nx] { 45, 25 };
                                             
            while (k <= K)                                                                  
            {
                for (int x = 0; x < Nx; x++)
                {

                    output = 0;                                                                 
                    for (int y = 0; y < Ny; y++)                                                    
                    {
                        output += weights[y] * inputs[x,y];
                    }

                    for (int y = 0; y < Ny; y++)                                                    
                    {
                        weights[y] = weights[y] + step * (desiredOutput[x] - output) * inputs[x,y];
                    }
                }
                k++;

            }


            int count = 1;                                                                    
            foreach (var weight in weights)
            {

                Console.WriteLine("Waga {0}: {1}", count++, weight);

            }

            Console.WriteLine("W kroku {0}", k);
            for (int x = 0; x < Nx; x++)
            {
                output = 0;
                for (int y = 0; y < Ny; y++)
                {
                    output += weights[y] * inputs[x, y];
                }
                Console.WriteLine("Wyjscie nr.{0} jest równe : {1}", x, output);
            }
            
        }
    }
}
