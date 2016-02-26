using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProductManager.Models
{
    public class ProductCategoryViewModel
    {
        
        public int id { get; set; }
        [Required(ErrorMessage ="Category name is required !!!")]
        public string Name { get; set; }

        


    }
}