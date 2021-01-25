using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public class Department
    {

        public int id { get; set; }
        public string name { get; set; }

        public ICollection<Seller> sellers = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void addSeller(Seller seller)
        {
            sellers.Add(seller);
        }

        public override bool Equals(object obj)
        {
            return obj is Department department &&
                   id == department.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

    }
}
