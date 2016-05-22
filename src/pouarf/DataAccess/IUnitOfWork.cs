using System;

namespace Pouarf.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
