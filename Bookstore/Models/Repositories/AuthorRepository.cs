using System.Collections.Generic;
using System.Linq;

namespace Bookstore.Models.Repositories
{
    public class AuthorRepository : IBookstoreRepository<Author>
    {
        private IList<Author> authors;

        public AuthorRepository() => authors = new List<Author>()
            {
                new Author { Id = 1, FullName = "Mohammed" },
                new Author { Id = 2, FullName = "Ali" },
                new Author { Id = 3, FullName = "Osamah" },
            };

        public void Add(Author entity)
        {
            entity.Id = authors.Max(b => b.Id);
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);
            {
                authors.Remove(author);
            }
        }

        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(a => a.Id == id);
            return author ?? throw new InvalidOperationException("Author not found");
        }


        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newAuthor)
        {
            var author = Find(id);
            
            {
                author.FullName = newAuthor.FullName;
            }
        }
    }
}
