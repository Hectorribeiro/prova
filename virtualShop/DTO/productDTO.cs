using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;


namespace VirtualShop.DTO
{
    public class product
    {
        //attribute
        private int id, categoryID, quantityStok, providerID;
        private string name, description, photo;
        private double value;

        //pattern method get and set 

        public int Id { get => id; set => id = value; }
        public int ProviderID { get => providerID; set => providerID = value; }
        public string Photo { get => photo; set => photo = value; }
        public double Value { get => value; set => this.value = value; }

        //person method get and set 
        //the area cannot be empty

        public string name
        {
            set
            {
                if(value != string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new Exception("You must type on name area.");
                }
            }
            get
            {
                return this.name;
            }
        }

        public string description
        {
            set
            {
                if(value != string.Empty)
                {
                    this.description = value;
                }
                else
                {
                    throw new Exception("You must type on description area.");
                }
            }
            get
            {
                return this.description;
            }
        }


        public int categoryID
        {
            set
            {
                if (value != 0)
                {
                    this.categoryID = value
                }
                else
                {
                    throw new Exception("You must type on category area.");
                }
            }
            get
            {
                return this.categoryID;
            }
        }


        public int quantityStok
        {
            set
            {
                if (value != 0)
                {
                    this.quantityStok = value
                }
                else
                {
                    throw new Exception("You must type on quantity area.");
                }
            }
            get
            {
               return this.quantityStok;
            }
        }

      








    }


}

