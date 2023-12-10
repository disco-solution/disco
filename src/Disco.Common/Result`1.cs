// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
    using System;

    /// <summary> 提供了包含了 <typeparamref name="TReturn" /> 类型返回值的安全方法结果相关的方法。 </summary>
    /// <typeparam name="TReturn"> 真实数据返回值类型。 </typeparam>
    /// <seealso cref="Result" />
    /// <seealso cref="IResult{TReturn}" />
    /// <seealso cref="IResult" />
    public class Result<TReturn> : Result, IResult<TReturn>, IResult
    {
        /// <summary> 初始化 <see cref="Result{TReturn}" /> 的新实例。 </summary>
        public Result() : base()
        {
            Value = default;
        }

        /// <summary> 初始化 <see cref="Result{TReturn}" /> 的新实例。 </summary>
        /// <param name="exception"> 方法执行过程中的异常。 </param>
        public Result(Exception exception) : base(exception)
        {
            Value = default;
        }

        /// <summary> 初始化 <see cref="Result{TReturn}" /> 的新实例。 </summary>
        /// <param name="value"> <typeparamref name="TReturn" /> 类型的方法返回值。 </param>
        public Result(TReturn value) : base(null)
        {
            Value = value;
        }

        /// <inheritdoc />
        public virtual TReturn Value { get; }

        /// <summary> 创建一个 <typeparamref name="TReturn" /> 类型返回值的方法结果。 </summary>
        /// <param name="result"> 真实数据返回值。 </param>
        /// <returns> 实现了 <see cref="IResult{TReturn}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IResult{TReturn}" />
        public static IResult<TReturn> Complete(TReturn result) => new Result<TReturn>(result);

        /// <summary> 创建一个 <typeparamref name="TReturn" /> 类型返回值的方法结果。 </summary>
        /// <returns> 实现了 <see cref="IResult{TReturn}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IResult{TReturn}" />
        public new static IResult<TReturn> Complete() => Complete(default);

        /// <summary> 创建一个异常的方法异常。 </summary>
        /// <param name="exception">
        /// 方法执行过程中的异常。
        /// <para> <see cref="Exception" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 实现了 <see cref="IResult{TReturn}" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IResult{TReturn}" />
        public new static IResult<TReturn> Error(Exception exception) => new Result<TReturn>(exception);
    }
}