using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManager.Models
{
    public class ModelFactory
    {
        public static ProductCategory Create (ProductCategoryViewModel model)
        {


            return new ProductCategory
            {

                ID = model.id,
                NAME = model.Name,
            };
        }


    }
    

}