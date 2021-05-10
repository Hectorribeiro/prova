using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualShop.DTO
{
    public class ClientDTO
    {
        private int id,cpf,phone,password
        private string name,email

            public int Id { get => id; set => id = value; }
            public int Phone { get => phone; set => phone = value; }

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

        public string email
        {
            set
            {
                if (value != string.Empty)
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("You must type on email area.");
                }
            }
            get
            {
                return this.email;
            }
        }

        public int cpf
        {
            set
            {
                if (value != string.Empty)
                {
                    this.cpf = value;
                }
                else
                {
                    throw new Exception("You must type on cpf area.");
                }
            }
            get
            {
                return this.cpf;
            }
        }

        public int password
        {
            set
            {
                if (value != string.Empty)
                {
                    this.password = value;
                }
                else
                {
                    throw new Exception("You must type on password area.");
                }
            }
            get
            {
                return this.password;
            }
        }












    }
}

