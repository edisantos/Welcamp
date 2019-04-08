using System;
using System.Collections.Generic;
using System.Text;

namespace welcamp.Domain.Entities
{
    public class StockControl
    {
        public DateTime DataRegister { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
