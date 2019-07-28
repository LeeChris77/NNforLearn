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
            switch (FunctionName)
            {
                case "Sigmoid":
                    for(int i = 0; i < Data.Count; i++)
                    {
                        sw.Write(Data[i].ToString("F4") + " " + (act.Func_Sigmoid(Data)[i]).ToString("F8") + Environment.NewLine);
                    }
                    sw.Close();
                    Console.WriteLine("建置檔案成功!檔案路徑為:"+path);
                    break;
                case "Identity":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        sw.Write(Data[i].ToString("F4") + " " + (act.Func_Identity(Data)[i]).ToString("F8") + Environment.NewLine);
                    }
                    sw.Close();
                    Console.WriteLine("建置檔案成功!檔案路徑為:"+path);
                    break;
                case "Binarystep":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        sw.Write(Data[i].ToString("F4") + " " + (act.Func_BinaryStep(Data)[i]).ToString("F8") + Environment.NewLine);
                    }
                    sw.Close();
                    Console.WriteLine("建置檔案成功!檔案路徑為:" + path);
                    break;
                case "Tanh":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        sw.Write(Data[i].ToString("F4") + " " + (act.Func_Tanh(Data)[i]).ToString("F8") + Environment.NewLine);
                    }
                    sw.Close();
                    Console.WriteLine("建置檔案成功!檔案路徑為:" + path);
                    break;
                case "Arctan":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        sw.Write(Data[i].ToString("F4") + " " + (act.Func_ArcTan(Data)[i]).ToString("F8") + Environment.NewLine);
                    }
                    sw.Close();
                    Console.WriteLine("建置檔案成功!檔案路徑為:" + path);
                    break;
                case "Softsign":
                    for (int i = 0; i < Data.Count; i++)
                    {
                        sw.Write(Data[i].ToString("F4") + " " + (act.Func_ArcTan(Data)[i]).ToString("F8") + Environment.NewLine);
                    }
                    sw.Close();
                    Console.WriteLine("建置檔案成功!檔案路徑為:" + path);
                    break;
                default:
                    sw.Write("None Data.");
                    sw.Close();
                    Console.WriteLine("無輸出結果,請查明激活函式名稱!");
                    break;
                    //case "Tanh":
                    //    act.Func_Tanh(Data);
                    //    break;
            }
            
        }
    }
}
