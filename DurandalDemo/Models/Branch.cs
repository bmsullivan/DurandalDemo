using System;
using System.Collections.Generic;

namespace DurandalDemo.Models
{
    public partial class Branch
    {
        public Branch()
        {
            this.Customers = new List<Customer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address_AddressLine1 { get; set; }
        public string Address_AddressLine2 { get; set; }
        public string Address_City { get; set; }
        public string Address_State { get; set; }
        public string Address_Zip { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
