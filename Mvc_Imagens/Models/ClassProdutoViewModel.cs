using System;
using System.ComponentModel.DataAnnotations;
using System.Web;


namespace Mvc_Imagens.Models
{
    public class ClassProdutoViewModel
    {
        public Int32 ProdutoId { get; set; }
        [Required(ErrorMessage = "O nome da Empresa é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome da Empresa")]
        public String Empresa { get; set; }
        [Required(ErrorMessage = "O CNPJ é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "CNPJ")]
        public String CNPJ { get; set; }
        [Required(ErrorMessage = "Informe a Quantidade", AllowEmptyStrings = false)]
        [Display(Name = "Quantidade")]
        public String Quantidade { get; set; }
        [Required(ErrorMessage = "Informe o Produto", AllowEmptyStrings = false)]
        [Display(Name = "Produto")]
        public String Produto { get; set; }
        [Required(ErrorMessage = "Informe o Preço", AllowEmptyStrings = false)]
        [Display(Name = "Preço")]
        public Decimal Preco { get; set; }
        [Required(ErrorMessage = "Selecione uma categoria", AllowEmptyStrings = false)]
        [Display(Name = "Categoria")]
        public Int32 CategoriaId { get; set; }
        
    }
}