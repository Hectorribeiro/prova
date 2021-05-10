using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualShop.DTO
{
    public class categoryDTO
    {
        //attribute
        private int id
        private string name, description

        public int Id { get => id; set => id = value; }

             public string name
        {
            set
            {
                if (value != string.Empty)
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
                if (value != string.Empty)
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


    }
}

