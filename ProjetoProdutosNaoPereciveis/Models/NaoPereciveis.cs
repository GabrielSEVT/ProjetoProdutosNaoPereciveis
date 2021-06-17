using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ProjetoProdutosNaoPereciveis.Models
{
    public class NaoPereciveis
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Insira de 4 a 50 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(250, MinimumLength = 10, ErrorMessage = "Insira de 10 a 250 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, 30, ErrorMessage = "Insira um peso de 1 a 30kg")]
        public int Peso { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Insira de 5 a 250 caracteres")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, 100, ErrorMessage = "Insira um valor de 1 a 100 R$")]
        public int ValorUnitario { get; set; }
    }
}