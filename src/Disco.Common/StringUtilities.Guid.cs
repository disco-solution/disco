// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.
namespace Disco
{
    using Disco.Resources;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static partial class StringUtilities
    {
        /// <summary> 尝试将等效的字符串 <paramref name="s" /> 转换成可为空的 <see cref="Guid" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <returns>
        /// 可为空的 <see cref="Guid" /> 类型的值。
        /// <para>
        /// 当 <see cref="TryToGuid(string, out Guid)" /> 返回 <see langword="false" /> 时，返回 <see langword="null" />；否则返回 <see
        /// cref="Guid" /> 类型的值。
        /// </para>
        /// </returns>
        /// <seealso cref="TryToGuid(string, out Guid)" />
        public static Guid? AsGuid(string s) => TryToGuid(s, out Guid value) ? null : new Guid?(value);

        /// <summary> 将等效的字符串 <paramref name="s" /> 转换成 <see cref="Guid" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <returns> <see cref="Guid" /> 类型的值。 </returns>
        /// <exception cref="ArgumentNullException"> 当 <paramref name="s" /> 等于 <see langword="null" />、长度等于 0 或全部为空白符时，将引发此类型的异常。 </exception>
        /// <exception cref="FormatException"> 当调用 <see cref="Guid.Parse(string)" /> 方法时，可能引发此类型的异常。 </exception>
        /// <exception cref="OverflowException"> 当调用 <see cref="Guid.Parse(string)" /> 方法时，可能引发此类型的异常。 </exception>
        public static Guid ToGuid(string s)
        {
            return string.IsNullOrWhiteSpace(s)
                ? throw new ArgumentNullException(
                    nameof(s),
                    SR.Format("ArgumentNullException_exception_message_with_argument_name", nameof(s)))
                : Guid.Parse(s);
        }

        /// <summary> 尝试将等效的字符串 <paramref name="s" /> 转换成 <see cref="Guid" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <param name="value"> <see cref="Guid" /> 类型的值。 </param>
        /// <returns> <see cref="Guid.TryParse(string, out Guid)" /> 方法返回值。 </returns>
        /// <seealso cref="Guid.TryParse(string, out Guid)" />
        public static bool TryToGuid(string s, out Guid value) => Guid.TryParse(s, out value);
    }
}
