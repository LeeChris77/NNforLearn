using System;

namespace Neuros
{
    public class CreateNeuros
    {
        public double NeurosCal(double[]x , double[]w)
        {
            double cal=0;
            if(x.Length == w.Length)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    cal += x[i] * w[i];
                }
            }
            return cal;
        }
    }
}
