// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using System;

    /// <summary> 提供了 <see cref="Nullable{T}" /> 相关的工具方法。 </summary>
    /// <typeparam name="TValue"> 值类型。 </typeparam>
    public static class NullableUtilities<TValue> where TValue : struct
    {
        /// <summary>
        /// 当可为空的 <typeparamref name="TValue" /> 类型的值 <see cref="Nullable{T}.HasValue" /> 为 <see langword="true" /> 时，返回 <see
        /// cref="Nullable{T}.Value" />；否则返回 <paramref name="ifNull" />。
        /// </summary>
        /// <param name="value"> 需要校验的可为空的 <typeparamref name="TValue" /> 类型的值。 </param>
        /// <param name="ifNull"> 当 <see cref="Nullable{T}.HasValue" /> 为 <see langword="false" /> 时的返回值。 </param>
        /// <returns> <typeparamref name="TValue" /> 类型的值。 </returns>
        /// <seealso cref="Nullable" />
        /// <seealso cref="Nullable{T}" />
        public static TValue NullGet(TValue? value, TValue ifNull) => value ?? ifNull;
    }
}