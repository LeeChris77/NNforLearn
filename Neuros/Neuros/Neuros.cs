using System;
using Activation;
namespace Neuros
{
    public class NewNeuros
    {
        ActivationLib Act = new ActivationLib();
        public double OneNeuro(double[]x , double[]w, string ChooseAct)
        {
            double cal=0;
            double neuroValue = 0;
            if (x.Length == w.Length)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    cal += x[i] * w[i];
                }
            }
            switch (ChooseAct)
            {
                case "Sigmoid":
                    neuroValue = Act.SigmoidFunction(cal);
                    break;
            }
            return neuroValue;
        }
    }
}
