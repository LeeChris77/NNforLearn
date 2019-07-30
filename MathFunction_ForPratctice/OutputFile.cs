using System;
using System.IO;
using System.Collections.Generic;
using Activation;
//using System.Text;

namespace OutputFile
{
    class OutputFilelib
    {
        public static List<double> CRTlist(int star, int end, double stride)
        {
            List<double> crtlist = new List<double>();
            for (double i = star; i < end; i += stride)
            {
                crtlist.Add(i);
            }
            //foreach (var item in crtlist)
            //{
            //    Console.WriteLine(item);
            //}
            return crtlist;
        }  //建立清單 List(起點,終點,遞增步幅)
        public void Data_toTXT(List<double> Data, string FunctionName, string path)
        {
            ActivationLib act = new ActivationLib();
            StreamWriter sw = new StreamWriter(path);
            List<double> y_cal = new List<double>();
            int cont = 0;
            switch (FunctionName)
            {
                case "Identity":
                    foreach (var item in act.Func_Identity(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "BinaryStep":
                    foreach (var item in act.Func_BinaryStep(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "Sigmoid":
                    foreach (var item in act.Func_Sigmoid(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "Tanh":
                    foreach (var item in act.Func_Tanh(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "ArcTan":
                    foreach (var item in act.Func_ArcTan(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "Softsign":
                    foreach (var item in act.Func_Softsign(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "ReLU":
                    foreach (var item in act.Func_ReLU(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "LeakyReLU":
                    foreach (var item in act.Func_LeakyReLU(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "PReLU"://*
                    foreach (var item in act.Func_PReLU(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "RReLU"://*
                    foreach (var item in act.Func_RReLU(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "ELU"://*
                    foreach (var item in act.Func_ELU(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "SELU":
                    foreach (var item in act.Func_SELU(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "SReLU":
                    foreach (var item in act.Func_SReLU(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "HardSigmoid":
                    foreach (var item in act.Func_HardSigmoid(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "HardTanh":
                    foreach (var item in act.Func_HardTanh(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "LeCunTanh":
                    foreach (var item in act.Func_LeCunTanh(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "SoftPlus":
                    foreach (var item in act.Func_SoftPlus(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "Signum":
                    foreach (var item in act.Func_Signum(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "BentIdentity":
                    foreach (var item in act.Func_BentIdentity(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "SymmetricalSigmoid":
                    foreach (var item in act.Func_SymmetricalSigmoid(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "LogLog":
                    foreach (var item in act.Func_LogLog(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "Gaussian":
                    foreach (var item in act.Func_Gaussian(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "Absolute":
                    foreach (var item in act.Func_Absolute(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "Sinusoid":
                    foreach (var item in act.Func_Sinusoid(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "Cos":
                    foreach (var item in act.Func_Cos(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "Sinc":
                    foreach (var item in act.Func_Sinc(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                default:
                    sw.Write("None Data.");
                    sw.Close();
                    Console.WriteLine("無輸出結果,請查明激活函式名稱!");
                    break;
            }
            if(y_cal.Count > 0)
            {
                foreach (var item in y_cal)
                {
                    sw.Write(Data[cont].ToString("F4") + " " + item.ToString("F8") + Environment.NewLine);
                    cont++;
                }
                sw.Close();
                Console.WriteLine("已建置檔案!File路徑:"+path);
            }
            else
            {
                Console.WriteLine("尚未有運算結果!");
            }
            
            
        }
    }
}
