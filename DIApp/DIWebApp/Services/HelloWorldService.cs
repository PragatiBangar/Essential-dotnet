namespace DIWebApp.Services
{
    //Each services should be defined by using contract
    public interface IHelloWorldService
    {
        string SaysHello();
    }
    public class HelloWorldService : IHelloWorldService
    {
        public string SaysHello()
        {
            return "Hello";
        }
    }
}