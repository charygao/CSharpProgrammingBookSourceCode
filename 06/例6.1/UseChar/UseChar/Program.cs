using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseChar
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a';//声明字符letter
            char num = '8';//声明字符num
            //使用IsLetter方法判断letter是否为字母
            Console.WriteLine("判断letter是否为字母：{0}", Char.IsLetter(letter));
            //使用IsDigit方法判断num是否为数字
            Console.WriteLine("判断num是否为数字：{0}", Char.IsDigit(num));
            //使用IsLetterOrDigit方法判断num是否为字母或数字
            Console.WriteLine("判断num是否为字母或数字：{0}", Char.IsLetterOrDigit(num));
            //使用IsLower方法判断letter是否为小写字母
            Console.WriteLine("判断letter是否为小写字母：{0}", Char.IsLower(letter));
            //使用IsUpper方法判断letter是否为大写字母
            Console.WriteLine("判断letter是否为大写字母：{0}", Char.IsUpper(letter));
            //使用IsPunctuation方法判断num是否为标点符号
            Console.WriteLine("判断num是否为标点符号：{0}", Char.IsPunctuation(num));
            //使用IsSeparator方法判断num是否为分隔符
            Console.WriteLine("判断num是否为分隔符：{0}", Char.IsSeparator(num));
            //使用IsWhiteSpace方法判断num是否为空白
            Console.WriteLine("判断num是否为空白：{0}", Char.IsWhiteSpace(num));
            //使用ToUpper方法将letter转换为大写
            Console.WriteLine("将字符转换为大写：{0}", Char.ToUpper(letter));
            //使用ToLower方法将letter转换为小写
            Console.WriteLine("将字符转换为小写：{0}", Char.ToLower(letter));
            Console.ReadLine();
        }
    }
}
