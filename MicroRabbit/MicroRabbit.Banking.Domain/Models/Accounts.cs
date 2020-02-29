using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Models
{
    public class Accounts
    {
        public int Id { get; set; }
        public string AccountType { get; set; }
        public decimal AccountBalanced { get; set; }
    }
}
