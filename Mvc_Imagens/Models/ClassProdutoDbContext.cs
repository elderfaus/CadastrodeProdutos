using System.Data.Entity;

namespace Mvc_Imagens.Models
{
    public class ClassProdutoDbContext : DbContext
    {
        
        public DbSet<ClassProduto> Produtos { get; set; }
        public DbSet<ClassCategoria> Categorias { get; set; }
    }
    
}