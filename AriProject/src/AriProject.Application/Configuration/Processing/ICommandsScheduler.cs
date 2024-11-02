using System.Threading.Tasks;
using MediatR;
using AriProject.Application.Configuration.Commands;

namespace AriProject.Application.Configuration.Processing
{
    public interface ICommandsScheduler
    {
        Task EnqueueAsync<T>(ICommand<T> command);
    }
}