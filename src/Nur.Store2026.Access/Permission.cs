using Nur.Store2026.Access.Catalog.Permissions;
using Nur.Store2026.Access.Identity.Permissions;
using Nur.Store2026.Access.Inventory.Permissions;

namespace Nur.Store2026.Access;

public class Permission
{

    public static readonly IEnumerable<string> PermissionsList = [
            .. CatalogPermission.PermissionsList,
            .. InventoryPermission.PermissionsList,
            .. IdentityPermission.PermissionsList
        ];

}
