var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>"/operacion?a=#&b=#");
app.MapGet("/suma", (double a, double b) => a+b);
app.MapGet("/resta", (double a, double b) => a - b);
app.MapGet("/multiplicacion", (double a, double b) => a * b);
app.MapGet("/division", (double a, double b) => a / b);


app.Run();