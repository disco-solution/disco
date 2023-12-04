// © 2023 WANG YUCAI. LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.

namespace Disco.Resources
{
    using Disco.Globalization.Resources;
    using System;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    /// <summary> 提供了解析资源字符串相关的方法。 </summary>
    /// <seealso cref="IStringResolver" />
    public class StringResolver : IStringResolver
    {
        /// <summary> 初始化 <see cref="StringResolver" /> 的新实例。 </summary>
        /// <param name="baseName"> 包含了命名空间的资源名称。 </param>
        /// <param name="assm">
        /// 包含了资源的程序集。
        /// <para> <see cref="Assembly" /> 类型的对象实例。 </para>
        /// </param>
        /// <seealso cref="Assembly" />
        /// <seealso cref="ResourceManager.ResourceManager(string, Assembly)" />
        public StringResolver(string baseName, Assembly assm) : this(new ResourceManager(baseName, assm))
        {
        }

        /// <summary> 初始化 <see cref="StringResolver" /> 的新实例。 </summary>
        /// <param name="resourceMgr">
        /// 读取资源字符串相关的方法。
        /// <para> <see cref="ResourceManager" /> 类型的对象实例。 </para>
        /// </param>
        public StringResolver(ResourceManager resourceMgr)
        {
            ResourceManager = resourceMgr;
        }

        /// <summary> 初始化 <see cref="StringResolver" /> 的新实例。 </summary>
        /// <param name="resourceType"> 包含了资源的类型。 </param>
        /// <seealso cref="Type" />
        /// <seealso cref="ResourceManager.ResourceManager(Type)" />
        public StringResolver(Type resourceType) : this(new ResourceManager(resourceType))
        {
        }

        /// <inheritdoc />
        public virtual ResourceManager ResourceManager
        {
            get;
        }

        /// <summary> Disco 内置的资源管理程序。 </summary>
        /// <value> 获取 <see cref="ResourceManager" /> 类型的对象实例，用于表示 Disco 内置的资源管理程序。 </value>
        /// <seealso cref="ResourceManager" />
        /// <seealso cref="ExposedResourceManager" />
        /// <seealso cref="ExposedResourceManager.BuiltInResourceManager" />
        /// <exception cref="MemberAccessException" accessor="get"> </exception>
        protected virtual ResourceManager BuiltInResourceManager
        {
            get
            {
                return ExposedResourceManager.BuiltInResourceManager.Value;
            }
        }

        /// <inheritdoc />
        /// <exception cref="MissingManifestResourceException"> </exception>
        /// <exception cref="MissingSatelliteAssemblyException"> </exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "Ex0200:Member is documented as throwing exception not documented on member in base or interface type", Justification = "<挂起>")]
        public virtual string GetString(string resourceName, CultureInfo culture)
        {
            InvalidResourceName(resourceName);
            return (culture is null) ? ResourceManager.GetString(resourceName) : ResourceManager.GetString(resourceName, culture);
        }

        /// <inheritdoc />
        public virtual string GetString(string resourceName)
        {
            return GetString(resourceName);
        }

        /// <summary>
        /// 当 <paramref name="resourceName" /> 等于 <see langword="null" />、长度等于 0 或全部为空白符时，将引发一个 <see
        /// cref="ArgumentNullException" /> 类型的异常。
        /// </summary>
        /// <param name="resourceName"> 需要校验的资源名称。 </param>
        /// <exception cref="ArgumentNullException"> </exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
        protected virtual void InvalidResourceName(string resourceName)
        {
            if (string.IsNullOrWhiteSpace(resourceName))
            {
                throw new ArgumentNullException(nameof(resourceName), BuiltInResourceManager.GetString("ArgumentNullException_default_exception_message"));
            }
        }
    }
}