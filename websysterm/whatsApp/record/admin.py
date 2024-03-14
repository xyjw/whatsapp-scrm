from django.contrib import admin
from .models import Customers, Records, Labels
from django import forms


def make_status(modeladmin, request, queryset):
    queryset.update(status=0, interval=0)
make_status.short_description = '即时发送'

def make_regular_1d(modeladmin, request, queryset):
    queryset.update(interval=24, status=0)
make_regular_1d.short_description = '定时每隔1天'

def make_regular_3d(modeladmin, request, queryset):
    queryset.update(interval=72, status=0)
make_regular_3d.short_description = '定时每隔3天'

def make_regular_5d(modeladmin, request, queryset):
    queryset.update(interval=120, status=0)
make_regular_5d.short_description = '定时每隔5天'

def cancel_regular(modeladmin, request, queryset):
    queryset.update(interval=0, status=1)
cancel_regular.short_description = '取消群发'

@admin.register(Customers)
class CustomersAdmin(admin.ModelAdmin):
    list_display = [x for x in Customers._meta._forward_fields_map.keys()]
    search_fields = ['id', 'phone', 'customername', 'labels1', 'labels2', 'labels3', 'account', 'team']
    list_filter = ['status', 'team', 'account', 'labels1', 'labels2', 'labels3', 'labels4', 'labels5']
    readonly_fields = ['team']
    actions = [make_status, make_regular_1d, make_regular_3d, make_regular_5d, cancel_regular]
    date_hierarchy  = 'updated'

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
            kwargs['widget'] = forms.widgets.Textarea(
                attrs={'class': 'vLargeTextField'})
        return super().formfield_for_dbfield(db_field, request, **kwargs)

    def save_model(self, request, obj, form, change):
        if not obj.team:
            obj.team = request.user.first_name
        if not obj.account:
            obj.account = request.user.username
        super().save_model(request, obj, form, change)


@admin.register(Records)
class RecordsAdmin(admin.ModelAdmin):
    list_display = [x for x in Records._meta._forward_fields_map.keys()]
    search_fields = ['id', 'account', 'team']
    list_filter = ['team']
    date_hierarchy = 'created'
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
            kwargs['widget'] = forms.widgets.Textarea(
                attrs={'class': 'vLargeTextField'})
        return super().formfield_for_dbfield(db_field, request, **kwargs)

    def save_model(self, request, obj, form, change):
        obj.team = request.user.first_name
        obj.account = request.user.username
        super().save_model(request, obj, form, change)


@admin.register(Labels)
class LabelsAdmin(admin.ModelAdmin):
    list_display = [x for x in Labels._meta._forward_fields_map.keys()]
    search_fields = ['id', 'account', 'team']
    list_filter = ['team', 'level']
    date_hierarchy = 'created'
    readonly_fields = ('team', 'account')

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
            kwargs['widget'] = forms.widgets.Textarea(
                attrs={'class': 'vLargeTextField'})
        return super().formfield_for_dbfield(db_field, request, **kwargs)

    def save_model(self, request, obj, form, change):
        obj.team = request.user.first_name
        obj.account = request.user.username
        if request.user.last_name == '成员':
            obj.level = 2
        super().save_model(request, obj, form, change)