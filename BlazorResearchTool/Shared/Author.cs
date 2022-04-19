namespace BlazorResearchTool.Shared;

public class Author
{
    public Guid Id { get; set; }
    public string nameGiven { get; set; }
    public string nameFamily { get; set; }
    public ICollection<Affiliation> Affiliations { get; set; }
    public ICollection<Article> Articles { set; get; }
    public ICollection<Blog> Blogs { get; set; }
    public ICollection<Book> Books { get; set; }
    public ICollection<Link> Links { get; set; }
    public ICollection<OpinionPiece> OpinionPieces { get; set; }
}