# AbpvnextOdataDemo
��Ŀ��ʾ��һ�ּ򵥵� ABP VNEXT �� ODATA ͬʱ�����ķ���������Ϊ����Ȼ��һ������ʵ�֡�

## ����
����ABP VNEXT ��Ŀ���ṩ֧�� OData �� NuGet ��������Ҫ�Լ������������ݣ����á�EDM�ȣ�������Ŀ���� ABP VNEXT [abp.io](https://abp.io) �н̳���Ŀ���� abp cli ���ɣ���

ABP VNEXT ʹ���Զ����ɵ� WebAPI ���������ƣ�����ҽ����ˡ�RemoteService������д��һ���Զ�����������ֶ����� OData ����������OData·�ɡ�

## �÷�
�� `TodoApp.HttpApi.Api.Host` ����Ϊ��ʼ��Ŀ�����С�

ͨ�� GET `/api/app/Todo` ���� OData ��ѯ������ `/api/app/Todo?$count=true`��
���� `/api/app/$metadata#Todo` ��ȡ DTO �� edm ģ�͡�

## ��������
����Ŀ��Ϊ��ʾ��Ŀ���� OData ʵ�ֲ���ȱ��������ơ�**����**��������ʹ�á�

## �������
�ҽ��������ʵ��׫д���ģ������ע��

�����Ѿ��м�ƪ[����OData������](https://www.cnblogs.com/podolski/collections/961)����Щ���¿��ܶ�ѧϰʹ��OData����������