using Core.Models;
using System.Collections.Generic;
using PaymentProcessingDemo.Models;

namespace Core.Repositories.Interfaces
{
    public interface IPaymentRepository
    {
        List<Payment> GetPayments();
        Payment GetPaymentById(int id);
        bool Insert(Payment product);
        bool Update(Payment product);
        bool Delete(int id);
    }
}