using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public class Seller
    {

        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public double baseSalary { get; set; }

        public Department department { get; set; }
        public int departmentId { get; set; }

        public ICollection<SalesRecord> salesRecord = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
            this.baseSalary = baseSalary;
        }

        public override bool Equals(object obj)
        {
            return obj is Seller seller &&
                   id == seller.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }
    }
}
