using CRMMinimalWebAPI.Entities;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.UseHttpsRedirection();

app.MapGet("/api/customers", () =>
{
    List<Customer> customers = new List<Customer> { new Customer { Id=12, Name="Raj", Address="Pune"},
                                                    new Customer { Id=13, Name="Veeru", Address="Mumbai"},
                                                    new Customer { Id=14, Name="Samay", Address="Delhi"}
    };
    return Results.Ok(customers);
    
});

app.MapGet("/api/customers/{id}", (int id) =>
{
    List<Customer> customers = new List<Customer> { new Customer { Id=12, Name="Raj", Address="Pune"},
                                                    new Customer { Id=13, Name="Veeru", Address="Mumbai"},
                                                    new Customer { Id=14, Name="Samay", Address="Delhi"}
    };

   var data = customers.FirstOrDefault(u=>u.Id==id);
   return Results.Ok(data); 
});

app.MapPost("/api/customers", (Customer customer) =>
{    
    bool status=false;
    List<Customer> customers = new List<Customer> { new Customer { Id=12, Name="Raj", Address="Pune"},
                                                    new Customer { Id=13, Name="Veeru", Address="Mumbai"},
                                                    new Customer { Id=14, Name="Samay", Address="Delhi"}
    };
    if(customer!=null){
    customers.Add(customer);
    status=true;
    }
    return Results.Ok(status);
});

app.MapPut("/api/products/{id}", (int id, Customer product ) =>
{
    return Results.NoContent();
});

app.MapDelete("/api/products/{id}", (int id ) =>
{
    return Results.NoContent();
});


app.Run();

