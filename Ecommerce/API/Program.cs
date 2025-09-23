using API.Models;
using Microsoft.AspNetCore.Mvc;
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
    if (produtos.Any())
    {
        return Results.Ok(produtos); // Retorna a lista de produtos
    }
    else
    {
        return Results.NotFound("Nenhum produto encontrado"); // Retorna erro 404 caso não haja produtos
    }
});

// Get \api\produto\buscar\nome_do_produto

app.MapGet("/api/produto/buscar/{nome}", (string nome) =>
{

});

// Post
app.MapPost("/api/produto/cadastrar", ([FromBody] Produto produto) =>
{
    bool produtoExiste = produtos.Any(p => p.Nome.Equals(produto.Nome, StringComparison.OrdinalIgnoreCase));

    if (produtoExiste)
    {
        return Results.Conflict("Produto já cadastrado.");
    }

    produtos.Add(produto);
    return Results.Ok("Produto cadastrado com sucesso.");
});

app.Run();
