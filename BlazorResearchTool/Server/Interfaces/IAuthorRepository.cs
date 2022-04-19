using BlazorResearchTool.Server.Dto;
using BlazorResearchTool.Shared;

namespace BlazorResearchTool.Server.Interfaces;

public interface IAuthorRepository
{
    ICollection<Author> GetAuthors();
    Author GetById(Guid authorId);
    Author GetAuthorTrimToUpper(AuthorDto authorCreate);
    ICollection<Reading> GetReadingByAuthor(Guid authorId);
    bool DoesExist(Guid authorId);
    bool CreateAuthor(Author author);
    bool UpdateAuthor(Author author);
    bool Save();
}