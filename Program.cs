var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", () => "This is a sample web app demonstrates Minimal API.");
/*app.MapGet("/showwelcometext", (string userName) =>
{
    return $"Hello {userName}, Welcome to App Service X DevOps session!";
});*/
app.MapGet("/todollar", (int usd) =>
{
    return $"{usd} USD is {usd * 1300} KRW.";
});
app.Run();
