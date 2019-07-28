using System;
using System.Collections.Generic;
namespace MathFunction_ForPratctice
{
    class Control
    {
        static void Main(string[] args)
        {
            //DataBlock
            double[] y_true = new double[] { -2.83, -0.95, -0.88, 1.21, -1.67, 0.83, -0.27, 1.36, -0.34, 0.48, -2.83, -0.95, -0.88, 1.21, -1.67, -2.99, 1.24, 0.64 }; //
            double[] y_pred = new double[] { -0.28,- 0.9, -1.72, 1.92, -0.17, -0.04, 1.63, -0.12, 0.14, -1.96, 1.3, -2.51, -0.93, 0.39, -0.06, -1.29, 1.41, 2.37 }; //
            //double[] y1_true = new double[] { 1.0, 5.0, 4.0, 3.0, 2.0, 5.0, -3.0 };
            //double[] y1_pred = new double[] { 1.0, 4.5, 3.5, 5.0, 8.0, 4.5, 1.0 };
            //double[] y2_true = new double[] { 1.0 }; //1.0
            //double[] y2_pred = new double[] { 1.0 }; //1.6667
            double[,] data = new double[,] { {0.4, 0.3, 0.3 },
                                             {0.3, 0.4, 0.3 },
                                             {0.5, 0.2, 0.3 },
                                             {0.8, 0.1, 0.1 } };

            double[,] encode = new double[,] { {1, 0, 0 },
                                               {0, 1, 0 },
                                               {1, 0 ,0 },
                                               {0, 0 ,1 } };

            //Console Block
            Loss loss = new Loss();
            Console.WriteLine("MAE:" + loss.MAE(y_true, y_pred));
            Console.WriteLine("MSE:" + loss.MSE(y_true, y_pred));
            Console.WriteLine("RMAE:" + loss.RMSE(y_true, y_pred));
            Console.WriteLine("MPAE:" + loss.MAPE(y_true, y_pred) + "%");
            Console.WriteLine("SMAPE:" + loss.SMAPE(y_true, y_pred) + "%");
            Console.WriteLine("Mean Huberloss:" + loss.Mean_huberloss(y_true, y_pred, 10));
            Console.WriteLine("Cross Entropy:" + loss.Cross_entropy(data, encode));


            OutputFile OPF = new OutputFile();
            List<double> rangeList = OutputFile.CRTlist(-5, 5, 0.1);
            OPF.Data_toTXT(rangeList, "", @"D:\Desktop\Activation_Data\sigmoid.txt");

            

            



        }
        
    }
    
}
