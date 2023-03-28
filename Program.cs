var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var counter = 0;

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//app.MapGet("/", (Func<string>)(() => "Welcome to App Service X DevOps session! 2023.03.28"));
app.MapGet("/showwelcometext", (string userName) =>
{
    return $"Hello {userName}, Welcome to App Service X DevOps session!";
});
app.MapGet("/counter", (Func<int>)(() => ++counter ));
app.Run();
