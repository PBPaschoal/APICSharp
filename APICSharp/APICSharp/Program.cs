var builder = WebApplication.CreateBuilder(args);

// Estas linhas adicionam os "poderes" do Swagger à sua API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Verifica se estamos em modo de desenvolvimento para mostrar o Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// --- Nossas rotas (O que a API faz) ---

// Rota de boas-vindas
app.MapGet("/", () => "Olá, Rio de Janeiro! API funcionando com sucesso.");

// Rota que retorna dados de um produto
app.MapGet("/produto", () => new {
    Id = 1,
    Nome = "Café Carioca",
    Preco = 5.50
});

app.Run();