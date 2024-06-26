using Zoo.Models;

namespace Zoo.Repository.IRepository
{
    public interface ILangileRepository : IRepository<Langile>
    {
        void Update(Langile obj);
    }
}
