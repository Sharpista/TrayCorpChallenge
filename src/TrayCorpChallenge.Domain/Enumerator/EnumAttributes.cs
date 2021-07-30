using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrayCorpChallenge.Domain.Enumerator
{
    public enum EnumAttributes
    {
        [Description("Value")]
        Value = 1,
        [Description("Inventory")]
        Inventory = 2,
        [Description("Name")]
        Name = 3

    }
}
