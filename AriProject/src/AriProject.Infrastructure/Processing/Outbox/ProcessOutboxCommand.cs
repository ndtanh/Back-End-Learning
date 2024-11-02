using MediatR;
using AriProject.Application;
using AriProject.Application.Configuration.Commands;

namespace AriProject.Infrastructure.Processing.Outbox
{
    public class ProcessOutboxCommand : CommandBase<Unit>, IRecurringCommand
    {

    }
}