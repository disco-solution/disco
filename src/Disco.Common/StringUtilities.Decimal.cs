// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using Disco.Resources;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static partial class StringUtilities
    {
        /// <summary> 尝试将等效的字符串 <paramref name="s" /> 转换成可为空的 <see cref="decimal" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <returns>
        /// 可为空的 <see cref="decimal" /> 类型的值。
        /// <para>
        /// 当 <see cref="TryToDecimal(string, out decimal)" /> 返回 <see langword="false" /> 时，返回 <see langword="null" />；否则返回
        /// <see cref="decimal" /> 类型的值。
        /// </para>
        /// </returns>
        /// <seealso cref="TryToDecimal(string, out decimal)" />
        public static decimal? AsDecimal(string s) => TryToDecimal(s, out decimal value) ? null : new decimal?(value);

        /// <summary> 将等效的字符串 <paramref name="s" /> 转换成 <see cref="decimal" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <returns> <see cref="decimal" /> 类型的值。 </returns>
        /// <exception cref="ArgumentNullException"> 当 <paramref name="s" /> 等于 <see langword="null" />、长度等于 0 或全部为空白符时，将引发此类型的异常。 </exception>
        /// <exception cref="FormatException"> 当调用 <see cref="decimal.Parse(string)" /> 方法时，可能引发此类型的异常。 </exception>
        /// <exception cref="OverflowException"> 当调用 <see cref="decimal.Parse(string)" /> 方法时，可能引发此类型的异常。 </exception>
        public static decimal ToDecimal(string s)
        {
            return string.IsNullOrWhiteSpace(s)
                ? throw new ArgumentNullException(
                    nameof(s),
                    SR.Format("ArgumentNullException_exception_message_with_argument_name", nameof(s)))
                : decimal.Parse(s);
        }

        /// <summary> 尝试将等效的字符串 <paramref name="s" /> 转换成 <see cref="decimal" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <param name="value"> <see cref="decimal" /> 类型的值。 </param>
        /// <returns> <see cref="decimal.TryParse(string, out decimal)" /> 方法返回值。 </returns>
        /// <seealso cref="decimal.TryParse(string, out decimal)" />
        public static bool TryToDecimal(string s, out decimal value) => decimal.TryParse(s, out value);
    }
}