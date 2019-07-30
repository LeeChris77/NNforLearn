using System;
using System.Collections.Generic;
using OutputFile;
namespace Command
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
            //Loss loss = new Loss();
            //Console.WriteLine("MAE:" + loss.MAE(y_true, y_pred));
            //Console.WriteLine("MSE:" + loss.MSE(y_true, y_pred));
            //Console.WriteLine("RMAE:" + loss.RMSE(y_true, y_pred));
            //Console.WriteLine("MPAE:" + loss.MAPE(y_true, y_pred) + "%");
            //Console.WriteLine("SMAPE:" + loss.SMAPE(y_true, y_pred) + "%");
            //Console.WriteLine("Mean Huberloss:" + loss.Mean_huberloss(y_true, y_pred, 10));
            //Console.WriteLine("Cross Entropy:" + loss.Cross_entropy(data, encode));

            //建立輸出物件
            OutputFilelib OPF = new OutputFilelib(); 
            //呼叫CRTlist方法建構一個 輸入資料集合 引數說明:(開始,結束,間距)
            List<double> rangeList = OutputFilelib.CRTlist(-5, 5, 0.1);
            //List<double> CList = OutputFilelib.CRTlist(-5, 5, 0.1);
            //ACTdata_toTXT引數說明:(傳入List<double>集合, 選用激活函數, @"自定義txt檔儲存路徑")
            OPF.ACTdata_toTXT(rangeList, "Identity", @"D:\Desktop\Activation_Data\Identity.txt");
            OPF.ACTdata_toTXT(rangeList, "BinaryStep", @"D:\Desktop\Activation_Data\BinaryStep.txt");
            OPF.ACTdata_toTXT(rangeList, "Sigmoid", @"D:\Desktop\Activation_Data\Sigmoid.txt");
            OPF.ACTdata_toTXT(rangeList, "ArcTan", @"D:\Desktop\Activation_Data\ArcTan.txt");
            OPF.ACTdata_toTXT(rangeList, "Softsign", @"D:\Desktop\Activation_Data\Softsign.txt");
            OPF.ACTdata_toTXT(rangeList, "ReLU", @"D:\Desktop\Activation_Data\ReLU.txt");
            OPF.ACTdata_toTXT(rangeList, "LeakyReLU", @"D:\Desktop\Activation_Data\LeakyReLU.txt");
            OPF.ACTdata_toTXT(rangeList, "PReLU", @"D:\Desktop\Activation_Data\PReLU.txt");
            OPF.ACTdata_toTXT(rangeList, "RReLU", @"D:\Desktop\Activation_Data\RReLU.txt");
            OPF.ACTdata_toTXT(rangeList, "ELU", @"D:\Desktop\Activation_Data\ELU.txt");
            OPF.ACTdata_toTXT(rangeList, "SELU", @"D:\Desktop\Activation_Data\SELU.txt");
            OPF.ACTdata_toTXT(rangeList, "SReLU", @"D:\Desktop\Activation_Data\SReLU.txt");
            OPF.ACTdata_toTXT(rangeList, "HardSigmoid", @"D:\Desktop\Activation_Data\HardSigmoid.txt");
            OPF.ACTdata_toTXT(rangeList, "HardTanh", @"D:\Desktop\Activation_Data\HardTanh.txt");
            OPF.ACTdata_toTXT(rangeList, "LeCunTanh", @"D:\Desktop\Activation_Data\LeCunTanh.txt");
            OPF.ACTdata_toTXT(rangeList, "SoftPlus", @"D:\Desktop\Activation_Data\SoftPlus.txt");
            OPF.ACTdata_toTXT(rangeList, "Signum", @"D:\Desktop\Activation_Data\Signum.txt");
            OPF.ACTdata_toTXT(rangeList, "BentIdentity", @"D:\Desktop\Activation_Data\BentIdentity.txt");
            OPF.ACTdata_toTXT(rangeList, "SymmetricalSigmoid", @"D:\Desktop\Activation_Data\SymmetricalSigmoid.txt");
            OPF.ACTdata_toTXT(rangeList, "LogLog", @"D:\Desktop\Activation_Data\LogLog.txt");
            OPF.ACTdata_toTXT(rangeList, "Gaussian", @"D:\Desktop\Activation_Data\Gaussian.txt");
            OPF.ACTdata_toTXT(rangeList, "Absolute", @"D:\Desktop\Activation_Data\Absolute.txt");
            OPF.ACTdata_toTXT(rangeList, "Sinusoid", @"D:\Desktop\Activation_Data\Sinusoid.txt");
            OPF.ACTdata_toTXT(rangeList, "Cos", @"D:\Desktop\Activation_Data\Cos.txt");
            OPF.ACTdata_toTXT(rangeList, "Sinc", @"D:\Desktop\Activation_Data\Sinc.txt");









        }

    }
    
}
