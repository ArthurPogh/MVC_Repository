using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHelloWord.Models
{
    public class ModelFactory
    {
        public static string Name { get; private set; }
        public static decimal Price { get; private set; }

        public static PizzaViewModel Create(Pizza pizza)
        {

            return new PizzaViewModel
            {
                Name = pizza.Name,
                Price = pizza.Price
            };
        }

        public static List<Pizza> GetPizzaList()
        {

            var list = new List<Pizza>
            {

                new Pizza { Id = Guid.NewGuid().ToString(), Name = "Pepperoni", Price = 3000},
                new Pizza { Id = Guid.NewGuid().ToString(), Name = "Tashir", Price = 4000},
                new Pizza { Id = Guid.NewGuid().ToString(), Name = "Mashir", Price = 4000}
            };

            return list;

        }
    }
}