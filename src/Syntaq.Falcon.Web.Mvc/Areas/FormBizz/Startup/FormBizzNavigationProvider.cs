using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using FormBizz.Authorization;

namespace FormBizz.Web.Areas.FormBizz.Startup
{
    public class FormBizzNavigationProvider : NavigationProvider
    {
        public const string MenuName = "App";

        public override void SetNavigation(INavigationProviderContext context)
        {
            var menu = context.Manager.Menus[MenuName] = new MenuDefinition(MenuName, new FixedLocalizableString("Main Menu"));

            menu
                .AddItem(new MenuItemDefinition(
                        FormBizzPageNames.Host.Dashboard,
                        L("Dashboard"),
                        url: "FormBizz/HostDashboard",
                        icon: "flaticon-line-graph",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Dashboard)
                    )
                ).AddItem(new MenuItemDefinition(
                        FormBizzPageNames.Host.Tenants,
                        L("Tenants"),
                        url: "FormBizz/Tenants",
                        icon: "flaticon-list-3",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenants)
                    )
                ).AddItem(new MenuItemDefinition(
                        FormBizzPageNames.Host.Editions,
                        L("Editions"),
                        url: "FormBizz/Editions",
                        icon: "flaticon-app",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Editions)
                    )
                ).AddItem(new MenuItemDefinition(
                        FormBizzPageNames.Tenant.Dashboard,
                        L("Dashboard"),
                        url: "FormBizz/TenantDashboard",
                        icon: "flaticon-line-graph",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenant_Dashboard)
                    )
                ).AddItem(new MenuItemDefinition(
                        FormBizzPageNames.Common.Administration,
                        L("Administration"),
                        icon: "flaticon-interface-8"
                    ).AddItem(new MenuItemDefinition(
                            FormBizzPageNames.Common.OrganizationUnits,
                            L("OrganizationUnits"),
                            url: "FormBizz/OrganizationUnits",
                            icon: "flaticon-map",
                            permissionDependency: new SimplePermissionDependency(AppPermissions
                                .Pages_Administration_OrganizationUnits)
                        )
                    ).AddItem(new MenuItemDefinition(
                            FormBizzPageNames.Common.Roles,
                            L("Roles"),
                            url: "FormBizz/Roles",
                            icon: "flaticon-suitcase",
                            permissionDependency: new SimplePermissionDependency(AppPermissions
                                .Pages_Administration_Roles)
                        )
                    ).AddItem(new MenuItemDefinition(
                            FormBizzPageNames.Common.Users,
                            L("Users"),
                            url: "FormBizz/Users",
                            icon: "flaticon-users",
                            permissionDependency: new SimplePermissionDependency(AppPermissions
                                .Pages_Administration_Users)
                        )
                    ).AddItem(new MenuItemDefinition(
                            FormBizzPageNames.Common.Languages,
                            L("Languages"),
                            url: "FormBizz/Languages",
                            icon: "flaticon-tabs",
                            permissionDependency: new SimplePermissionDependency(AppPermissions
                                .Pages_Administration_Languages)
                        )
                    ).AddItem(new MenuItemDefinition(
                            FormBizzPageNames.Common.AuditLogs,
                            L("AuditLogs"),
                            url: "FormBizz/AuditLogs",
                            icon: "flaticon-folder-1",
                            permissionDependency: new SimplePermissionDependency(AppPermissions
                                .Pages_Administration_AuditLogs)
                        )
                    ).AddItem(new MenuItemDefinition(
                            FormBizzPageNames.Host.Maintenance,
                            L("Maintenance"),
                            url: "FormBizz/Maintenance",
                            icon: "flaticon-lock",
                            permissionDependency: new SimplePermissionDependency(AppPermissions
                                .Pages_Administration_Host_Maintenance)
                        )
                    ).AddItem(new MenuItemDefinition(
                            FormBizzPageNames.Tenant.SubscriptionManagement,
                            L("Subscription"),
                            url: "FormBizz/SubscriptionManagement",
                            icon: "flaticon-refresh",
                            permissionDependency: new SimplePermissionDependency(AppPermissions
                                .Pages_Administration_Tenant_SubscriptionManagement)
                        )
                    ).AddItem(new MenuItemDefinition(
                            FormBizzPageNames.Common.UiCustomization,
                            L("VisualSettings"),
                            url: "FormBizz/UiCustomization",
                            icon: "flaticon-medical",
                            permissionDependency: new SimplePermissionDependency(AppPermissions
                                .Pages_Administration_UiCustomization)
                        )
                    ).AddItem(new MenuItemDefinition(
                            FormBizzPageNames.Common.WebhookSubscriptions,
                            L("WebhookSubscriptions"),
                            url: "FormBizz/WebhookSubscription",
                            icon: "flaticon2-world",
                            permissionDependency: new SimplePermissionDependency(AppPermissions
                                .Pages_Administration_WebhookSubscription)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            FormBizzPageNames.Common.DynamicProperties,
                            L("DynamicProperties"),
                            url: "FormBizz/DynamicProperty",
                            icon: "flaticon-interface-8",
                            permissionDependency: new SimplePermissionDependency(AppPermissions
                                .Pages_Administration_DynamicProperties)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            FormBizzPageNames.Host.Settings,
                            L("Settings"),
                            url: "FormBizz/HostSettings",
                            icon: "flaticon-settings",
                            permissionDependency: new SimplePermissionDependency(AppPermissions
                                .Pages_Administration_Host_Settings)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            FormBizzPageNames.Tenant.Settings,
                            L("Settings"),
                            url: "FormBizz/Settings",
                            icon: "flaticon-settings",
                            permissionDependency: new SimplePermissionDependency(AppPermissions
                                .Pages_Administration_Tenant_Settings)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            FormBizzPageNames.Common.Notifications,
                            L("Notifications"),
                            icon: "flaticon-alarm"
                        ).AddItem(new MenuItemDefinition(
                                FormBizzPageNames.Common.Notifications_Inbox,
                                L("Inbox"),
                                url: "FormBizz/Notifications",
                                icon: "flaticon-mail-1"
                            )
                        )
                        .AddItem(new MenuItemDefinition(
                                FormBizzPageNames.Common.Notifications_MassNotifications,
                                L("MassNotifications"),
                                url: "FormBizz/Notifications/MassNotifications",
                                icon: "flaticon-paper-plane",
                                permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_MassNotification)
                            )
                        )
                    )
                ).AddItem(new MenuItemDefinition(
                        FormBizzPageNames.Common.DemoUiComponents, 
                        L("DemoUiComponents"),
                        url: "FormBizz/DemoUiComponents",
                        icon: "flaticon-shapes",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_DemoUiComponents)
                    )
                )
            // Added Phone Book menu item   
           //.AddItem(new MenuItemDefinition(
            //FormBizzPageNames.Tenant.PhoneBook,
            //L("PhoneBook"),
           // url: "tenant.phonebook",
           // icon: "flaticon-book",
           // permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenant_PhoneBook)
           // )

           .AddItem(new MenuItemDefinition(
                        FormBizzPageNames.Common.PhoneBook,
                        L("PhoneBook"),
                        url: "FormBizz/phonebook",
                        icon: "flaticon-line-graph",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_PhoneBook)
                    )
        );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, FormBizzConsts.LocalizationSourceName);
        }
    }
}
