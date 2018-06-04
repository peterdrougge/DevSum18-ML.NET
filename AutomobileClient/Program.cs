using System;
using System.Threading.Tasks;

namespace AutomobileClient
{
    // This console app has a reference to the AutomobilePricePredictor class library app.
    // it uses the class library to predict the price of a couple of cars (same list as in the TestData class of the Trainer).
    class Program
    {
        static async Task Main(string[] args)
        {
            var genie = new AutomobilePricePredictor.TheGreatWizard();

            await genie.Load();

            Console.WriteLine($"Prediction: {genie.Predict("bmw", "sedan", 101.20f, 108, 101, 5800, 23, 29)} (Actual was 16430)");
            Console.WriteLine($"Prediction: {genie.Predict("nissan", "wagon", 100.40f, 181, 152, 5200, 17, 22)} (Actual was 14399)");
            Console.WriteLine($"Prediction: {genie.Predict("dodge", "hatchback", 93.70f, 90, 68, 5500, 31, 38)} (Actual was 6377)");
            Console.WriteLine($"Prediction: {genie.Predict("bmw", "sedan", 101.20f, 164, 121, 4250, 21, 28)} (Actual was 20970)");
            Console.WriteLine($"Prediction: {genie.Predict("alfa-romeo", "convertible", 88.60f, 130, 111, 5000, 21, 27)} (Actual was 13495)");
            Console.WriteLine($"Prediction: {genie.Predict("mercedes-benz", "wagon", 110.00f, 183, 123, 4350, 22, 25)} (Actual was 28248)");
            Console.WriteLine($"Prediction: {genie.Predict("toyota", "sedan", 95.70f, 110, 56, 4500, 34, 36)} (Actual was 7898)");

            Console.WriteLine("All done. Hit any key to exit.");
            Console.Read();
        }
    }
}
