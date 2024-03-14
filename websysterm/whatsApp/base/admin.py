from django.contrib import admin
from django.contrib.auth.models import User, Group
from .models import Accounts, ActionConfig
from django import forms

admin.site.site_title = 'WhatsApp管理平台'
admin.site.site_header = 'WhatsApp管理平台'
admin.sites.index_title = 'WhatsApp管理平台'


@admin.register(Accounts)
class AccountsAdmin(admin.ModelAdmin):
    list_display = [x for x in Accounts._meta._forward_fields_map.keys()]
    search_fields = ['id', 'account', 'team']
    list_filter = ['account', 'team']
    readonly_fields = ('team',)

    def get_queryset(self, request):
        qs = super().get_queryset(request)
        if request.user.is_superuser:
            return qs
        else:
            if request.user.last_name == '成员':
                return qs.filter(team=request.user.first_name, account=request.user.username)
            else:
                return qs.filter(team=request.user.first_name)

    def formfield_for_dbfield(self, db_field, request, **kwargs):
        if db_field.name == 'remark':
            kwargs['widget'] = forms.widgets.Textarea(attrs={'class': 'vLargeTextField'})
        return super().formfield_for_dbfield(db_field, request, **kwargs)

    def save_model(self, request, obj, form, change):
        obj.team = request.user.first_name
        super().save_model(request, obj, form, change)
        d = dict(username=obj.account, password=obj.password, is_staff=1,
                 is_active=1, first_name=request.user.first_name, last_name='成员')
        user = User.objects.filter(username=obj.account).first()
        if user:
            user.set_password(obj.password)
            user.save()
        else:
            user = User.objects.create_user(**d)
            user.save()
            group = Group.objects.get(id=2)
            user.groups.add(group)

    def delete_model(self, request, obj):
        super().delete_model(request, obj)
        User.objects.filter(username=obj.account).delete()

    def delete_queryset(self, request, queryset):
        username = [obj.account for obj in queryset]
        super().delete_queryset(request, queryset)
        User.objects.filter(username__in=username).delete()


@admin.register(ActionConfig)
class ActionConfigAdmin(admin.ModelAdmin):
    list_display = [x for x in ActionConfig._meta._forward_fields_map.keys()]
    search_fields = ['id', 'action']
    list_filter = ['status']
