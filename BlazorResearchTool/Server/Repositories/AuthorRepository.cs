using BlazorResearchTool.Server.Dto;
using BlazorResearchTool.Server.Interfaces;
using BlazorResearchTool.Shared;

namespace BlazorResearchTool.Server.Repositories;

public class AuthorRepository : IAuthorRepository
{
    public ICollection<Author> GetAuthors()
    {
        throw new NotImplementedException();
    }

    public Author GetById(Guid authorId)
    {
        throw new NotImplementedException();
    }

    public Author GetAuthorTrimToUpper(AuthorDto authorCreate)
    {
        throw new NotImplementedException();
    }

    public ICollection<Reading> GetReadingByAuthor(Guid authorId)
    {
        throw new NotImplementedException();
    }

    public bool DoesExist(Guid authorId)
    {
        throw new NotImplementedException();
    }

    public bool CreateAuthor(Author author)
    {
        throw new NotImplementedException();
    }

    public bool UpdateAuthor(Author author)
    {
        throw new NotImplementedException();
    }

    public bool Save()
    {
        throw new NotImplementedException();
    }
}