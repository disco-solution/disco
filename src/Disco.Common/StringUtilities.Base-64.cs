// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using System;

    public static partial class StringUtilities
    {
        /// <summary> 从 <paramref name="base64String" /> 获取字节数组。 </summary>
        /// <param name="base64String"> BASE-64 格式字符串。 </param>
        /// <returns> 字节数组。 </returns>
        /// <seealso cref="Convert" />
        /// <seealso cref="Convert.FromBase64String(string)" />
        /// <exception cref="FormatException"> 当调用 <see cref="Convert.FromBase64String(string)" /> 方式时，可能引发此类型的异常。 </exception>
        public static byte[] FromBase64String(string base64String) 
            => string.IsNullOrEmpty(base64String) ? null : Convert.FromBase64String(base64String);

        /// <summary> 将字节数据 <paramref name="bytes" /> 转换成 BASE-64 格式字符串。 </summary>
        /// <param name="bytes"> 字节数组。 </param>
        /// <param name="options"> <see cref="Base64FormattingOptions" /> 中的一个值。 </param>
        /// <returns> BASE-64 格式字符串。 </returns>
        /// <seealso cref="Convert" />
        /// <seealso cref="Convert.ToBase64String(byte[], Base64FormattingOptions)" />
        /// <seealso cref="Base64FormattingOptions" />
        public static string ToBase64String(byte[] bytes, Base64FormattingOptions options = Base64FormattingOptions.None)
            => bytes is null || bytes.LongLength == 0 ? null : Convert.ToBase64String(bytes, options);
    }
}