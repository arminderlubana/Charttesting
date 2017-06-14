using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cureve.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    namespace dynamic.Models
    {
        public class ProductModel
        {
            public int ID { get; set; }
            public string DateTitle { get; set; }
            public string StartTitle { get; set; }
            public string FinishTitle { get; set; }
            //public ICollection<Product> ProductData { get; set; }
            public Product ProductData { get; set; }
        }
        public class Product
        {
            public int ProductId { get; set; }
            public string Date { get; set; }
            public string Start { get; set; }
            public string Finish { get; set; }
        }
    }
}