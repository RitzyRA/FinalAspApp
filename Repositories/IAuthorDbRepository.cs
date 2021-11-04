using FinalAspApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAspApp.Repositories
{
    public interface IAuthorDbRepository
    {
        IEnumerable<Author> GetAll();
        bool DeleteById(int? id);
        void Create(string name, string surname);
        Author GetById(int id);
        void Update(int updateableId, string updatedName, string updatedSurname);
    }
}
