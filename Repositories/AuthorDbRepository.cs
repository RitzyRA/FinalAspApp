using FinalAspApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAspApp.Repositories
{
    public class AuthorDbRepository : IAuthorDbRepository
    {
        private AppDbContext _dbContext;
        public AuthorDbRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(string name, string surname)
        {
            _dbContext.Authors.Add(new Author() { Name = name, Surname = surname });
            _dbContext.SaveChanges();
        }

        public bool DeleteById(int? id)
        {
            var e = _dbContext.Authors.Find(id);
            _dbContext.Authors.Remove(e);
            return _dbContext.SaveChanges() == 1 ? true : false;
        }

        public IEnumerable<Author> GetAll()
        {
            return _dbContext.Authors.ToList();
        }

        public Author GetById(int id)
        {
            return _dbContext.Authors.Find(id);
        }

        public void Update(int updateableId, string updatedName, string updatedSurname)
        {
            var e = _dbContext.Authors.Find(updateableId);
            e.Name = updatedName;
            e.Surname = updatedSurname;
            _dbContext.SaveChanges();
        }
    }
}
