from django.db import models

STATUS = (
    (0, 0),
    (1, 1)
)


class Accounts(models.Model):
    id = models.AutoField(primary_key=True)
    account = models.CharField('软件账号', max_length=255, unique=True)
    password = models.CharField('软件密码', max_length=255)
    team = models.CharField('部门', max_length=255, null=True, blank=True)
    remark = models.TextField('备注', null=True, blank=True)
    updated = models.DateField('更新时间', auto_now=True)
    created = models.DateField('创建时间', auto_now_add=True)

    def __str__(self):
        return self.account

    class Meta:
        db_table = "account"
        verbose_name = '系统账号管理'
        verbose_name_plural = '系统账号管理'


class ActionConfig(models.Model):
    id = models.AutoField(primary_key=True)
    action = models.TextField('自动化操作配置')
    status = models.IntegerField('状态', choices=STATUS, default=1)
    remark = models.TextField('备注', null=True, blank=True)

    def __str__(self):
        return self.action

    class Meta:
        db_table = "action"
        verbose_name = '自动化操作配置'
        verbose_name_plural = '自动化操作配置'
