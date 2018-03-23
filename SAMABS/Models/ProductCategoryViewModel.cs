using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAMABS.Models
{
    public class ProductCategoryViewModel
    {
        public List<Product> products;
        public SelectList categories;
        public string productCategory { get; set; }
    }
}
