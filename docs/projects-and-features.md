# 项目和功能 Projects & Features

![Disco](../assets/Avatar/Disco-48.png)

| 项目 PROJECT                                                  | 程序集 ASSEMBLY | 命名空间 NAMESPACE                       | NuGet 包 NUPKG | 说明 NOTES                                                                                                                                                                                                                                                                                                              |
| ----------------------------------------------------------- | ------------ | ------------------------------------ | ------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Disco.Common.MultilingualSupported`                        | -            | `Disco.Globalization.Resources`      | -             | 提供了国际化多语言支持所需的资源文件。<br />Resource files required for internationalized multilingual support are provided.                                                                                                                                                                                                             |
| `Disco.Common`                                              | -            | `Disco`                              | -             | 此类库提供了 `Disco` 所需的通用功能。<br />Such library provides the common functionality that `Disco` needs.                                                                                                                                                                                                                       |
| `Disco.Core.Abstractions`                                   | -            | `Disco`                              | -             | 此类库仅提供了 `IDiscoApp` 接口定义。<br />Only `IDiscoApp` interface definitions are provided.                                                                                                                                                                                                                                   |
| `Disco.Core`                                                | -            | `Disco.Core`                         | -             | 此类库仅提供了 `IDiscoApp` 的默认实现和扩展方法。<br />Only the default implementation and extension methods of 'IDiscoApp' are provided in this library.                                                                                                                                                                               |
| `Disco.Core.DependencyInjection`                            | -            | `Disco.DependencyInjection`          | -             | 此类库提供了基于 `Microsoft.Extensions.DependencyInjection` 的依赖注入扩展。<br />This library provides a dependency injection extension based on `Microsoft.Extensions.DependencyInjection`.                                                                                                                                         |
| `Disco.Core.DependencyInjection.Unity`                      | -            | `Disco.DependencyInjection`          | -             | 此类库提供了基于 `Unity` 的依赖注入扩展。<br />This library provides a dependency injection extension based on `Unity`. <br /> ⏳这个类库仅适用于 .NET Framework 4.5+ (*Only .NET Framework 4.5+*)                                                                                                                                             |
| `Disco.Common.Logging.Abstractions`                         | -            | `Disco.Runtime.Logging`              | -             | 此类库提供了：输出运行时诊断日志的抽象。<br />Such library provides abstractions for outputting runtime diagnostic logs.                                                                                                                                                                                                                  |
| `Disco.Common.Logging.NLog`                                 | -            | `Disco.Runtime.Logging`              | -             | 此类库提供了基于 [NLog](https://www.nuget.org/packages/NLog) 输出运行时日志的方法。<br/>This library provides methods for outputting runtime logs based on [NLog](https://www.nuget.org/packages/NLog).                                                                                                                                  |
| `Disco.Common.Logging.NLog.DI`                              |              | `Disco.DependencyInjection`          | -             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                    |
| `Disco.Common.Logging.NLog.DI.Unity`                        |              | `Disco.DependencyInjection`          | -             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                    |
| `Disco.Common.Serialization.Abstractions`                   | -            | `Disco.Runtime.Serializations`       | -             | 此类库提供了数据序列化服务的抽象。<br/>This library provides abstractions of data serialization services.                                                                                                                                                                                                                              |
| `Disco.Common.Serialization.Json.NewtonsoftJson`            | -            | `Disco.Runtime.Serializations`       | -             | 此类库提供了基于 [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json) 的 JSON 数据序列化服务。<br/>This library provides a serialization service based on [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json).                                                                                              |
| `Disco.Common.Serialization.Json.NewtonsoftJson.DI`         |              | `Disco.DependencyInjection`          | -             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                    |
| `Disco.Common.Serialization.Json.NewtonsoftJson.DI.Unity`   | -            | `Disco.DependencyInjection`          | -             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                    |
| `Disco.Common.Serialization.Xml`                            | -            | `Disco.Runtime.Serializations`       | -             | 此类库提供了 XML 数据序列化服务。<br/>This library provides a serialization service for XML.                                                                                                                                                                                                                                        |
| `Disco.Common.Serialization.Xml.DI`                         | -            | `Disco.DependencyInjection`          | -             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                    |
| `Disco.Commmon.Serialization.Xml.DI.Unity`                  | -            | `Disco.DependencyInjection`          | -             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                    |
| `Disco.Common.Configuration.Abstractions`                   | -            | `Disco.Configuration`                | -             | 此类库提供了 `Disco` 相关的配置服务抽象。<br/>This library provides the `Disco` configuration service abstractions.                                                                                                                                                                                                                   |
| `Disco.Common.Configuration.ConfigurationManager`           | -            | `Disco.Configuration`                | -             | 此类库提供了基于 `System.Configuration.ConfigurationManager`的经典模式访问配置信息的方法。<br/>This library provides a way to access configurations based on the classic mode of `System.Configuration.ConfigurationManager`.                                                                                                                |
| `Disco.Common.Configuration`                                | -            | `Disco.Configuration`                | -             | 此类库提供了适用于 `.NET` 平台的访问配置的服务实现。<br/>This library provides configuration service for the `.NET` platform.                                                                                                                                                                                                               |
| `Disco.Common.Configuration.DI`                             | -            | `Disco.DependencyInjection`          | -             | :heavy_check_mark:                                                                                                                                                                                                                                                                                                    |
| `Disco.Common.ConfiguartionManager.DI.Unity`                | -            | `Disco.DependencyInjection`          |               | :heavy_check_mark:                                                                                                                                                                                                                                                                                                    |
| `Disco.Client.Configuration.Options`                        | -            | `Disco.Client.Configuration.Options` | -             | `Disco`客户端配置选项定义。<br/>`Disco` client configuration option definitions.                                                                                                                                                                                                                                                |
| `Disco.Client.Configuration.ConfigurationSections`          | -            | `Disco.Client.Configuration`         | -             | 提供了适用于 `.NET Framework` 经典模式配置选项定义。<br/>Definitions of configuration options for the `.NET Framework` classic mode are provided.                                                                                                                                                                                      |
| `Disco.Server.Configuration.Options`                        | -            | `Disco.Server.Configuration.Options` | -             | `Disco` 服务器配置选项定义。<br/>`Disco` server configuration options definition.                                                                                                                                                                                                                                               |
| `Disco.Core.Metadata`                                       | -            | `Disco.Metadata`                     | -             | 此类库提供了配置元数据相关定义。<br/>This library provides definitions for configuration metadata.                                                                                                                                                                                                                                    |
| `Disco.Server.Metadata.Publishing.Abstractions`             | -            | `Disco.Server.Publishing`            | -             | 服务器元数据推送抽象。<br/>Server-side metadata pushing abstractions.                                                                                                                                                                                                                                                            |
| `Disco.Client.Metadata.Subscription.Abstractions`           | -            | `Disco.Client.Subscription`          | -             | 客户端元数据订阅抽象。<br/>Client-side metadata subscription abstractions.                                                                                                                                                                                                                                                       |
| `Disco.Server.Metadata.Publishing.HttpChannel`              | -            | `Disco.Server.Publishing`            | -             | 经由 HTTP 通道进行元数据推送。<br/>Metadata is pushed via **HTTP**.                                                                                                                                                                                                                                                               |
| `Disco.Client.Metadata.Subscription.ASPNET`                 | -            | `Disco.Client.Subscription`          | -             | 适用于传统的 <mark>ASP.NET</mark> 的 `HttpHandler` 方式元数据订阅。<br/>Metadata subscription in the `HttpHandler` mode for traditional <mark>ASP.NET</mark>.                                                                                                                                                                        |
| `Disco.Server.Metadata.Publishing.Zookeeper`                | -            | `Disco.Server.Publishing`            | -             | 经由 [Apache Zookeeper](http://zookeeper.apache.org/) 推送元数据。<br/>Metadata is pushed via [Apache Zookeeper](http://zookeeper.apache.org/).                                                                                                                                                                               |
| `Disco.Client.Metadata.Subscription.Zookeeper.Abstractions` | -            | `Disco.Client.Subscription`          | -             | 经由 [Apache Zookeeper](http://zookeeper.apache.org/) 订阅元数据抽象。<br/>Subscribe to metadata abstractions via [Apache Zookeeper](http://zookeeper.apache.org/).                                                                                                                                                             |
| `Disco.Client.Metadata.Subscription.ZookeeperNet`           | -            | `Disco.Client.Subscription`          | -             | 基于 [Zookeeper.Net](https://www.nuget.org/packages/ZooKeeper.Net) 的适用于 .NET Framework 4.0 的 [Zookeeper](http://zookeeper.apache.org/) 元数据订阅。<br/>[Zookeeper](http://zookeeper.apache.org/) metadata subscription for .NET Framework 4.0 developed using [Zookeeper.Net](https://www.nuget.org/packages/ZooKeeper.Net). |
| `Disco.Client.Metadata.Subscription.ZookeeperNetEx`         | -            | Disco.Client.Subscription`           | -             | 基于 [ZookeeperNetEx](https://www.nuget.org/packages/ZooKeeperNetEx) 的 [Zookeeper](http://zookeeper.apache.org/) 元数据订阅。<br/>[Zookeeper](http://zookeeper.apache.org/) metadata subscription developed using [ZookeeperNetEx](https://www.nuget.org/packages/ZooKeeperNetEx).                                            |