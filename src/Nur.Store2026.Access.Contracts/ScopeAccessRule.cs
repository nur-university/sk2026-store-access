namespace Nur.Store2026.Access.Contracts;

public class ScopeAccessRule
{
    public string RouteTemplate { get; set; } = default!; // e.g. "/catalog/products/{id}"
    public string HttpMethod { get; set; } = "GET";
    public string RequiredScope { get; set; } = default!;
    public bool AllowAnonymous { get; set; } = false;
}