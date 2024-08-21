
namespace Archse.Models
{

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }

    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ICollection<Produto> Produtos { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }

    public class GameResponse
    {
        public string Identificador { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

    }
    public class GameRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

    }
    public class Game
    {
        public int Id { get; set; }

        public string Identificador { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public static implicit operator Game(GameResponse v)
        {
            throw new NotImplementedException();
        }
    }

  
}
