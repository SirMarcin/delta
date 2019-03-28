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
            const int N = 5;                                                                    //Liczba wejść
            double[] inputs = new double[N] { 1, 4, 5, 3, 2 };                                  //Wejscia
            double[] weights = new double[N] { 0.2, 0.3, 1, 0.03, 0 };                          //Wagi
            int K = 10000000;                                                                    //Liczba epok(iteracji)
            double step = 0.000001;                                                              //Krok uczenia
            int k = 0;                                                                          //Bieżaca iteracja
            double output = 0;                                                                  //Wyjscie
            double desiredOutput = 75465;                                                          //Zadane wyjscie
            while (k <= K)                                                                      //Petla wykonuje się zadaną ilość razy
            {                                                                                   //Na początku każdej pętli zerowane jest wyjście neuronu
                output = 0;                                                                     //
                for (int i = 0; i < N; i++)                                                     //Wyjscie jest sumą pomnożonych par wejść i wag
                {                                                       
                    output += weights[i] * inputs[i];   
                }   
                    
                for (int i = 0; i < N; i++)                                                     //Korekta wszystkich wag zgodnie z reguła delta
                {
                    weights[i] = weights[i] + step * (desiredOutput - output) * inputs[i];
                }

                k++;                                                                            

            }


            int count = 1;                                                                      //Wypisanie wyniku uczenia
            foreach (var weight in weights)
            {
                
                Console.WriteLine("Waga {0}: {1}", count++, weight);

            }
            Console.WriteLine("Wyjście: {0}", output);
            Console.WriteLine("W kroku {0}", k);
        }
    }
}
