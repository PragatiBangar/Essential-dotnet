using System;
//Single Responsibility Principle (SRP)
/*
    A class should have one and only one reason to change, 
    meaning that a class should have only one job. 
*/

namespace SRP
{
    public class Data{  }
    public class BusinessServer
    {
        public void Get(Data message)
        {
            //Event handling logic on Get message from queue
        }
        public void Process(Data message)
        {
            //check if message server is listening
            //Process the message
        }
        public void Dispatch(Data message)
        {
            //Event Handling logic on dispatch message to dispatch
        }
    }
    //Contract:
    // they are used for loosely coupled architecture
    //defines rules
    //defines specifications
    public interface IService
    {
        void Get(Data message);
        void Process(Data message);
        void Dispatch(Data message);

    }

    //act like subject matter expert
public class PaymentServiceProvider:IService{
    public void Get(Data message)
    {  }

    public void Process(Data message)
    {
        //Process payment processing
    }
    public void Dispatch(Data message)
    {  }
}
    public class DeliveryServiceProvider: IService{
    public void Get(Data message)
    {  }

    public void Process(Data message)
    {  }
    public void Dispatch(Data message)
    {  }   
    }
    
    public class BillingServiceProvider: IService{
    public void Get(Data message)
    {  }

    public void Process(Data message)
    {  }
    public void Dispatch(Data message)
    {  }   
    }

    //act like a manager
    public class Server
    {
        IService service;

        public Server(IService svc)
        {
            this.service = svc;
        }
        public void Get(Data message)
        {
            service.Get(message);
        }
        public void Process(Data message)
        {
            service.Process(message);
        }
        public void Dispatch(Data message)
        {
            service.Dispatch(message);
        }
    }

/*
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("single responsibility principle(SRP)");
            IService service = new PaymentServiceProvider();

            Server svr = new Server(service);
            Data message = new Data();
            svr.Process(message);
        }
    }*/
}