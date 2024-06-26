using System.Linq.Expressions;
using Zoo.Data;
using Zoo.Models;
using Zoo.Repository.IRepository;

namespace Zoo.Repository
{
    public class AnimaliaRepository : Repository <Animalia>,IAnimaliaRepository 
    {
        private ApplicationDbContext _db;
        public AnimaliaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        
        public void Update(Animalia obj)
        {
            _db.Animaliak.Update(obj);
        }
    }
}
