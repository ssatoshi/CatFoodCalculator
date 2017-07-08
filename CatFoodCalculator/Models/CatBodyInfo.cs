using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatFoodCalculator.Models
{
    public class CatBodyInfo
    {

        public int Id { get; set; }
        
        public decimal Value { get; set; }

        public DateTime MeasurementDate { get; set; }

        public virtual Cat Cat { get; set; }

        public virtual BodyInfoCategory BodyInfoCategory { get; set;}

    }
}