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

**依赖模块（已加载顺序排序）**
Loaded ABP modules:
- Volo.Abp.Castle.AbpCastleCoreModule
- Volo.Abp.Autofac.AbpAutofacModule
- Volo.Abp.Uow.AbpUnitOfWorkModule
- Volo.Abp.Data.AbpDataModule
- Volo.Abp.Timing.AbpTimingModule
- Volo.Abp.Json.AbpJsonModule
- Volo.Abp.Security.AbpSecurityModule
- Volo.Abp.Threading.AbpThreadingModule
- Volo.Abp.MultiTenancy.AbpMultiTenancyModule
- Volo.Abp.Auditing.AbpAuditingModule
- Volo.Abp.VirtualFileSystem.AbpVirtualFileSystemModule
- Volo.Abp.Http.AbpHttpAbstractionsModule
- Volo.Abp.Http.AbpHttpModule
- Volo.Abp.Localization.AbpLocalizationAbstractionsModule
- Volo.Abp.Authorization.AbpAuthorizationModule
- Volo.Abp.EventBus.AbpEventBusModule
- Volo.Abp.Guids.AbpGuidsModule
- Volo.Abp.ObjectMapping.AbpObjectMappingModule
- Volo.Abp.Domain.AbpDddDomainModule
- Volo.Abp.Settings.AbpSettingsModule
- Volo.Abp.Localization.AbpLocalizationModule
- Volo.Abp.UI.AbpUiModule
- Volo.Abp.Validation.AbpValidationModule
- Volo.Abp.AspNetCore.AbpAspNetCoreModule
- Volo.Abp.ApiVersioning.AbpApiVersioningAbstractionsModule
- Volo.Abp.Features.AbpFeaturesModule
- Volo.Abp.Application.AbpDddApplicationModule
- Volo.Abp.AspNetCore.Mvc.AbpAspNetCoreMvcContractsModule
- Volo.Abp.AspNetCore.Mvc.AbpAspNetCoreMvcModule
- AbpWebAppHost.AbpWebAppHostModule

## 02.AbpMvcDynamaicApi-vs-AbpMvcApi

**测试目的**
1. 比较Abp Mvc dynamic api 与 Controller Api 执行性能

**依赖模块（已加载顺序排序）**

Loaded ABP modules:
 - Volo.Abp.Castle.AbpCastleCoreModule
 - Volo.Abp.Autofac.AbpAutofacModule
 - Volo.Abp.Uow.AbpUnitOfWorkModule
 - Volo.Abp.Data.AbpDataModule
 - Volo.Abp.Timing.AbpTimingModule
 - Volo.Abp.Json.AbpJsonModule
 - Volo.Abp.Security.AbpSecurityModule
 - Volo.Abp.Threading.AbpThreadingModule
 - Volo.Abp.MultiTenancy.AbpMultiTenancyModule
 - Volo.Abp.Auditing.AbpAuditingModule
 - Volo.Abp.VirtualFileSystem.AbpVirtualFileSystemModule
 - Volo.Abp.Http.AbpHttpAbstractionsModule
 - Volo.Abp.Http.AbpHttpModule
 - Volo.Abp.Localization.AbpLocalizationAbstractionsModule
 - Volo.Abp.Authorization.AbpAuthorizationModule
 - Volo.Abp.EventBus.AbpEventBusModule
 - Volo.Abp.Guids.AbpGuidsModule
 - Volo.Abp.ObjectMapping.AbpObjectMappingModule
 - Volo.Abp.Domain.AbpDddDomainModule
 - Volo.Abp.Settings.AbpSettingsModule
 - Volo.Abp.Localization.AbpLocalizationModule
 - Volo.Abp.UI.AbpUiModule
 - Volo.Abp.Validation.AbpValidationModule
 - Volo.Abp.AspNetCore.AbpAspNetCoreModule
 - Volo.Abp.ApiVersioning.AbpApiVersioningAbstractionsModule
 - Volo.Abp.Features.AbpFeaturesModule
 - Volo.Abp.Application.AbpDddApplicationModule
 - Volo.Abp.AspNetCore.Mvc.AbpAspNetCoreMvcContractsModule
 - Volo.Abp.AspNetCore.Mvc.AbpAspNetCoreMvcModule
 - Boss.AbpWebApi.Application.Contracts.AbpWebApiApplicationContractsModule
 - Boss.AbpWebApi.Application.AbpWebApiApplicationModule
 - Boss.AbpWebApi.Host.AbpWebApiHostModule

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
1. 移除多租户模块。
2. 移除审计日志Db持久化组件，并关闭默认审计。或者取消AbpAuditingMiddleware
3. 关闭Production下，swagger加载
4. 取消Volo.Abp.AspNetCore.Tracing middleware
5. 取消Https支持，取消HttpsRedirectionMiddleware

