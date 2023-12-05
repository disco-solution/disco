// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using System;

    /// <summary> 提供了 <see cref="string" /> 相关的辅助方法。 </summary>
    public static class StringUtilities
    {
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