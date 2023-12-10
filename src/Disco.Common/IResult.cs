// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using System;

    /// <summary> 定义了安全的方法结果的接口。 </summary>
    public interface IResult
    {
        /// <summary> 执行过程中是否抛出了异常。 </summary>
        /// <value> 获取一个 <see cref="bool" /> 类型值，用于表示执行过程中是否抛出了异常。 </value>
        bool HasException { get; }

        /// <summary> 方法执行中抛出的异常。 </summary>
        /// <value> 获取 <see cref="Exception" /> 类型的对象实例，用于表示方法执行中抛出的异常。 </value>
        /// <seealso cref="Exception" />
        Exception ProcessingException { get; }
    }
}