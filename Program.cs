var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Default message
app.MapGet("/", () => "This is a sample web app demonstrates Minimal API.");

// Show welcome message for user name
app.MapGet("/showwelcometext", (string userName) =>
{
    return $"Hello {userName}, Welcome to App Service X DevOps session!";
});

// Convert currency from USD to KRW
app.MapGet("/tokoreawon", (int usd) =>
{
    return $"{usd} USD is {usd * 1300} KRW.";
});
app.Run();
