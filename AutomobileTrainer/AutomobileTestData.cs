namespace AutomobileTrainer.Models
{
    public class AutomobileTestData : AutomobileData
    {
        public AutomobileTestData(string _make, string _bodyStyle, float _wheelBase, float _engineSize, float _horsepower, float _peakRpm, float _cityMpg, float _highwayMpg, float _price)
        {
            make = _make;
            bodyStyle = _bodyStyle;
            wheelBase = _wheelBase;
            engineSize = _engineSize;
            horsepower = _horsepower;
            peakRpm = _peakRpm;
            cityMpg = _cityMpg;
            highwayMpg = _highwayMpg;
            Actual = _price;
        }
        public float Actual;
    }
}
