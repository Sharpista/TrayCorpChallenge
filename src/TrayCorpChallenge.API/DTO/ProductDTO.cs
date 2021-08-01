using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrayCorpChallenge.API.DTO
{
    public class ProductDTO
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }
        public bool Invetory { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Valor Invalido {0}; Maximo 2 Casas Decimais.")]
        public decimal Valor { get; set; }
    }
}
