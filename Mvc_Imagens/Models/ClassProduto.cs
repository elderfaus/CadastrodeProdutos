using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Mvc_Imagens.Models
{
    [Table("Produtos")]
    public class ClassProduto
    {
        [Key]
        public int ProdutoId { get; set; }

            [Required(ErrorMessage = "O nome do produto é obrigatório", AllowEmptyStrings = false)]
            public string Empresa { get; set; }
            [Required(ErrorMessage = "A descrição do produto é obrigatória", AllowEmptyStrings = false)]
            public string CNPJ { get; set; }
            
            public string Quantidade { get; set; }
            public string Produto { get; set; }
            public int CategoriaId { get; set; }
            public virtual ClassCategoria Categoria { get; set; }
            [Required(ErrorMessage = "Informe o preço do produto", AllowEmptyStrings = false)]
            [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
            public decimal Preco { get; set; }

    }
}