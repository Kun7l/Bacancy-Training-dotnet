using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_Day_4
{
    public class OrderProcessor
    {
        private readonly IPriceCalculator _priceCalculator;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly INotificationService _notificationService;

        public OrderProcessor(
            IPriceCalculator priceCalculator,
            IPaymentProcessor paymentProcessor,
            INotificationService notificationService)
        {
            _priceCalculator = priceCalculator;
            _paymentProcessor = paymentProcessor;
            _notificationService = notificationService;
        }

        public void Process(Order order)
        {
            double total = _priceCalculator.CalculateTotal(order);
            _paymentProcessor.ProcessPayment(total);
            _notificationService.Send("Order processed successfully");
        }
    }
}
