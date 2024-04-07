using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Models
{
    static class Helper
    {
        public static bool IsOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            return true;
        }
        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        static bool HasDigit(string a)
        {
            foreach (char b in a)
            {
                if (char.IsDigit(b))
                {
                    return true;
                }
            }
            return false;
        }

        static bool CheckPassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                else if (char.IsLower(c))
                {
                    hasLowerCase = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }
        }
        public static string Capitalize(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
    }
}
