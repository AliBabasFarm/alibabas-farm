using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Direction_optimized
{
  public class Order
    {
        private string city;
        private int the_number_of_milk_p;
        private int the_number_of_yogurt_p;
        private int the_number_of_cheese_p;

        public int The_number_of_milk_p
        {
            get
            {
                return the_number_of_milk_p;
            }

            set
            {
                the_number_of_milk_p = value;
            }
        }

        public int The_number_of_yogurt_p
        {
            get
            {
                return the_number_of_yogurt_p;
            }

            set
            {
                the_number_of_yogurt_p = value;
            }
        }

        public int The_number_of_cheese_p
        {
            get
            {
                return the_number_of_cheese_p;
            }

            set
            {
                the_number_of_cheese_p = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public Order() { }
        public Order(string City,int milk, int yogurt,int cheese)
        {
            this.City = City;
            The_number_of_milk_p = milk;
            The_number_of_yogurt_p = yogurt;
            The_number_of_cheese_p = cheese;
        }
        
        

    }
}
