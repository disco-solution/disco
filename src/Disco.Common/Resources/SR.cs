// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco.Resources
{
    using Disco.Globalization.Resources;
    using System.Globalization;

    /// <summary> 提供了读取内置资源字符串相关的方法。 </summary>
    public static class SR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:命名样式", Justification = "<挂起>")]
        private static readonly IStringResolver s_stringResolver;

        /// <summary> 初始化 <see cref="SR" /> 的新实例。 </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        static SR() => s_stringResolver = new StringResolver(ExposedResourceManager.BuiltInResourceManager.Value);

        /// <summary> 使用名称为 <paramref name="resourceName" /> 的格式化资源字符串进行字符串格式化。 </summary>
        /// <param name="resourceName"> 资源字符串名称。 </param>
        /// <param name="culture">
        /// 指定的文化区域信息。
        /// <para> <see cref="CultureInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <param name="args"> <see cref="string.Format(string, object[])" /> 方法所需的格式化参数数组。 </param>
        /// <returns> 格式化字符串。 </returns>
        /// <seealso cref="CultureInfo" />
        /// <seealso cref="string.Format(string, object[])" />
        /// <exception cref="System.FormatException"> 当调用 <see cref="string.Format(string, object[])" /> 方法时，可能引发此类型的异常。 </exception>
        public static string Format(string resourceName, CultureInfo culture, params object[] args)
            => string.Format(GetString(resourceName, culture), args);

        /// <summary> 使用名称为 <paramref name="resourceName" /> 的格式化资源字符串进行字符串格式化。 </summary>
        /// <param name="resourceName"> 资源字符串名称。 </param>
        /// <param name="args"> <see cref="string.Format(string, object[])" /> 方法所需的格式化参数数组。 </param>
        /// <returns> 格式化字符串。 </returns>
        /// <seealso cref="CultureInfo" />
        /// <seealso cref="string.Format(string, object[])" />
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        public static string Format(string resourceName, params object[] args)
            => Format(resourceName, null, args);

        /// <summary> 获取名称为 <paramref name="resourceName" /> 的资源字符串。 </summary>
        /// <param name="resourceName"> 资源名称。 </param>
        /// <param name="culture">
        /// 指定的文化区域信息。
        /// <para> <see cref="CultureInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> 资源字符串。 </returns>
        /// <seealso cref="CultureInfo" />
        public static string GetString(string resourceName, CultureInfo culture) => s_stringResolver.GetString(resourceName, culture);

        /// <summary> 获取名称为 <paramref name="resourceName" /> 的资源字符串。 </summary>
        /// <param name="resourceName"> 资源名称。 </param>
        /// <returns> 资源字符串。 </returns>
        public static string GetString(string resourceName) => s_stringResolver.GetString(resourceName);
    }
}