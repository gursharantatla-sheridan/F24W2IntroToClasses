using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24W2IntroToClasses
{
    public class Product
    {
        // fields
        private int id;
        private string _name;
        private double _price;

        // property
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // constructor
        public Product()
        {
            id = 0;
            _name = "";
            _price = 0;
        }

        public Product(int id, string name, double price)
        {
            this.id = id;
            _name = name;
            _price = price;
        }
    }
}
