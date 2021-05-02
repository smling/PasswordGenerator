using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public static class PasswordGenerator
    {
        private const string LOWERCASE_CHARACTERS = "abcdefghijklmnopqrstuvwxyz";
        private const string UPPERCASE_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string DIGIT_CHARACTERS = "1234567890";
        private const string ALPHAN_CHARACTERS = @"~!@#$%^&*_-+=`|\(){}[]:;""'<>,.?/";

        public static string Generate(PasswordGeneratorCondition condition = null)
        {
            if (condition == null)
                condition = new PasswordGeneratorCondition();

            string value = "";
           
            value += condition.LowercaseCount>0 ? GetRandomString(condition.LowercaseCount, LOWERCASE_CHARACTERS) : "";
            value += condition.UppercaseCount > 0 ? GetRandomString(condition.UppercaseCount, UPPERCASE_CHARACTERS) : "";
            value += condition.AlphanCharacterCount > 0 ? GetRandomString(condition.AlphanCharacterCount, ALPHAN_CHARACTERS) : "";
            value += condition.DigitCount > 0 ? GetRandomString(condition.DigitCount, DIGIT_CHARACTERS) : "";

            return value.Shuffle();
        }

        private static string GetRandomString(int length, string charactors)
        {
            StringBuilder res = new StringBuilder();
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            while (0 < length--)
            {
                res.Append(charactors[rnd.Next(charactors.Length)]);
            }
            return res.ToString();
        }

        private static string Shuffle(this string input)
        {
            char[] source = input.ToArray();
            int cnt = source.Length;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            while (cnt > 1) {
                cnt--;
                int k = rnd.Next(cnt+1);
                char temp = source[k];
                source[k] = source[cnt];
                source[cnt] = temp;
            }
            return new string(source);
        }
    }
}
