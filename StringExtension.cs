using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkExtensions
{
    public static class StringExtension
    {
        /// <summary>
		/// Returns true if string is null or empty.
		/// </summary>
		public static bool pIsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static string pSafeTrim(this string input)
        {
            // 檢查輸入是否為null或空字串
            if (string.IsNullOrEmpty(input))
            {
                // 如果是，返回空字串
                return string.Empty;
            }
            else
            {
                // 否則，執行trim操作
                return input.Trim();
            }
        }

        public static bool pAny(this string s)
        {
            bool any = (s != null && s.Trim() != "");
            return any;
        }
    }
}
