namespace Sprouty.Contracts
{
    public interface IRepositoryWrapper
    {
        IPlantRepository Plant { get; }
        IUserRepository User { get; }
    }
}
