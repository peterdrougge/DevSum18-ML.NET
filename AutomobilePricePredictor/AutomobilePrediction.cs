using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomobilePricePredictor.Models
{
    public class AutomobilePrediction
    {
        [ColumnName("Score")]
        public float price;
    }
}
