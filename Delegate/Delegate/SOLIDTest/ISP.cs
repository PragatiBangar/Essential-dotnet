using System;

//Interface Segregation PrinCiple(ISP)

namespace ISP
{
    public interface IOrder
    {
        void AddToCart();
    }

    public interface IOnlineOrder
    {
        void ProcessThroghPaymentGateway();
    }

    //Multiple interface inheritance
    public class OnlineOrder : IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            //Do add to cart
        }

        public void ProcessThroghPaymentGateway()
        {
            //process through credit cart, debit cart,UPI
            //NetBanking
        }
    }
    public class OfflineOrder : IOrder
    {
        public void AddToCart()
        {
            //Do add to cart
        }
    }
}