**依赖模块（已加载顺序排序）**

Loaded ABP modules:
- Volo.Abp.VirtualFileSystem.AbpVirtualFileSystemModule
- Volo.Abp.Localization.AbpLocalizationAbstractionsModule
- Volo.Abp.Security.AbpSecurityModule
- Volo.Abp.Uow.AbpUnitOfWorkModule
- Volo.Abp.Data.AbpDataModule
- Volo.Abp.MultiTenancy.AbpMultiTenancyModule
- Volo.Abp.Settings.AbpSettingsModule
- Volo.Abp.Localization.AbpLocalizationModule
- Boss.ClouldItems.ClouldItemsDomainSharedModule
- Boss.ClouldItems.ClouldItemsDomainModule
- Volo.Abp.Timing.AbpTimingModule
- Volo.Abp.Json.AbpJsonModule
- Volo.Abp.Threading.AbpThreadingModule
- Volo.Abp.Auditing.AbpAuditingModule
- Volo.Abp.EventBus.AbpEventBusModule
- Volo.Abp.Guids.AbpGuidsModule
- Volo.Abp.ObjectMapping.AbpObjectMappingModule
- Volo.Abp.Domain.AbpDddDomainModule
- Volo.Abp.Validation.AbpValidationModule
- Volo.Abp.Authorization.AbpAuthorizationModule
- Volo.Abp.Http.AbpHttpAbstractionsModule
- Volo.Abp.Features.AbpFeaturesModule
- Volo.Abp.Application.AbpDddApplicationModule
- Boss.ClouldItems.ClouldItemsApplicationContractsModule
- Volo.Abp.AutoMapper.AbpAutoMapperModule
- Boss.ClouldItems.ClouldItemsApplicationModule
- Volo.Abp.EntityFrameworkCore.AbpEntityFrameworkCoreModule
- Boss.ClouldItems.EntityFrameworkCore.ClouldItemsEntityFrameworkCoreModule
- Volo.Abp.Http.AbpHttpModule
- Volo.Abp.UI.AbpUiModule
- Volo.Abp.AspNetCore.AbpAspNetCoreModule
- Volo.Abp.ApiVersioning.AbpApiVersioningAbstractionsModule
- Volo.Abp.AspNetCore.Mvc.AbpAspNetCoreMvcContractsModule
- Volo.Abp.AspNetCore.Mvc.AbpAspNetCoreMvcModule
- Boss.ClouldItems.ClouldItemsHttpApiModule
- Volo.Abp.Castle.AbpCastleCoreModule
- Volo.Abp.Autofac.AbpAutofacModule
- Volo.Abp.EntityFrameworkCore.SqlServer.AbpEntityFrameworkCoreSqlServerModule
- Volo.Abp.PermissionManagement.AbpPermissionManagementDomainSharedModule
- Volo.Abp.Serialization.AbpSerializationModule
- Volo.Abp.Caching.AbpCachingModule
- Volo.Abp.PermissionManagement.AbpPermissionManagementDomainModule
- Volo.Abp.PermissionManagement.EntityFrameworkCore.AbpPermissionManagementEntityFrameworkCoreModule
- Volo.Abp.SettingManagement.AbpSettingManagementDomainSharedModule
- Volo.Abp.SettingManagement.AbpSettingManagementDomainModule
- Volo.Abp.SettingManagement.EntityFrameworkCore.AbpSettingManagementEntityFrameworkCoreModule
- Boss.ClouldItems.ClouldItemsHttpApiHostModule