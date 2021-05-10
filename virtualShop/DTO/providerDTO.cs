using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualShop.DTO
{
    public class providerDTO
    {
        private int id,cnpj,phone,numberAgent
        private string name,email,nameAgent

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

        public string nameAgent
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nameAgent = value;
                }
                else
                {
                    throw new Exception("You must type on name agent area.");
                }
            }
            get
            {
                return this.nameAgent;
            }
        }

        public int cnpj
        {
            set
            {
                if (value != string.Empty)
                {
                    this.cnpj = value;
                }
                else
                {
                    throw new Exception("You must type on cnpj area.");
                }
            }
            get
            {
                return this.cnpj;
            }
        }

        public int numberAgent
        {
            set
            {
                if (value != string.Empty)
                {
                    this.numberAgent = value;
                }
                else
                {
                    throw new Exception("You must type on number agent area.");
                }
            }
            get
            {
                return this.numberAgent;
            }
        }

    }
}