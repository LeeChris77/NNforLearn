using System;
using System.IO;
using Neuros;
namespace NeurosMain
{
    class ControlBlock
    {
        static void Main(string[] args)
        {
            //string[] ChosseFunctionName = { "Identity", "BinaryStep", "Sigmoid" };
            //StreamWriter sw = new StreamWriter(@"D:\Desktop\Activation_Data\" + ChosseFunctionName[0] + ".txt");
            //Console.WriteLine(@"D:\Desktop\Activation_Data\" + ChosseFunctionName[0]);
            //Random rnd = new Random();
            double bias = 1;
            double[] x = {bias, 0, 0 };
            double[] w = {bias, 0, 1 };
            //CreateNeuros nur = new CreateNeuros(x, w, 0.8, "sigmoid");
        }
    }
}
