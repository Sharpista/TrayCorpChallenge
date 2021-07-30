using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrayCorpChallenge.Domain.Enitites;

namespace TrayCorpChallenge.Domain.Contracts
{
    public class CreateProductContract : Contract<Product>
    {
        public CreateProductContract(Product product)
        {
            Requires()
                .IsLowerThan(0, product.Value, "Valor", "Valor não pode ser 0 ou igual a 0");
        }
    }
}
