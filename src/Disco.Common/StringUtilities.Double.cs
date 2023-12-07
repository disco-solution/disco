// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using Disco.Resources;
    using System;

    public static partial class StringUtilities
    {
        /// <summary> 尝试将等效的字符串 <paramref name="s" /> 转换成可为空的 <see cref="double" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <returns>
        /// 可为空的 <see cref="double" /> 类型的值。
        /// <para>
        /// 当 <see cref="TryToDouble(string, out double)" /> 返回 <see langword="false" /> 时，返回 <see langword="null" />；否则返回 <see
        /// cref="double" /> 类型的值。
        /// </para>
        /// </returns>
        /// <seealso cref="TryToDouble(string, out double)" />
        public static double? AsDouble(string s) => TryToDouble(s, out double value) ? null : new double?(value);

        /// <summary> 将等效的字符串 <paramref name="s" /> 转换成 <see cref="double" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <returns> <see cref="double" /> 类型的值。 </returns>
        /// <exception cref="ArgumentNullException"> 当 <paramref name="s" /> 等于 <see langword="null" />、长度等于 0 或全部为空白符时，将引发此类型的异常。 </exception>
        /// <exception cref="FormatException"> 当调用 <see cref="double.Parse(string)" /> 方法时，可能引发此类型的异常。 </exception>
        /// <exception cref="OverflowException"> 当调用 <see cref="double.Parse(string)" /> 方法时，可能引发此类型的异常。 </exception>
        public static double ToDouble(string s)
        {
            return string.IsNullOrWhiteSpace(s)
                ? throw new ArgumentNullException(
                    nameof(s),
                    SR.Format("ArgumentNullException_exception_message_with_argument_name", nameof(s)))
                : double.Parse(s);
        }

        /// <summary> 尝试将等效的字符串 <paramref name="s" /> 转换成 <see cref="double" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <param name="value"> <see cref="double" /> 类型的值。 </param>
        /// <returns> <see cref="double.TryParse(string, out double)" /> 方法返回值。 </returns>
        /// <seealso cref="double.TryParse(string, out double)" />
        public static bool TryToDouble(string s, out double value) => double.TryParse(s, out value);
    }
}