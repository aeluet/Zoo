namespace Zoo.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IArrazaRepository Arraza { get; }
        ILekuaRepository Lekua { get; }
        IAnimaliaRepository Animalia { get; }
        ILangileRepository Langilea { get; }

        void Save();
    }
}
