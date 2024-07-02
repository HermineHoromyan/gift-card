using NverCard.Public.Client.ServiceProxies.Queries.CustomerOrders.Models;
using NverCard.Public.Client.ServiceProxies.Queries.GiftCertificates.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.OrderService
{
    public interface IOrderService
    {
        event Action OnChange;

        /// <summary>
        /// Return customer orders
        /// </summary>
        public Task<IEnumerable<CustomerOrderModel>> GetCustomerOrders();

        /// <summary>
        /// Get customer all certificates from all orders
        /// </summary>
        public Task<IEnumerable<CertificateModel>> GetCustomerCards(CertificateInputModel inputModel);
    }
}
