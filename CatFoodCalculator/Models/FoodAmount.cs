using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatFoodCalculator.Models
{
    public class FoodAmount
    {

        public int Id { get; set; }

        public decimal CatWeight { get; set; }

        public decimal ProperAmount { get; set; }

        public decimal MinAmount { get; set; }

        public decimal MaxAmount { get; set; }

        public decimal PackageWeight { get; set; }

        public bool IsDeleted { get; set; }

        public Food Food { get; set; }
    }
}