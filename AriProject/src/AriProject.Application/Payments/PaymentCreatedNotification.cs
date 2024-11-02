using Newtonsoft.Json;
using AriProject.Application.Configuration.DomainEvents;
using AriProject.Domain.Payments;

namespace AriProject.Application.Payments
{
    public class PaymentCreatedNotification : DomainNotificationBase<PaymentCreatedEvent>
    {
        public PaymentId PaymentId { get; }

        public PaymentCreatedNotification(PaymentCreatedEvent domainEvent) : base(domainEvent)
        {
            this.PaymentId = domainEvent.PaymentId;
        }

        [JsonConstructor]
        public PaymentCreatedNotification(PaymentId paymentId) : base(null)
        {
            this.PaymentId = paymentId;
        }
    }
}