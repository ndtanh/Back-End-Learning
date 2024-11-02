using MediatR;
using AriProject.Application;
using AriProject.Application.Configuration.Commands;
using AriProject.Infrastructure.Processing.Outbox;

namespace AriProject.Infrastructure.Processing.InternalCommands
{
    internal class ProcessInternalCommandsCommand : CommandBase<Unit>, IRecurringCommand
    {

    }
}