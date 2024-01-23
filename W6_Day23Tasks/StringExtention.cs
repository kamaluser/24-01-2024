using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6_Day23Tasks
{
    internal static class StringExtention
    {
        public static bool IsContainsDigit(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i])) return true;
            }
            return false;
        }

        public static string ToCapitalize(this string str)
        {
            if(string.IsNullOrWhiteSpace(str)) return str;
            return char.ToUpper(str[0]) + str.Substring(1);
        }

        public static int[] GetValueIndexes(this string text, char ch)
        {
            int[] arr = new int[0];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ch)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }
            }
            return arr;
        }

        public static string GetFirstSentence(this string text)
        {
            string[] sentences = text.Split('.','?','!');
            return sentences.Length > 0 ? sentences[0] : string.Empty;
        }

        public static string GetSecondWord(this string str)
        {
            string[] words = str.Trim().Split(' ');
            return words.Length > 1 ? words[1] : string.Empty;
        }
    }
}
