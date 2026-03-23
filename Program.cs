var builder = WebApplication.CreateBuilder(args);

// 1. Avisa a aplicação que vamos usar a estrutura de Controllers
builder.Services.AddControllers();

// 2. Mantém a configuração de documentação da API (OpenAPI)
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// 3. Conecta as rotas dos nossos arquivos na pasta Controllers
app.MapControllers();

app.Run();