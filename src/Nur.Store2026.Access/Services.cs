using Nur.Store2026.Access.Catalog;
using Nur.Store2026.Access.Identity;
using Nur.Store2026.Access.Inventory;

namespace Nur.Store2026.Access;

public class Services
{
    public static readonly IEnumerable<string> ServicesList = [
        CatalogService.ServiceName,
        IdentityService.ServiceName, 
        InventoryService.ServiceName,
    ];
}
