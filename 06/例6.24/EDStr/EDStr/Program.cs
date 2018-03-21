using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace EDStr
{
    class Program
    {
        static string encryptKey = "Oyea";//定义加密密钥
        static void Main(string[] args)
        {
            Console.Write("请输入要加密的字符串：");
            string strOld = Console.ReadLine();//记录要加密的字符串
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider();//实例化加解密类对象
            byte[] key = Encoding.Unicode.GetBytes(encryptKey);//定义字节数组，用来存储密钥
            byte[] data1 = Encoding.Unicode.GetBytes(strOld);//定义字节数组，用来存储要加密的字符串
            MemoryStream MStream = new MemoryStream();//实例化内存流对象
            //使用内存流实例化加密流对象 
            CryptoStream CStream = new CryptoStream(MStream, descsp.CreateEncryptor(key, key), CryptoStreamMode.Write);
            CStream.Write(data1, 0, data1.Length);//向加密流中写入数据
            CStream.FlushFinalBlock();//释放加密流
            string strEncrypt = Convert.ToBase64String(MStream.ToArray());//加密字符串
            Console.WriteLine("加密后的字符串：" + strEncrypt);//输出加密后的字符串
            byte[] data2 = Convert.FromBase64String(strEncrypt);//定义字节数组，用来存储要解密的字符串
            MStream = new MemoryStream();//实例化内存流对象
            //使用内存流实例化解密流对象
            CStream = new CryptoStream(MStream, descsp.CreateDecryptor(key, key), CryptoStreamMode.Write);
            CStream.Write(data2, 0, data2.Length);//向解密流中写入数据
            CStream.FlushFinalBlock();//释放解密流
            string strDecrypt = Encoding.Unicode.GetString(MStream.ToArray());//解密字符串
            Console.WriteLine("解密后的字符串：" + strDecrypt);//输出解密后的字符串
            MStream.Close();//关闭内存流
            CStream.Close();//关闭加密解密流
            Console.ReadLine();
        }
    }
}
