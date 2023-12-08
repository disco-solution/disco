// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using Disco.Resources;
    using System;
    using System.Text;

    /// <summary> 为 <see cref="string" /> 类型提供的扩展方法。 </summary>
    public static class StringExtensions
    {
        /// <summary> 定义了字符串比较方式枚举类型。 </summary>
        public enum StringComparisonMode
        {
            /// <summary> 仅比较字符串是否等于 <see langword="null" />。 </summary>
            OnlyNull = 1,

            /// <summary> 比较字符串是否等于 <see langword="null" /> 或长度（ <see cref="string.Length" />）等于 0。 </summary>
            NullOrEmpty = 2,

            /// <summary> 比较字符串是否等于 <see langword="null" /> ；长度（ <see cref="string.Length" />）等于 0；或全部为空格符。 </summary>
            NullOrWhiteSpace = 3,

            /// <summary>
            /// 默认的字符串比较方式。
            /// <para> 等效于 <see cref="StringComparisonMode.NullOrWhiteSpace" />。 </para>
            /// </summary>
            Default = NullOrWhiteSpace
        }

        /// <summary> 使用编码 <paramref name="encoding" /> 获取字符串的字节数组。 </summary>
        /// <param name="s"> 字符串。 </param>
        /// <param name="encoding">
        /// 指定的编码。
        /// <para> 派生自 <see cref="Encoding" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 字节数组。 </returns>
        /// <seealso cref="Encoding" />
        /// <exception cref="ArgumentNullException"> 当 <paramref name="encoding" /> 等于 <see langword="null" /> 时，将引发此类型的异常。 </exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
        public static byte[] GetBytes(this string s, Encoding encoding)
        {
            if (encoding is null)
            {
                throw new ArgumentNullException(nameof(encoding), SR.Format("ArgumentNullException_exception_message_with_argument_name", nameof(encoding)));
            }

            return s is null ? null : encoding.GetBytes(s);
        }

        /// <summary> 使用 UTF-8 编码 <see cref="UTF8Encoding" /> 获取字符串的字节数组。 </summary>
        /// <param name="s"> 字符串。 </param>
        /// <returns> 字节数组。 </returns>
        /// <seealso cref="Encoding" />
        /// <seealso cref="Encoding.UTF8" />
        /// <seealso cref="UTF8Encoding" />
        public static byte[] GetBytes(this string s)
            => GetBytes(s, Encoding.UTF8);

        /// <summary> 使用编码 <paramref name="encoding" /> 对字节数组进行解码，并获取字符串。 </summary>
        /// <param name="data"> 字节数组。 </param>
        /// <param name="encoding">
        /// 指定的编码。
        /// <para> 派生自 <see cref="Encoding" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 字符串。 </returns>
        /// <seealso cref="Encoding" />
        /// <exception cref="ArgumentNullException"> 当 <paramref name="encoding" /> 等于 <see langword="null" /> 时，将引发此类型的异常。 </exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
        public static string GetString(this byte[] data, Encoding encoding)
        {
            if (encoding is null)
            {
                throw new ArgumentNullException(nameof(encoding), SR.Format("ArgumentNullException_exception_message_with_argument_name", nameof(encoding)));
            }

            return data.HasValue() ? encoding.GetString(data) : null;
        }

        /// <summary> 使用 UTF-8 编码 <see cref="UTF8Encoding" /> 对字节数组进行解码，并获取字符串。 </summary>
        /// <param name="data"> 字节数组。 </param>
        /// <returns> 字符串。 </returns>
        /// <seealso cref="Encoding" />
        /// <seealso cref="Encoding.UTF8" />
        /// <seealso cref="UTF8Encoding" />
        public static string GetString(this byte[] data) 
            => GetString(data, Encoding.UTF8);

        /// <summary>
        /// 当字符串等于 <see langword="null" />；长度（ <see cref="string.Length" />）等于 0；或全部为空格符时，返回 <paramref name="default" />；否则返回字符串本身。
        /// </summary>
        /// <param name="s"> 需要校验的字符串。 </param>
        /// <param name="default">
        /// 获取默认值的方法。
        /// <para> <see cref="string" /> 类型返回值的方法委托。 </para>
        /// </param>
        /// <param name="compareMode">
        /// 字符串比较方式。
        /// <para> <see cref="StringComparisonMode" /> 中的一个值。 </para>
        /// </param>
        /// <returns> 字符串。 </returns>
        /// <seealso cref="Func{TResult}" />
        /// <seealso cref="string.IsNullOrEmpty(string)" />
        /// <seealso cref="string.IsNullOrWhiteSpace(string)" />
        /// <seealso cref="StringComparisonMode" />
        public static string SafeGet(this string s, Func<string> @default, StringComparisonMode compareMode = StringComparisonMode.Default)
        {
            bool isNullOrWhiteSpace;
            switch (compareMode)
            {
                case StringComparisonMode.OnlyNull:
                    isNullOrWhiteSpace = s is null;
                    break;

                case StringComparisonMode.NullOrEmpty:
                    isNullOrWhiteSpace = string.IsNullOrEmpty(s);
                    break;

                default:
                    isNullOrWhiteSpace = string.IsNullOrWhiteSpace(s);
                    break;
            }

            return isNullOrWhiteSpace ? (@default is null ? string.Empty : @default()) : s;
        }

        /// <summary>
        /// 当字符串等于 <see langword="null" />；长度（ <see cref="string.Length" />）等于 0；或全部为空格符时，返回 <paramref name="default" />；否则返回字符串本身。
        /// </summary>
        /// <param name="s"> 需要校验的字符串。 </param>
        /// <param name="default"> 默认的字符串。 </param>
        /// <param name="compareMode">
        /// 字符串比较方式。
        /// <para> <see cref="StringComparisonMode" /> 中的一个值。 </para>
        /// </param>
        /// <returns> 字符串。 </returns>
        /// <seealso cref="StringComparisonMode" />
        public static string SafeGet(this string s, string @default = "", StringComparisonMode compareMode = StringComparisonMode.Default)
            => SafeGet(s, () => @default, compareMode);
    }
}