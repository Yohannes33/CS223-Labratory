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
        
        public void save()
        {
            modelList.Add(this);
                
        }
        public static List<Model> GetAllProducts()
        {
            return modelList;
        }
       
    }
}
