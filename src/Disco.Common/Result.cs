// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using System;

    /// <summary> 提供了安全的方法结果相关的方法。 </summary>
    /// <seealso cref="IResult" />
    public class Result : IResult
    {
        /// <summary> 初始化 <see cref="Result" /> 的新实例。 </summary>
        public Result() : this(null)
        {
        }

        /// <summary> 初始化 <see cref="Result" /> 的新实例。 </summary>
        /// <param name="exception"> 方法执行过程中的异常。 </param>
        public Result(Exception exception)
        {
            ProcessingException = exception;
        }

        /// <inheritdoc />
        public virtual bool HasException
        {
            get { return !(ProcessingException is null); }
        }

        /// <inheritdoc />
        public virtual Exception ProcessingException { get; }

        /// <summary> 创建一个执行成功的方法结果。 </summary>
        /// <returns> 实现了 <see cref="IResult" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IResult" />
        public static IResult Complete() => new Result();

        /// <summary> 创建一个异常的方法结果。 </summary>
        /// <param name="exception">
        /// 方法执行过程中的异常。
        /// <para> <see cref="Exception" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 实现了 <see cref="IResult" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IResult" />
        public static IResult Error(Exception exception) => new Result(exception);
    }
}