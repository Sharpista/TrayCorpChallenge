using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrayCorpChallenge.Domain.Contracts;
using TrayCorpChallenge.Shared.Entities;

namespace TrayCorpChallenge.Domain.Enitites
{
    public class Product : Entity
    {
        public Product()
        {

        }
        public Product(string name, bool inventory, decimal value)
        {
            Name = name;
            Inventory = inventory;
            Value = value;

            AddNotifications(new CreateProductContract(this));

        }
        
        public virtual string Name { get; private set; }
        public virtual bool Inventory { get; private set; }

        [Column(TypeName = "decimal(18,2")]
        public virtual decimal Value { get; private set; }

       
    }
}
