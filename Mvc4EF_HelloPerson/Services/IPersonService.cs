using System.Collections.Generic;
using Mvc4EF_HelloPerson.Models;

namespace Mvc4EF_HelloPerson.Services
{
    public interface IPersonService
    {
        void AddAuthor(Person author);
        void UpdateAuthor(Person author);
        void RemoveAuthor(int authorId);
        IEnumerable<Person> GetAllAuthors();
        Person GetAuthorById(int authorId);
    }
}