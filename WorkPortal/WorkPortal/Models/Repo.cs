namespace WorkPortal.Models;

public record Repo(string Name, IEnumerable<Link> RepoLinks, IEnumerable<Link> PipelineLinks);
