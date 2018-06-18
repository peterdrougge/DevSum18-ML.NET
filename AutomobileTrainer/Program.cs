using AutomobileTrainer.Models;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using Microsoft.ML.Models;
using Microsoft.ML.Transforms;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace AutomobileTrainer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // create a learning pipeline
            var pipeline = new LearningPipeline();

            // import training data (the data is already split into three files using https://github.com/peterdrougge/DataFileSplitter and located in the \data folder of this project.)
            var traindataPath = @"c:\dev\ml\automobile price data (raw)-train.csv";
            pipeline.Add(new TextLoader(traindataPath).CreateFrom<AutomobileData>(useHeader: true, separator: ';'));
            // transform features
            pipeline.Add(new ColumnCopier(("price", "Label")));
            pipeline.Add(new ColumnDropper() { Column = new string[] {
                "symboling",
                "normalizedLosses",
                "fuelType",
                "aspiration",
                "numOfDoors",
                "driveWheels",
                "engineLocation",
                "length",
                "width",
                "height",
                "curbWeight",
                "engineType",
                "numOfCylinders",
                "fuelSystem",
                "bore",
                "stroke",
                "compressionRatio",
                "cityMpg" } });
            pipeline.Add(new CategoricalOneHotVectorizer(
                "make", 
                "bodyStyle"));
            pipeline.Add(new ColumnConcatenator(outputColumn: "CategoricalFeatures", 
                "make", 
                "bodyStyle"));
            pipeline.Add(new ColumnConcatenator(outputColumn: "NumericalFeatures", 
                "wheelBase", 
                "engineSize", 
                "horsepower", 
                "peakRpm", 
                "highwayMpg"));
            pipeline.Add(new ColumnConcatenator(outputColumn: "Features", 
                "CategoricalFeatures", 
                "NumericalFeatures" ));
            
            // select algorithm
            pipeline.Add(new FastTreeRegressor());

            // train model
            Console.WriteLine("=============== Training =====================");
            var model = pipeline.Train<AutomobileData, AutomobilePrediction>();
            Console.WriteLine("==============================================");
            Console.WriteLine();
            
            // evaluate model
            Console.WriteLine("=============== Evaluating ===================");
            // import test data (the data is already split into three files using https://github.com/peterdrougge/DataFileSplitter and located in the \data folder of this project.)
            var testdataPath = @"C:\dev\ml\automobile price data (raw)-test.csv";
            var testdata = new TextLoader(testdataPath).CreateFrom<AutomobileData>(useHeader: true, separator: ';');
            var evaluator = new RegressionEvaluator();
            var metrics = evaluator.Evaluate(model, testdata);
            Console.WriteLine($"Loss= {metrics.LossFn} (..)");
            Console.WriteLine($"Rms = {metrics.Rms} (..)");
            Console.WriteLine($"RSquared = {metrics.RSquared} (a value between 0 and 1, the closer to 1, the better)");
            Console.WriteLine("==============================================");
            Console.WriteLine();

            // predict on withheld data
            Console.WriteLine("=============== Predicting ===================");
            var data = TestData.Automobiles;
            var predictions = model.Predict(data);
            var results = data.Zip(predictions, (automobile, prediction) => new { automobile, prediction });
            foreach (var item in results)
            {
                Console.WriteLine(value: $"{item.automobile.make} {item.automobile.bodyStyle} would sell for {item.prediction.price:N0} -> actual was {((AutomobileTestData)item.automobile).Actual:N0}.");
            }
            Console.WriteLine("==============================================");

            // store model
            await model.WriteAsync(@"C:\dev\ml\automobileModel.zip");

            Console.WriteLine("");
            Console.WriteLine("All done. Hit any key to exit.");
            Console.Read();
        }
    }
}
