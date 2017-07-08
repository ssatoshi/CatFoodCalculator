using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CatFoodCalculator.Models
{
    public class CatFoodCalculatorContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CatFoodCalculatorContext() : base("name=CatFoodCalculatorContext")
        {
        }

        public System.Data.Entity.DbSet<CatFoodCalculator.Models.Cat> Cats { get; set; }

        public System.Data.Entity.DbSet<CatFoodCalculator.Models.BodyInfoCategory> BodyInfoCategories { get; set; }

        public System.Data.Entity.DbSet<CatFoodCalculator.Models.FoodType> FoodTypes { get; set; }

        public System.Data.Entity.DbSet<CatFoodCalculator.Models.Maker> Makers { get; set; }
    }
}
