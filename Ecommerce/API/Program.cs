using API.Models;
using System;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Lista de Produtos
List<Produto> produtos = new List<Produto>
{
    new Produto { Nome = "Camiseta", Quantidade = 50, Preco = 39.90 },
    new Produto { Nome = "Calça Jeans", Quantidade = 30, Preco = 89.90 },
    new Produto { Nome = "Tênis Esportivo", Quantidade = 20, Preco = 120.00 },
    new Produto { Nome = "Boné", Quantidade = 70, Preco = 25.00 },
    new Produto { Nome = "Mochila", Quantidade = 15, Preco = 150.00 },
    new Produto { Nome = "Relógio", Quantidade = 10, Preco = 299.90 },
    new Produto { Nome = "Óculos de Sol", Quantidade = 25, Preco = 79.90 },
    new Produto { Nome = "Jaqueta", Quantidade = 12, Preco = 199.90 },
    new Produto { Nome = "Meias (par)", Quantidade = 100, Preco = 9.90 },
    new Produto { Nome = "Cinto de Couro", Quantidade = 40, Preco = 59.90 }
};

app.MapGet("/", () => "API de Produtos");

// Get
app.MapGet("/api/produto/listar", () =>
{
    return produtos;
});

// Post
app.MapPost("/api/produto/cadastrar", (Produto produto) =>
{
    produtos.Add(produto);
});

app.Run();
