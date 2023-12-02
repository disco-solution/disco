// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco.Resources
{
    using System.Globalization;
    using System.Resources;

    /// <summary> 定义了解析资源字符串的接口。 </summary>
    public interface IStringResolver
    {
        /// <summary> 读取资源字符串的方法。 </summary>
        /// <value> 获取 <see cref="System.Resources.ResourceManager" /> 类型的对象实例，用于表示读取资源字符串的方法。 </value>
        /// <seealso cref="System.Resources.ResourceManager" />
        ResourceManager ResourceManager { get; }

        /// <summary> 获取名称为 <paramref name="resourceName" /> 的资源字符串。 </summary>
        /// <param name="resourceName"> 资源名称。 </param>
        /// <param name="culture">
        /// 指定的文化区域信息。
        /// <para> <see cref="CultureInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 资源字符串。 </returns>
        /// <seealso cref="CultureInfo" />
        string GetString(string resourceName, CultureInfo culture);

        /// <summary> 获取名称为 <paramref name="resourceName" /> 的资源字符串。 </summary>
        /// <param name="resourceName"> 资源名称。 </param>
        /// <returns> 资源字符串。 </returns>
        string GetString(string resourceName);
    }
}