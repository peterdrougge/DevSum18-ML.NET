using Microsoft.ML;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace AutomobilePricePredictor
{
    // this class library can work as a way of shipping your trained learner model.
    // It has an embedded resource, "automobileModel.zip", that it uses when loading, but that can also be overriden by specifying a path to another model archive.
    public class TheGreatWizard
    {
        protected PredictionModel<Models.AutomobileData, Models.AutomobilePrediction> storedModel;

        /// <summary>
        /// Load the learner into memory
        /// </summary>
        /// <param name="filePath">if specified it tries to load the model from the input path, otherwise it loads the model from the embedded resource.</param>
        public async Task Load(string filePath = "")
        {
            try
            {
                if (filePath != string.Empty)
                {
                    storedModel = await PredictionModel.ReadAsync<Models.AutomobileData, Models.AutomobilePrediction>(filePath);
                }
                else
                {
                    var _assembly = Assembly.GetExecutingAssembly();
                    var _stream = _assembly.GetManifestResourceStream("AutomobilePricePredictor.automobileModel.zip");
                    storedModel = await PredictionModel.ReadAsync<Models.AutomobileData, Models.AutomobilePrediction>(_stream);
                }
            }
            catch (Exception ex)
            {
                // handle error..
                throw;
            }
        }

        public float Predict(string _make, string _bodyStyle, float _wheelBase, float _engineSize, float _horsepower, float _peakRpm, float _cityMpg, float _highwayMpg)
        {
            if (storedModel==null)
            {
                throw new Exception("please make sure to load the learner model before calling Predict()");
            }

            var data = new Models.AutomobileData
            {
                make = _make,
                bodyStyle = _bodyStyle,
                wheelBase = _wheelBase,
                engineSize = _engineSize,
                horsepower = _horsepower,
                peakRpm = _peakRpm,
                cityMpg = _cityMpg,
                highwayMpg = _highwayMpg
            };

            var result = storedModel.Predict(data);

            return result.price;
        }
    }
}
