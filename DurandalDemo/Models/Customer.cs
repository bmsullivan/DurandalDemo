using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DurandalDemo.Models
{
    public partial class Customer
    {
        public Customer()
        {
            this.Accounts = new List<Account>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string HomeAddress_AddressLine1 { get; set; }
        public string HomeAddress_AddressLine2 { get; set; }
        public string HomeAddress_City { get; set; }
        public string HomeAddress_State { get; set; }
        public string HomeAddress_Zip { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> HomeBranch_Id { get; set; }
        [JsonIgnore]
        public virtual ICollection<Account> Accounts { get; set; }
        [JsonIgnore]
        public virtual Branch Branch { get; set; }
    }
}
