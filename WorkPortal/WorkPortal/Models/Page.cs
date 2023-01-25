namespace WorkPortal.Models;

public record Page(string Name, IEnumerable<PageColumn> Columns)
{
    public string Id => Name.ToLower().Replace(" ", "");
};
