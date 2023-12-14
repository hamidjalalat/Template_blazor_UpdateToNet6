using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        public Customer(int id,string customerName)
        {
            Id = id;
            CustomerName = customerName;
        }
        public int Id { get; set; }
        public string CustomerName { get; set; }
    }
}
