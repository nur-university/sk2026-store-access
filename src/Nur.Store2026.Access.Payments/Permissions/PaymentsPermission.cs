namespace Nur.Store2026.Access.Payments.Permissions;

public class PaymentsPermission
{
    /// <summary>See the cashier's queue, the charge orders and their invoices.</summary>
    public const string PaymentRead = "payments.payment:read";

    /// <summary>Collect a charge order (cash, bank transfer or card on the POS terminal) and issue the invoice (cashier).</summary>
    public const string PaymentCollect = "payments.payment:collect";

    public static readonly IEnumerable<string> PermissionsList =
        [
            PaymentRead,
            PaymentCollect
        ];
}
