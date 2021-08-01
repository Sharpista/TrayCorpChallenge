using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrayCorpChallenge.Domain.Enitites;

namespace TrayCorpChallenge.Test.Entities
{
    [TestClass]
    public class ProductTests
    {
        private  Product _product;
        private  string  _name = "Livro";
        private  bool _inventory = true;
        private  decimal _value = 0;


        [TestMethod]
        public void ShouldReturnErrorWhenValueIsEqualZero()
        {
            _product = new Product(_name, _inventory, _value);

            Assert.IsFalse(_product.IsValid);
        }
    }
}
