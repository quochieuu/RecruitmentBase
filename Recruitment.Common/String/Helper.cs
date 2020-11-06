using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Recruitment.Common.String
{
    public class Helper
    {
        public static string ToUnsignString(string input)
        {
            input = input.Trim();
            for (int i = 0x20; i < 0x30; i++)
            {
                input = input.Replace(((char)i).ToString(), " ");
            }
            input = input.Replace(".", "-");
            input = input.Replace(" ", "-");
            input = input.Replace(",", "-");
            input = input.Replace(";", "-");
            input = input.Replace(":", "-");
            input = input.Replace("  ", "-");
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string str = input.Normalize(NormalizationForm.FormD);
            string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?") >= 0)
            {
                str2 = str2.Remove(str2.IndexOf("?"), 1);
            }
            while (str2.Contains(" "))
            {
                str2 = str2.Replace(" ", "-").ToLower();
            }
            return str2;
        }

        public static string UpperToLower(string chuoi)
        {
            char[] array;
            int len = chuoi.Length;
            array = chuoi.ToCharArray(0, len); // chuyen chuoi thanh mang ky tu.                       
            string chuthuong = "";
            for (int i = 0; i < len; i++)
                chuthuong += Convert.ToString(Char.ToLower(array[i]));
            return chuthuong;
        }


        public static string ToLower(string chuoi)
        {
            return UpperToLower(ToUnsignString(chuoi));
        }

        /*chuyển -- nguyen van  -- thành -- nv */
        public static string SplitString(string LastName)
        {
            string[] catchuoi = LastName.Split(' ');
            string chuoi = "";
            for (int i = 0; i < catchuoi.Length; i++)
                if (catchuoi[i].Trim() != "")
                    chuoi += catchuoi[i].Trim().Substring(0, 1);
            return chuoi;
        }
        public string StringUserName(string firstName, string lastName)
        {
            var _firstName = ToUnsignString(firstName);
            var _lastName = ToUnsignString(lastName);
            var _userName = UpperToLower(_firstName + SplitString(_lastName));
            return _userName;
        }


        public static bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public static bool IsNumberRegex(string pText)
        {
              Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
                return regex.IsMatch(pText);
        }
        
    }
}

