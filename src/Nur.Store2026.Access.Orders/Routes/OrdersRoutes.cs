using Nur.Store2026.Access.Contracts;
using Nur.Store2026.Access.Orders.Permissions;

namespace Nur.Store2026.Access.Orders.Routes;

public class OrdersRoutes
{
    public static readonly IEnumerable<ScopeAccessRule> Routes = [
        new() { RouteTemplate = "/orders/health", HttpMethod = "GET", AllowAnonymous = true },
        new() { RouteTemplate = "/api/orders/order", HttpMethod = "POST", RequiredScope = OrdersPermission.OrderCreate },
        new() { RouteTemplate = "/api/orders/order", HttpMethod = "GET", RequiredScope = OrdersPermission.OrderRead },
        new() { RouteTemplate = "/api/orders/order/draft", HttpMethod = "POST", RequiredScope = OrdersPermission.OrderCreate },
        new() { RouteTemplate = "/api/orders/order/{id}", HttpMethod = "GET", RequiredScope = OrdersPermission.OrderRead },
        new() { RouteTemplate = "/api/orders/order/{id}", HttpMethod = "DELETE", RequiredScope = OrdersPermission.OrderCreate },
        new() { RouteTemplate = "/api/orders/order/{id}/items", HttpMethod = "PUT", RequiredScope = OrdersPermission.OrderCreate },
        new() { RouteTemplate = "/api/orders/order/{id}/customer", HttpMethod = "PUT", RequiredScope = OrdersPermission.OrderCreate },
        new() { RouteTemplate = "/api/orders/order/{id}/confirm", HttpMethod = "POST", RequiredScope = OrdersPermission.OrderCreate },
        new() { RouteTemplate = "/api/orders/order/{id}/annul", HttpMethod = "POST", RequiredScope = OrdersPermission.OrderOverride },
        new() { RouteTemplate = "/api/orders/order/{id}/cancel", HttpMethod = "POST", RequiredScope = OrdersPermission.OrderCancel }
        ];
}
