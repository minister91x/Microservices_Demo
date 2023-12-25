var builder = WebApplication.CreateBuilder(args);

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxyAccount"))
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxyProduct"));

var app = builder.Build();

app.UseAuthorization();
//app.UseHttpsRedirection();
app.MapReverseProxy();


app.Run();
