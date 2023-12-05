// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using Disco.Resources;
    using System;

    public static partial class StringUtilities
    {
        /// <summary> 将等效的字符串 <paramref name="s" /> 转换成 <see cref="int" /> 类型的值。 </summary>
        /// <param name="s"> 等效的字符串。 </param>
        /// <returns> <see cref="int" /> 类型的值。 </returns>
        /// <exception cref="ArgumentNullException"> 当 <paramref name="s" /> 等于 <see langword="null" />、长度等于 0 或全部为空白符时，将引发此类型的异常。 </exception>
        /// <exception cref="FormatException"> 当调用 <see cref="int.Parse(string)" /> 方法时，可能引发此类型的异常。 </exception>
        /// <exception cref="OverflowException"> 当调用 <see cref="int.Parse(string)" /> 方法时，可能引发此类型的异常。 </exception>
        public static int ToInt32(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentNullException(nameof(s), SR.Format("ArgumentNullException_exception_message_with_argument_name", nameof(s)));
            }

            return int.Parse(s);
        }
    }
}