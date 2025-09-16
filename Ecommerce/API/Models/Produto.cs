using System;

namespace API.Models;

public class Produto
{
    // Atributos|Propriedades
    public Produto()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
        
    }
    public string Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public double Preco { get; set; }
    public DateTime CriadoEm { get; set; }

}
