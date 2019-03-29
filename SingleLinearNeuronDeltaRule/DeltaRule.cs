using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinearNeuronDeltaRule
{
    class DeltaRule
    {
        public int K { get; set; }
        public int k { get; set; }
        public double Step { get; set; }
        public List<TrainingPattern> TrainingPatterns { get; set; }
        public double[] Weights { get; set; }
        public double Output { get; set; }
        public int Nx { get; set; }
    }
}
