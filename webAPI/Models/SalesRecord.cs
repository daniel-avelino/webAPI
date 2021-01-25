using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public class SalesRecord
    {

        public int id { get; set; }
        public DateTime date { get; set; }
        public double amount { get; set; }

        public Seller seller;

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, Seller seller)
        {
            this.id = id;
            this.date = date;
            this.amount = amount;
            this.seller = seller;
        }

        public override bool Equals(object obj)
        {
            return obj is SalesRecord record &&
                   id == record.id &&
                   EqualityComparer<Seller>.Default.Equals(seller, record.seller);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, seller);
        }
    }
}
