# 项目和功能 Projects & Features

![Disco](../assets/Avatar/Disco-48.png)

| 项目 PROJECT                         | 程序集 ASSEMBLY | 命名空间 NAMESPACE              | NuGet 包 NUPKG | 说明 NOTES                                                                                                                                                |
| ------------------------------------ | --------------- | ------------------------------- | -------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Disco.Common.MultilingualSupported` | -               | `Disco.Globalization.Resources` | -              | 提供了国际化多语言支持所需的资源文件。<br />Resource files required for internationalized multilingual support are provided.                              |
| `Disco.Common`                       | -               | `Disco`                         | -              | 此类库提供了 `Disco` 所需的通用功能。<br />Such library provides the common functionality that `Disco` needs.                                             |
| `Disco.Core.Abstractions`            | -               | `Disco`                         | -              | 此类库仅提供了 `IDiscoApp` 接口定义。<br />Only `IDiscoApp` interface definitions are provided.                                                           |
| `Disco.Core`                         | -               | `Disco.Core`                    | -              | 此类库仅提供了 `IDiscoApp` 的默认实现和扩展方法。<br />Only the default implementation and extension methods of 'IDiscoApp' are provided in this library. |
|`Disco.Core.DependencyInjection`|-|`Disco.DependencyInjection`|-|此类库提供了基于 `Microsoft.Extensions.DependencyInjection` 的依赖注入扩展。<br />This library provides a dependency injection extension based on `Microsoft.Extensions.DependencyInjection`.|
| `Disco.Core.DependencyInjection.Unity`|-|`Disco.DependencyInjection`|-|此类库提供了基于 `Unity` 的依赖注入扩展。<br />This library provides a dependency injection extension based on `Unity`. <br /> ⏳这个类库仅适用于 .NET Framework 4.5+ (*Only .NET Framework 4.5+*)|
| `Disco.Common.Logging.Abstractions`  | -               | `Disco.Diagnostics.Logging`     | -              | 此类库提供了：输出运行时诊断日志的抽象。<br />Such library provides abstractions for outputting runtime diagnostic logs.                                  |
