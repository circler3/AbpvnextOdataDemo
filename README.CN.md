# AbpvnextOdataDemo
项目演示了一种简单的 ABP VNEXT 与 ODATA 同时工作的方法。我认为它仍然是一个并行实现。

## 介绍
由于ABP VNEXT 项目不提供支持 OData 的 NuGet 包，你需要自己设置所有内容（配置、EDM等）。本项目基于 ABP VNEXT [abp.io](https://abp.io) 中教程项目（由 abp cli 生成）。

ABP VNEXT 使用自动生成的 WebAPI 控制器机制，因此我禁用了“RemoteService”，编写了一个自定义控制器来手动配置 OData 并配置它由OData路由。

## 用法
将 `TodoApp.HttpApi.Api.Host` 设置为起始项目并运行。

通过 GET `/api/app/Todo` 启动 OData 查询。例如 `/api/app/Todo?$count=true`。
访问 `/api/app/$metadata#Todo` 获取 DTO 的 edm 模型。

## 免责声明
该项目仅为演示项目。在 OData 实现部分缺乏慎重设计。**切勿**在生产中使用。

## 相关内容
我将基于这个实现撰写博文，还请关注。

现在已经有几篇[关于OData的文章](https://www.cnblogs.com/podolski/collections/961)，这些文章可能对学习使用OData有所帮助。