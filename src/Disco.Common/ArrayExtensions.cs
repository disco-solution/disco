// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using System;

    /// <summary> 为 <see cref="Array" /> 类型提供的扩展方法。 </summary>
    public static class ArrayExtensions
    {
        /// <summary> 当数组等于 <see langword="null" /> 或长度等于 0 时，返回 <see langword="false" />；否则返回 <see langword="true" />。 </summary>
        /// <param name="array">
        /// 需要校验的数组。
        /// <para> <see cref="Array" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 当数组等于 <see langword="null" /> 或长度等于 0 时，返回 <see langword="false" />；否则返回 <see langword="true" />。 </returns>
        public static bool HasValue(this Array array)
            => !(array is null || array.LongLength == 0);
    }
}