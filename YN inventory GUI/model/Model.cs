using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
