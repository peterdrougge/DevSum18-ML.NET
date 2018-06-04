using Microsoft.ML.Runtime.Api;
namespace AutomobileTrainer.Models
{
    public class AutomobilePrediction
    {
        [ColumnName("Score")]
        public float price;
    }
}
