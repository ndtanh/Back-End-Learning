using System;
using MediatR;
using Newtonsoft.Json;
using AriProject.Application.Configuration.Commands;
using AriProject.Domain.Payments;

namespace AriProject.Application.Payments.SendEmailAfterPayment
{
    public class SendEmailAfterPaymentCommand : InternalCommandBase<Unit>
    {
        public PaymentId PaymentId { get; }

        [JsonConstructor]
        public SendEmailAfterPaymentCommand(Guid id, PaymentId paymentId) : base(id)
        {
            this.PaymentId = paymentId;
        }
    }
}