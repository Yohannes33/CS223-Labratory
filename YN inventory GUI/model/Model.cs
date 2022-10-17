using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Lab_desktop.model
{
    internal class Model
    {
       static private List<Model> modelList = new List<Model>();
            public string Number { get; set; }
            public DateTime Date { get; set; }
            public string Inventorynum { get; set; }
            public string Objectname { get; set; }
            public string Count { get; set; }
            public string  Price { get; set; }
            public string productType { get; set; }

        public void save()
        {
            try
            {
                string connstring = @"Data source= localhost ;initial Catalog=Lab;Integrated security= true ";
                SqlConnection con = new SqlConnection(connstring);
                con.Open();
                
                string query = "insert into products values(@date,2,'ab',3)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@date",this.Number);
                //cmd commandtype = commandtype storeprocedure
                //cmd parameters add("@price",sqldbtype int)value = 
                //cmd.Parameters Addvalues( )
                var result = cmd.ExecuteNonQuery();// number of rows affected 
                //var result = cmd.ExecuteScalar();// single value is returned 
                //var result = cmd.ExecuteReader();// multiple elements are returned

                


                con.Close();
            }
            catch (Exception)
            {
            }
            modelList.Add(this);
                
        }
        public static List<Model> GetAllProducts()
        {
            return modelList;
        }

        public static Model findOne(string name)
        {
            //ToLower() is used to make case insensative search. 
            return modelList.Find(p => p.Objectname.ToLower() == name.ToLower());
        }

        public static void updateProduct(Model editedProduct, Model productTobeEdited)
        {
            for (int i = 0; i < modelList.Count; i++)
            {
                if (modelList[i] == productTobeEdited)
                {
                    modelList[i] = editedProduct;
                }
            }

        }

    }
}
