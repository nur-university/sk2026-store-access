using Nur.Store2026.Access.Catalog.Routes;
using Nur.Store2026.Access.Contracts;
using Nur.Store2026.Access.Identity.Routes;
using Nur.Store2026.Access.Inventory.Routes;

namespace Nur.Store2026.Access;

public class Routes
{
    public static readonly IEnumerable<ScopeAccessRule> RouteList = [
            .. CatalogRoutes.Routes,
            .. InventoryRoutes.Routes,
            .. IdentityRoutes.Routes
        ];

}
