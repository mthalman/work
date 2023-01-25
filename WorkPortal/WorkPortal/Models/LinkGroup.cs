namespace WorkPortal.Models;

public record LinkGroup(string Name, IEnumerable<Link> Links) : ContentItem(Name);
