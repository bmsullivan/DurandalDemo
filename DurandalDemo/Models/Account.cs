using System;
using System.Collections.Generic;

namespace DurandalDemo.Models
{
    public partial class Account
    {
        public Account()
        {
            this.Transactions = new List<Transaction>();
        }

        public int Id { get; set; }
        public double Balance { get; set; }
        public long AccountNumber { get; set; }
        public Nullable<double> APY { get; set; }
        public Nullable<long> RoutingNumber { get; set; }
        public Nullable<double> APR { get; set; }
        public Nullable<int> Term { get; set; }
        public string Discriminator { get; set; }
        public Nullable<int> AccountHolder_Id { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
