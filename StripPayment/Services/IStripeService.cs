using StripPayment.Resources;

namespace StripPayment.Services
{
    public interface IStripeService
    {
        Task<CustomerResource> CreateCustomer(CreateCustomerResource resource, CancellationToken cancellationToken);
        Task<ChargeResource> CreateCharge(CreateChargeResource resource, CancellationToken cancellationToken);
    }
}
