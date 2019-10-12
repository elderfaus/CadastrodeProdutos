using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Mvc_Imagens.Models
{
    [Table("Categorias")]
    public class ClassCategoria
    {
            [Key]
            public int CategoriaId { get; set; }
            [Display(Name = "Nome da Categoria")]
            public String CategoriaNome { get; set; }

            public List<ClassProduto> Produtos { get; set; }
        
    }
}