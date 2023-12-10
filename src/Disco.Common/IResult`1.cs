// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco
{
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