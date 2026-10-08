using Nur.Store2026.Access.Catalog.Permissions;
using Nur.Store2026.Access.Identity.Permissions;
using Nur.Store2026.Access.Inventory.Permissions;
using Nur.Store2026.Access.Orders.Permissions;
using Nur.Store2026.Access.Payments.Permissions;

namespace Nur.Store2026.Access;

public class Permission
{

    public static readonly IEnumerable<string> PermissionsList = [
            .. CatalogPermission.PermissionsList,
            .. InventoryPermission.PermissionsList,
            .. OrdersPermission.PermissionsList,
            .. PaymentsPermission.PermissionsList,
            .. IdentityPermission.PermissionsList
        ];

}
