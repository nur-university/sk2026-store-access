using Nur.Store2026.Access.Contracts;
using Nur.Store2026.Access.Payments.Permissions;

namespace Nur.Store2026.Access.Payments.Routes;

public class PaymentsRoutes
{
    public static readonly IEnumerable<ScopeAccessRule> Routes = [
        new() { RouteTemplate = "/payments/health", HttpMethod = "GET", AllowAnonymous = true },
        new() { RouteTemplate = "/api/payments/payment/pending", HttpMethod = "GET", RequiredScope = PaymentsPermission.PaymentRead },
        new() { RouteTemplate = "/api/payments/payment/orders/{orderId}", HttpMethod = "GET", RequiredScope = PaymentsPermission.PaymentRead },
        new() { RouteTemplate = "/api/payments/payment/orders/{orderId}/invoice", HttpMethod = "GET", RequiredScope = PaymentsPermission.PaymentRead },
        new() { RouteTemplate = "/api/payments/payment/orders/{orderId}/collect", HttpMethod = "POST", RequiredScope = PaymentsPermission.PaymentCollect }
        ];
}
