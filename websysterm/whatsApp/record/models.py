from django.db import models

STATUS = (
    (0, '待发送'),
    (1, '已发送')
)
LEVEL = (
    (1, '一级'),
    (2, '二级')
)

class Customers(models.Model):
    id = models.AutoField(primary_key=True)
    phone = models.CharField('客户电话', max_length=255)
    customername = models.CharField('客户名称', max_length=255, null=True, blank=True)
    labels1 = models.CharField('标签1', max_length=255, default='', null=True, blank=True)
    labels2 = models.CharField('标签2', max_length=255, default='', null=True, blank=True)
    labels3 = models.CharField('标签3', max_length=255, default='', null=True, blank=True)
    labels4 = models.CharField('标签4', max_length=255, default='', null=True, blank=True)
    labels5 = models.CharField('标签5', max_length=255, default='', null=True, blank=True)
    account = models.CharField('软件账号', max_length=255, null=True, blank=True)
    team = models.CharField('部门', max_length=255, null=True, blank=True)
    interval = models.IntegerField('定时发送间隔（小时）', default=0)
    status = models.IntegerField('状态', choices=STATUS, default=1)
    remark = models.TextField('备注', null=True, blank=True)
    updated = models.DateTimeField('更新时间', auto_now=True)
    created = models.DateField('创建时间', auto_now_add=True)

    def __str__(self):
        return self.phone

    class Meta:
        db_table = "customer"
        verbose_name = '客户管理'
        verbose_name_plural = '客户管理'


class Records(models.Model):
    id = models.AutoField(primary_key=True)
    message = models.IntegerField('群发信息数', default=0)
    account = models.CharField('账号', max_length=255, null=True, blank=True)
    team = models.CharField('部门', max_length=255, null=True, blank=True)
    remark = models.TextField('备注', null=True, blank=True)
    updated = models.DateField('更新时间', auto_now=True)
    created = models.DateField('创建时间', auto_now_add=True)

    def __str__(self):
        return str(self.id)

    class Meta:
        db_table = "record"
        verbose_name = '数据记录'
        verbose_name_plural = '数据记录'



class Labels(models.Model):
    id = models.AutoField(primary_key=True)
    content = models.TextField('标签', default='')
    account = models.CharField('账号', max_length=255, null=True, blank=True)
    team = models.CharField('部门', max_length=255, null=True, blank=True)
    level = models.IntegerField('类别', default=1, choices=LEVEL)
    remark = models.TextField('备注', null=True, blank=True)
    updated = models.DateField('更新时间', auto_now=True)
    created = models.DateField('创建时间', auto_now_add=True)

    def __str__(self):
        return str(self.id)

    class Meta:
        db_table = "labels"
        verbose_name = '标签管理'
        verbose_name_plural = '标签管理'