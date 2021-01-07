using System;
using System.ComponentModel.DataAnnotations;

namespace ImportacaoXlsApi.Models
{
    public class Importacao
    {
        [Dapper.Contrib.Extensions.Key]
        public int id { set; get; }

        [Required(ErrorMessage = "Data de entrega é obrigatória")]
        public DateTime data_entrega { set; get; }

        [Required(ErrorMessage = "Descrição é obrigatória")]
        [StringLength(50, ErrorMessage = "A descrição não pode exceder 50 caracteres. ")]
        public string descricao { set; get; }

        [Required(ErrorMessage = "Quantidade é obrigatório")]
        public int quantidade { set; get; }

        [Required(ErrorMessage = "Valor unitário é obrigatório")]
        public decimal valor_unitario { set; get; }
    }
}
