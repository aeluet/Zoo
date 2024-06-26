using Zoo.Data;
using Zoo.Repository.IRepository;

namespace Zoo.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IArrazaRepository Arraza { get; private set; }
        public ILekuaRepository Lekua { get; private set; }
        public IAnimaliaRepository Animalia{ get; private set; }
        public ILangileRepository Langilea { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Arraza = new ArrazaRepository(_db);
            Lekua = new LekuaRepository(_db);
            Animalia= new AnimaliaRepository(_db);
            Langilea= new LangileRepository(_db);
        }
        

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
