// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using Disco.Resources;
    using System;
    using System.Runtime.Serialization;

    /// <summary> 当 Disco 包含了未处理错误时，将引发此类型的异常。 </summary>
    /// <seealso cref="Exception" />
    [Serializable]
    public class DiscoException : Exception
    {
        /// <summary> 初始化 <see cref="DiscoException" /> 的新实例。 </summary>
        public DiscoException() : this(null, null)
        {
        }

        /// <summary> 初始化 <see cref="DiscoException" /> 的新实例。 </summary>
        /// <param name="message"> 异常描述信息。 </param>
        public DiscoException(string message) : this(message, null)
        {
        }

        /// <summary> 初始化 <see cref="DiscoException" /> 的新实例。 </summary>
        /// <param name="message"> 异常描述信息。 </param>
        /// <param name="innerException">
        /// 引发此异常的异常。
        /// <para> <see cref="Exception" /> 类型的对象实例。 </para>
        /// </param>
        public DiscoException(string message, Exception innerException)
            : base(string.IsNullOrWhiteSpace(message)
                ? SR.GetString("DiscoException_default_exception_message")
                : message, innerException)
        {
        }

        /// <summary> 用序列化数据初始化 <see cref="DiscoException" /> 类的新实例。 </summary>
        /// <param name="info"> 包含有关所引发异常的序列化对象数据的 <see cref="SerializationInfo" />。 </param>
        /// <param name="context"> <see cref="StreamingContext" />，它包含关于源或目标的上下文信息。 </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info" /> 为 <see langword="null" />。 </exception>
        /// <exception cref="SerializationException">
        /// 类名为 <see langword="null" /> 或者 <see cref="P:System.Exception.HResult" /> 为零 (0)。
        /// </exception>
        protected DiscoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}