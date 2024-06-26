using System.Linq.Expressions;
using Zoo.Data;
using Zoo.Models;
using Zoo.Repository.IRepository;

namespace Zoo.Repository
{
    public class LangileRepository : Repository<Langile>, ILangileRepository 
    {
        private ApplicationDbContext _db;
        public LangileRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        

        public void Update(Langile obj)
        {
            var objFromDb = _db.Langileak.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Izena = obj.Izena;
                objFromDb.Abizena = obj.Abizena;
                objFromDb.Postua = obj.Postua;
                objFromDb.Turnoa = obj.Turnoa;
                

            }
        }
    }
}
