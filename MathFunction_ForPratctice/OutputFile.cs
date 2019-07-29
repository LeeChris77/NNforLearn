using System;
using System.Collections.Generic;
using System.IO;
//using System.Text;

namespace MathFunction_ForPratctice
{
    class OutputFile
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
            Activation act = new Activation();
            StreamWriter sw = new StreamWriter(path);
            List<double> y_cal = new List<double>();
            switch (FunctionName)
            {
                case "Identity":
                    foreach (var item in act.Func_Identity(Data))
                    {
                        y_cal.Add(item);
                    }
                    break;
                case "BinaryStep":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_BinaryStep(Data)[i];
                    }
                    break;
                case "Sigmoid":
                    for(int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_Sigmoid(Data)[i];
                    }
                    break;
                case "Tanh":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_Tanh(Data)[i];
                    }
                    break;
                //case "Arctan":
                //    for (int i = 0; i < Data.Count; i++)
                //    {
                //        sw.Write(Data[i].ToString("F4") + " " + (act.Func_ArcTan(Data)[i]).ToString("F8") + Environment.NewLine);
                //    }
                //    sw.Close();
                //    Console.WriteLine("建置檔案成功!檔案路徑為:" + path);
                //    break;
                case "Softsign":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_Softsign(Data)[i];
                    }
                    break;
                case "ReLU":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_ReLU(Data)[i];
                    }
                    break;
                case "LeakyReLU":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_LeakyReLU(Data)[i];
                    }
                    break;
                //case "Prelu":
                //    for (int i = 0; i < Data.Count; i++)
                //    {
                //        sw.Write(Data[i].ToString("F4") + " " + (act.Func_PReLU(Data)[i]).ToString("F8") + Environment.NewLine);
                //    }
                //    sw.Close();
                //    Console.WriteLine("建置檔案成功!檔案路徑為:" + path);
                //    break;
                case "SELU":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_SELU(Data)[i];
                    }
                    break;
                case "SReLU":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_SReLU(Data)[i];
                    }
                    break;
                case "HardSigmoid":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_HardSigmoid(Data)[i];
                    }
                    break;
                case "HardTanh":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_HardTanh(Data)[i];
                    }
                    break;
                case "LeCunTanh":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_LeCunTanh(Data)[i];
                    }
                    break;
                case "SoftPlus":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_SoftPlus(Data)[i];
                    }
                    break;
                case "Signum":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_Signum(Data)[i];
                    }
                    break;
                case "BentIdentity":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_BentIdentity(Data)[i];
                    }
                    break;
                case "SymmetricalSigmoid":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_SymmetricalSigmoid(Data)[i];
                    }
                    break;
                case "LogLog":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_LogLog(Data)[i];
                    }
                    break;
                case "Gaussian":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_Gaussian(Data)[i];
                    }
                    break;
                case "Absolute":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_Absolute(Data)[i];
                    }
                    break;
                case "Sinusoid":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_Sinusoid(Data)[i];
                    }
                    break;
                case "Cos":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_Cos(Data)[i];
                    }
                    break;
                case "Sinc":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        y_cal[i] = act.Func_Sinc(Data)[i];
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
                    int i = 0;
                    sw.Write(Data[i].ToString("F4") + " " + item.ToString("F8") + Environment.NewLine);
                    i++;
                }
                sw.Close();
                Console.WriteLine("已建置檔案!File路徑:"+path);
            }
            
            
        }
    }
}
