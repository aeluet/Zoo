using Zoo.Models;

namespace Zoo.Repository.IRepository
{
    public interface IAnimaliaRepository : IRepository<Animalia>
    {
        void Update(Animalia obj);
    }
}
