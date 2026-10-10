using Nur.Store2026.Access.Inventory.Permissions;
using Nur.Store2026.Access.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nur.Store2026.Access.Inventory.Routes;

public class InventoryRoutes
{        
    public static readonly IEnumerable<ScopeAccessRule> Routes = [
        new() { RouteTemplate = "/inventory/health", HttpMethod = "GET", AllowAnonymous = true },
        new() { RouteTemplate = "/api/inventory/transaction", HttpMethod = "POST", RequiredScope = InventoryPermission.TransactionCreate },
        new() { RouteTemplate = "/api/inventory/transaction/complete", HttpMethod = "POST", RequiredScope = InventoryPermission.TransactionApprove },
        new() { RouteTemplate = "/api/inventory/transaction/reject", HttpMethod = "POST", RequiredScope = InventoryPermission.TransactionReject },
        new() { RouteTemplate = "/api/inventory/transaction/orders/{orderId}/deliver", HttpMethod = "POST", RequiredScope = InventoryPermission.TransactionDeliver },
        new() { RouteTemplate = "/api/inventory/transaction/pending-exits", HttpMethod = "GET", RequiredScope = InventoryPermission.TransactionDeliver },
        new() { RouteTemplate = "/api/inventory/transaction/invoices/{invoiceNumber}", HttpMethod = "GET", RequiredScope = InventoryPermission.TransactionDeliver },
        new() { RouteTemplate = "/api/inventory/transaction/invoices/{invoiceNumber}/deliver", HttpMethod = "POST", RequiredScope = InventoryPermission.TransactionDeliver },
        new() { RouteTemplate = "/api/inventory/transaction", HttpMethod = "GET", RequiredScope = InventoryPermission.TransactionRead },
        new() { RouteTemplate = "/api/inventory/transaction/{id}", HttpMethod = "GET", RequiredScope = InventoryPermission.TransactionRead },
        new() { RouteTemplate = "/api/inventory/item", HttpMethod = "GET", RequiredScope = InventoryPermission.TransactionRead },
        new() { RouteTemplate = "/api/inventory/item/{id}", HttpMethod = "GET", RequiredScope = InventoryPermission.TransactionRead },
        new() { RouteTemplate = "/api/inventory/item/{id}/movements", HttpMethod = "GET", RequiredScope = InventoryPermission.TransactionRead }

        ];
}
