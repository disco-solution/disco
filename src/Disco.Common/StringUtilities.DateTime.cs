// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using Disco.Resources;
    using System;

    public static partial class StringUtilities
    {
        /// <summary> 尝试将等效的字符串 <paramref name="s" /> 转换成可为空的 <see cref="DateTime" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <returns>
        /// 可为空的 <see cref="DateTime" /> 类型的值。
        /// <para>
        /// 当 <see cref="TryToDateTime(string, out DateTime)" /> 返回 <see langword="false" /> 时，返回 <see langword="null" />；否则返回
        /// <see cref="DateTime" /> 类型的值。
        /// </para>
        /// </returns>
        /// <seealso cref="TryToDateTime(string, out DateTime)" />
        public static DateTime? AsDateTime(string s) => TryToDateTime(s, out DateTime value) ? null : new DateTime?(value);

        /// <summary> 将等效的字符串 <paramref name="s" /> 转换成 <see cref="DateTime" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <returns> <see cref="DateTime" /> 类型的值。 </returns>
        /// <exception cref="ArgumentNullException"> 当 <paramref name="s" /> 等于 <see langword="null" />、长度等于 0 或全部为空白符时，将引发此类型的异常。 </exception>
        /// <exception cref="FormatException"> 当调用 <see cref="DateTime.Parse(string)" /> 方法时，可能引发此类型的异常。 </exception>
        /// <exception cref="OverflowException"> 当调用 <see cref="DateTime.Parse(string)" /> 方法时，可能引发此类型的异常。 </exception>
        public static DateTime ToDateTime(string s)
        {
            return string.IsNullOrWhiteSpace(s)
                ? throw new ArgumentNullException(
                    nameof(s),
                    SR.Format("ArgumentNullException_exception_message_with_argument_name", nameof(s)))
                : DateTime.Parse(s);
        }

        /// <summary> 尝试将等效的字符串 <paramref name="s" /> 转换成 <see cref="DateTime" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <param name="value"> <see cref="DateTime" /> 类型的值。 </param>
        /// <returns> <see cref="DateTime.TryParse(string, out DateTime)" /> 方法返回值。 </returns>
        /// <seealso cref="DateTime.TryParse(string, out DateTime)" />
        public static bool TryToDateTime(string s, out DateTime value) => DateTime.TryParse(s, out value);
    }
}