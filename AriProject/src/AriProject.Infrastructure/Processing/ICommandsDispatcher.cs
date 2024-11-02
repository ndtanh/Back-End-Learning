using System;
using System.Threading.Tasks;

namespace AriProject.Infrastructure.Processing
{
    public interface ICommandsDispatcher
    {
        Task DispatchCommandAsync(Guid id);
    }
}
