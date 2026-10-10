namespace Nur.Store2026.Access.Inventory.Permissions;

public class InventoryPermission
{
    public const string TransactionCreate = "inventory.transaction:create";
    public const string TransactionApprove = "inventory.transaction:approve";
    public const string TransactionReject = "inventory.transaction:reject";

    /// <summary>Hand the goods of a paid sale over to the customer at the warehouse.</summary>
    public const string TransactionDeliver = "inventory.transaction:deliver";

    /// <summary>Query transactions, items and their movements (kardex).</summary>
    public const string TransactionRead = "inventory.transaction:read";

    public static readonly IEnumerable<string> PermissionsList =
        [
            TransactionCreate,
            TransactionApprove,
            TransactionReject,
            TransactionDeliver,
            TransactionRead
        ];
}
