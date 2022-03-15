using System;
using System.Text;

namespace H.M._5._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region stringMethods

            string word = "Lorem";
            string word2 = "lorem";
            Console.WriteLine(word.ToLower().Equals(word2.ToLower()));
            //Console.WriteLine(word.Length);
            //Console.WriteLine(word.ToUpper());
            //Console.WriteLine(word.ToLower());

            string word3 = "     t      est    ";
            //Console.WriteLine(word3.Trim());
            //Console.WriteLine(word3.TrimStart());
            //Console.WriteLine(word3.TrimEnd());
            //Console.WriteLine(word.Replace("o","a"));

            //Console.WriteLine(String.Concat(word,word3));
            //Console.WriteLine(word+word3);

            //Console.WriteLine(word.IndexOf("Lo"));
            //Console.WriteLine(word.LastIndexOf("o"));

            string word4 = "";
            string word5 = " ";
            //Console.WriteLine(String.IsNullOrEmpty(word5));
            //Console.WriteLine(String.IsNullOrWhiteSpace(word5.Trim()));

            string[] names = { "lorem", "ipsum" };

            //string word6=String.Join(" ", names);
            //Console.WriteLine(word6);

            string word6 = "lorem ipsum testd";
            string[] newArr = word .Split("t");
            foreach (var item in newArr)
            {
                //Console.WriteLine(item);
            }

            int[] numbers = { 1, -5,6 };
            //Array.Sort(numbers);
            foreach (var item in numbers)
                {
                Console.WriteLine(item);
            }
            //Array.Resize(ref numbers, 5);

            static int[] ArrayResize(ref int[] arr, int length)
            {
                int[] newArr = new int[length];
                for (int i = 0; i < length; i++)
                {
                    newArr[i] = arr[i];
                }
                return newArr;
            }









            #endregion

















            //  Console.WriteLine(ReverseWord("Fuad"));
            #region refout
            //int num = 4;
            //int num2 = num;
            //num2 = 5;
            //Console.WriteLine(num);

            //ref and out key word 

            //int num;
            //ChangeNum(out num);
            //Console.WriteLine($"outside {num}");

            //int[] numbers = { 1, 2, 3 };
            //ChangeIndex(numbers);
            //Console.WriteLine($"outside{numbers[0]}");
            #endregion

            //string word = "Hello";
            //string word2 = word;
            //word2 = "hi";

            //string word3 = "hi";
            //word3 = "test";
            //Console.WriteLine(word2 == word3);

        }

        #region ReverseWord
        //static string ReverseWord (string word)
        //{
        //    string newWord = String.Empty;
        //    for (int i = word.Length-1; i >= 0; i--)
        //    {
        //        newWord += word[i];

        //    }
        //    return newWord;
        //}
        #region StringBuilder
        //StringBuidler
        static StringBuilder ReverseWord(string word)
        {
            StringBuilder newString = new StringBuilder();

            string newWord = String.Empty;
            //string newWord
            for (int i = word.Length - 1; i >= 0; i--)
            {
                newString.Append(word[i]);
            }
            return newString;
        }
        #endregion


        #endregion
        #region ChangeNum
        static void ChangeNum(out int n)
        {
            n = 10;
            Console.WriteLine($"method {n}");
        }
        #endregion
        #region ChangeIndex
        static void ChangeIndex(int[] arr)
        {
            arr[0] = 10;
            Console.WriteLine($"method{arr[0]}");
        }
        #endregion





      
    }




}
