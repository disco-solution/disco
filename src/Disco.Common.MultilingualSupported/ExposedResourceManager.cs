// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco.Globalization.Resources
{
    using System;
    using System.Resources;

    /// <summary> 提供了向外暴露的资源管理程序相关的方法。 </summary>
    /// <seealso cref="ResourceManager" />
    public static class ExposedResourceManager
    {
        /// <summary>
        /// Disco 内置的资源管理程序。
        /// <para> <see cref="ResourceManager" /> 类型的对象实例。 </para>
        /// </summary>
        /// <seealso cref="ResourceManager" />
        /// <seealso cref="Lazy{T}" />
        public static readonly Lazy<ResourceManager> BuiltInResourceManager =
            new Lazy<ResourceManager>(
                () => new ResourceManager(s_builtInResourceBaseName, typeof(ExposedResourceManager).Assembly),
                true);

        private const string s_builtInResourceBaseName = "Disco.Globalization.Resources.Strings";
    }
}