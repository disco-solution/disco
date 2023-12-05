// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using Disco.Resources;
    using System;
    using System.Text;

    /// <summary> 提供了 <see cref="string" /> 相关的辅助方法。 </summary>
    public static class StringUtilities
    {
        /// <summary> 使用指定的编码 <paramref name="encoding" /> 获取字符串 <paramref name="s" /> 的字节数组。 </summary>
        /// <param name="s"> 字符串。 </param>
        /// <param name="encoding">
        /// 指定的编码。
        /// <para> <see cref="Encoding" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 字节数组。 </returns>
        /// <seealso cref="Encoding" />
        /// <exception cref="ArgumentNullException"> 当 <paramref name="encoding" /> 等于 <see langword="null" /> 时，将引发此类型的异常。 </exception>
        public static byte[] GetBytes(string s, Encoding encoding)
        {
            if (encoding is null)
            {
                throw new ArgumentNullException(nameof(encoding),
                                                SR.Format("ArgumentNullException_exception_message_with_argument_name", nameof(encoding)));
            }

            return s is null ? null : encoding.GetBytes(s);
        }

        /// <summary> 使用 <see cref="UTF8Encoding" /> 获取字符串 <paramref name="s" /> 的字节数组。 </summary>
        /// <param name="s"> 字符串。 </param>
        /// <returns> 字节数组。 </returns>
        /// <seealso cref="Encoding" />
        /// <seealso cref="UTF8Encoding" />
        /// <seealso cref="Encoding.UTF8" />
        public static byte[] GetBytes(string s) => GetBytes(s, Encoding.UTF8);

        /// <summary> 使用指定的编码 <paramref name="encoding" /> 获取字符串。 </summary>
        /// <param name="bytes"> 字节数组。 </param>
        /// <param name="encoding">
        /// 指定的编码。
        /// <para> <see cref="Encoding" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 字符串。 </returns>
        /// <seealso cref="Encoding" />
        /// <exception cref="ArgumentNullException"> 当 <paramref name="encoding" /> 等于 <see langword="null" /> 时，将引发此类型的异常。 </exception>
        public static string GetString(byte[] bytes, Encoding encoding)
        {
            if (encoding is null)
            {
                throw new ArgumentNullException(nameof(encoding),
                                                SR.Format("ArgumentNullException_exception_message_with_argument_name", nameof(encoding)));
            }

            return bytes is null || bytes.LongLength == 0 ? null : encoding.GetString(bytes);
        }

        /// <summary> 使用 <see cref="UTF8Encoding" /> 编码获取字符串。 </summary>
        /// <param name="bytes"> 字节数组。 </param>
        /// <returns> 字符串。 </returns>
        /// <seealso cref="Encoding" />
        /// <seealso cref="UTF8Encoding" />
        /// <seealso cref="Encoding.UTF8" />
        public static string GetString(byte[] bytes) => GetString(bytes, Encoding.UTF8);

        /// <summary>
        /// 当字符串 <paramref name="s" /> 满足 <paramref name="matches" /> 时，返回 <paramref name="ifMatches" /> 返回值，否则返回 <paramref
        /// name="s" />。
        /// </summary>
        /// <param name="s"> 需要校验的字符串。 </param>
        /// <param name="matches">
        /// 校验方法。
        /// <para> <see cref="bool" /> 类型返回值的方法委托。 </para>
        /// </param>
        /// <param name="ifMatches">
        /// 当 <paramref name="s" /> 满足 <paramref name="matches" /> 时，返回的安全值。
        /// <para> <see cref="string" /> 类型返回值的方法委托。 </para>
        /// </param>
        /// <returns> 字符串。 </returns>
        /// <seealso cref="Func{T, TResult}" />
        /// <seealso cref="Func{TResult}" />
        public static string IfGet(string s, Func<string, bool> matches, Func<string> ifMatches)
            => (matches(s)) ? ifMatches() : s;

        /// <summary>
        /// 当字符串 <paramref name="s" /> 满足 <paramref name="matches" /> 时，返回 <paramref name="ifMatches" />，否则返回 <paramref name="s" />。
        /// </summary>
        /// <param name="s"> 需要校验的字符串。 </param>
        /// <param name="matches">
        /// 校验方法。
        /// <para> <see cref="bool" /> 类型返回值的方法委托。 </para>
        /// </param>
        /// <param name="ifMatches"> 当 <paramref name="s" /> 满足 <paramref name="matches" /> 时，返回的安全值。 </param>
        /// <returns> 字符串。 </returns>
        /// <seealso cref="Func{T, TResult}" />
        public static string IfGet(string s, Func<string, bool> matches, string ifMatches = "")
            => IfGet(s, matches, () => ifMatches);

        /// <summary>
        /// 当 <paramref name="s" /> 等于 <see langword="null" /> 时，返回 <paramref name="ifNull" /> 的返回值；否则返回 <paramref name="s" />。
        /// </summary>
        /// <param name="s"> 需要校验的字符串。 </param>
        /// <param name="ifNull">
        /// 当字符串 <paramref name="s" /> 等于 <see langword="null" /> 时，返回的安全值。
        /// <para> <see cref="string" /> 类型返回值的方法委托。 </para>
        /// </param>
        /// <returns> 字符串。 </returns>
        /// <seealso cref="Func{TResult}" />
        public static string NullGet(string s, Func<string> ifNull)
            => IfGet(s, (str) => str is null, ifNull);

        /// <summary>
        /// 当 <paramref name="s" /> 等于 <see langword="null" /> 时，返回 <paramref name="ifNull" />；否则返回 <paramref name="s" />。
        /// </summary>
        /// <param name="s"> 需要校验的字符串。 </param>
        /// <param name="ifNull"> 当字符串 <paramref name="s" /> 等于 <see langword="null" /> 时，返回的安全值。 </param>
        /// <returns> 字符串。 </returns>
        public static string NullGet(string s, string ifNull = "")
            => NullGet(s, () => ifNull);
    }
}