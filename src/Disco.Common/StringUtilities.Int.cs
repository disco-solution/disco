// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using Disco.Resources;
    using System;

    public static partial class StringUtilities
    {
        /// <summary> 尝试将等效的字符串 <paramref name="s" /> 转换成可为空的 <see cref="int" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <returns>
        /// 可为空的 <see cref="int" /> 类型的值。
        /// <para>
        /// 当 <see cref="TryToInt32(string, out int)" /> 返回 <see langword="false" /> 时，返回 <see langword="null" />；否则返回 <see
        /// cref="int" /> 类型的值。
        /// </para>
        /// </returns>
        /// <seealso cref="TryToInt32(string, out int)" />
        public static int? AsInt32(string s) => TryToInt32(s, out int value) ? null : new int?(value);

        /// <summary> 将等效的字符串 <paramref name="s" /> 转换成 <see cref="int" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <returns> <see cref="int" /> 类型的值。 </returns>
        /// <exception cref="ArgumentNullException"> 当 <paramref name="s" /> 等于 <see langword="null" />、长度等于 0 或全部为空白符时，将引发此类型的异常。 </exception>
        /// <exception cref="FormatException"> 当调用 <see cref="int.Parse(string)" /> 方法时，可能引发此类型的异常。 </exception>
        /// <exception cref="OverflowException"> 当调用 <see cref="int.Parse(string)" /> 方法时，可能引发此类型的异常。 </exception>
        public static int ToInt32(string s)
        {
            return string.IsNullOrWhiteSpace(s)
                ? throw new ArgumentNullException(
                    nameof(s),
                    SR.Format("ArgumentNullException_exception_message_with_argument_name", nameof(s)))
                : int.Parse(s);
        }

        /// <summary> 尝试将等效的字符串 <paramref name="s" /> 转换成 <see cref="int" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <param name="value"> <see cref="int" /> 类型的值。 </param>
        /// <returns> <see cref="int.TryParse(string, out int)" /> 方法返回值。 </returns>
        /// <seealso cref="int.TryParse(string, out int)" />
        public static bool TryToInt32(string s, out int value) => int.TryParse(s, out value);
    }
}