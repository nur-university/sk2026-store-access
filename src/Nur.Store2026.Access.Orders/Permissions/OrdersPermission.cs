namespace Nur.Store2026.Access.Orders.Permissions;

public class OrdersPermission
{
    /// <summary>Create sales notes (sales advisor).</summary>
    public const string OrderCreate = "orders.order:create";

    /// <summary>See the own sales notes.</summary>
    public const string OrderRead = "orders.order:read";

    /// <summary>Cancel the own unpaid sales notes.</summary>
    public const string OrderCancel = "orders.order:cancel";

    /// <summary>See and cancel the sales notes of every advisor, not only the own ones (supervisor).</summary>
    public const string OrderAdmin = "orders.order:admin";

    public static readonly IEnumerable<string> PermissionsList =
        [
            OrderCreate,
            OrderRead,
            OrderCancel,
            OrderAdmin
        ];
}
