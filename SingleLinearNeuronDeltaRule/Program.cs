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

            DeltaRule deltaRule = new DeltaRule(10, 15);

            Console.Write("Wagi początkowe: ");
            for (int i = 0; i < deltaRule.Weights.GetLength(0); i++)
            {
                Console.Write(deltaRule.Weights[i] + ", ");
            }
        }
    }
}
