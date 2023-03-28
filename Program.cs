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
app.MapGet("/todollar", (int krw) =>
{
    return $"{krw} KRW is {krw*1300} USD.";
});
app.Run();
