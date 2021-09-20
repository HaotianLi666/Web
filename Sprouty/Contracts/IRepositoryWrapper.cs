/* File: IRepositoryWrapper.cs
 * Authors: Jonathan Wenek
 * Purpose: This is a generic wrapper interface for the plant and user repository interfaces */

namespace Sprouty.Contracts
{
    public interface IRepositoryWrapper
    {
        IPlantRepository Plant { get; }
        IUserRepository User { get; }


    }


}
