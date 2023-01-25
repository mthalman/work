namespace WorkPortal.Models;

public record RepoGroup(IEnumerable<Repo> Repos) : ContentItem("Repos");
