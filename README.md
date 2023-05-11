# AbpvnextOdataDemo
[中文文档](https://github.com/circler3/AbpvnextOdataDemo/blob/main/README.CN.md)
This project illustrates a simple approach towards ABP VNEXT working with ODATA. I think it is still a side-by-side implementation.

## Introduction
ABP VNEXT project does not provide a nuget package supporting OData. You should setup everything by yourself. Base ABP VNEXT project is the tutorial project(generated by abp cli) in [abp.io](https://abp.io)

ABP VNEXT uses auto-generated WebAPI controller mechanism. Hense I disable the `RemoteService` and write a custom controller to configure OData and route it manually.

## Usage
Set `TodoApp.HttpApi.Api.Host` as starting project and run.

GET `/api/app/Todo` to start an OData Query. e.g. `/api/app/Todo?$count=true`.
Visit `/api/app/$metadata#Todo` to get edm schema of the DTO.

## Disclaimer
This project is just a demo. It is not well designed in OData part. **Never** use it in production. 

## Related
I will write posts on this approach.

There are several [posts(Chinese)](https://www.cnblogs.com/podolski/collections/961) about OData which might be helpful for leveraging OData.
