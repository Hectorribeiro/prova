using VirtualShop.DTO;
using VirtualShop.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
                                 //Creating the CRUD

namespace VirtualShop.BLL
{

    public class productBLL
    {
        private MysqlDAL con = new MysqlDAL();

        //method CRUD
   
        public void Inserir(productDTO product)
        {
            string sql = string.Format($@ "INSERT INTO product VALUES (null,"{ product.Name} 
            ","{ product.Description}
            ","{ product.Value}
            ","{ product.ProviderID}
            ","{ product.CategoryID}
            ","{ product.Photo}
            ","{ product.QuantityStok}
                ");");

            con.ExecuteSQL(sql);
        }
        public void Excluir(productDTO product)
        {
            string sql = string.Format($@"DELETE FROM product WHERE id = { product.id};");

            con.ExecuteSQL(sql);
        }

        public void Alterar(productDTO product)
        {
            string sql = string.Format($@"UPDATE product SET name =
        '{product.name}',
         description = '{product.description}',
        value = '{product.value}',
        providerID = '{product.providerID}',
        categoryID = '{product.categoryID}',
        photo = '{product.photo}',
        quantity Stok = '{product.quantityStok}';");

            con.ExecuteSQL(sql)
        }

        public DataTable ConsultID(int id)
        {
            string sql = string.Format($@"SELECT + FROM product WHERE id = {id};");

            return con.ExecuteConsult(sql);
        }
        
        public DataTable Search(string condicao)
        {
            string sql = string.Format($@"SELECT p.id,p.name,p.description,p.value,p.quantity,
             c.name,p.name  
             FROM product as p, category as c, provider as pro
             WHERE p.categoryID = c.id and p.providerID = pro.id and {condicao} ORDER BY p.id;");

            return con.ExecuteConsult(sql);
        }

    }

}


