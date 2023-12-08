// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using System;

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