// driver di C# per il codice di quantum
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using static System.Console;

namespace Quantum.Primo_Progetto_QSharp
{
    internal class Driver
    {
        private static void Main()
        {
            using (var qsim = new QuantumSimulator())
            {
                Clear();
                HelloQ.Run(qsim).Wait();
                // prova i valori iniziali
                Result[] initials = new Result[] { Result.Zero, Result.One };
                foreach (Result initial in initials)
                {
                    var res = BellTest.Run(qsim, 1000, initial).Result;
                    var (numZeros, numOnes, agree) = res;
                    WriteLine($"Init:{initial,-4} 0s={numZeros,-4} 1s={numOnes,-4} agree={agree,-4}");
                }
            }
            ReadKey();
        }
    }
}