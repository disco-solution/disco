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

    /// <summary> 定义了包含 <typeparamref name="TReturn" /> 类型结果值的安全方法结果的接口。 </summary>
    /// <typeparam name="TReturn"> 方法结果类型。 </typeparam>
    /// <seealso cref="IResult" />
    public interface IResult<TReturn> : IResult
    {
        /// <summary> 实际的 <typeparamref name="TReturn" /> 类型的方法返回值。 </summary>
        /// <value> 获取 <typeparamref name="TReturn" /> 类型的对象实例或值，用于表示实际的 <typeparamref name="TReturn" /> 类型的方法返回值。 </value>
        TReturn Value { get; }
    }
}