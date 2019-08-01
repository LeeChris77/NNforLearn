using System;
using System.IO;

namespace Neuros
{
    class ControlBlock
    {
        static void Main(string[] args)
        {
            string[] ChosseFunctionName = { "Identity", "BinaryStep", "Sigmoid" };
            StreamWriter sw = new StreamWriter(@"D:\Desktop\Activation_Data\" + ChosseFunctionName[0] + ".txt");
            Console.WriteLine(@"D:\Desktop\Activation_Data\" + ChosseFunctionName[0]);
        }
    }
}
