# Abp Performance Testing Cases

Abp VNext v0.8.1 构建WebApi接口性能测试

## 01.AbpMvcPipeline-vs-AspNetMvcPipeline

**测试目的**
1. Abp VNext Mvc 管道封装后比 asp.net core 管道机制消耗。
2. 默认Json序列化消耗比较。

`AbpWebAppHost` 项目模板基于 asp.net core empty project template ，依赖以下两个基础组件

- Volo.Abp.AspNetCore.Mvc 
- Volo.Abp.Autofac

`AspNetCoreWebAppHost` 项目模板基于 asp.net core web api template, 无其他组件依赖


## 02.AbpMvcDynamaicApi-vs-AbpMvcApi

## 03.AbpMvcFullFeature-vs-AbpMvcHighPerformace

使用Volo.Abp.CLI 

```shell
PS D:\Architecture\Template\ProjectTemplate18> abp new Boss.OrderCenter -t mvc-module --no-ui -o JK724.OrderCenter
[13:27:34 INF] ABP CLI (https://abp.io)
[13:27:34 INF] Version 0.18.1 (Stable channel)
[13:27:38 INF] Creating a new project...
[13:27:38 INF] Project name: Boss.OrderCenter
[13:27:40 INF] Using cached template: mvc-module, version: 0.18.1
[13:27:41 INF] Check the documentation of this template: https://docs.abp.io/en/abp/latest/Startup-Templates/Mvc-Module
[13:27:44 INF] Successfully created the project 'Boss.OrderCenter'
[13:27:44 INF] The output folder is: 'D:\Architecture\Template\ProjectTemplate18\JK724.OrderCenter'
PS D:\Architecture\Template\ProjectTemplate18> abp new Boss.ClouldItems -t mvc-module --no-ui -o JK724.ClouldItems
[13:30:18 INF] ABP CLI (https://abp.io)
[13:30:18 INF] Version 0.18.1 (Stable channel)
[13:30:21 INF] Creating a new project...
[13:30:21 INF] Project name: Boss.ClouldItems
[13:30:23 INF] Using cached template: mvc-module, version: 0.18.1
[13:30:24 INF] Check the documentation of this template: https://docs.abp.io/en/abp/latest/Startup-Templates/Mvc-Module
[13:30:26 INF] Successfully created the project 'Boss.ClouldItems'
[13:30:26 INF] The output folder is: 'D:\Architecture\Template\ProjectTemplate18\JK724.ClouldItems'
PS D:\Architecture\Template\ProjectTemplate18>

```

Abp默认全特性MVC模板项目（AbpMvcFullFeature） - **Boss.OrderCenter**


Abp性能优化MVC模板项目（AbpMvcHighPerformace）- **Boss.ClouldItems**

**优化项**
1. 
