using System.Collections.Generic;

namespace AutomobileTrainer.Models
{
    public static class TestData
    {
        public static readonly IEnumerable<AutomobileData> Automobiles = new[]
        {
            // make             body-style  wheel-base  engine-size horsepower  peak-rpm    city-mpg    highway-mpg price
            //-----------------|-----------|-----------|-----------|-----------|-----------|-----------|-----------|-----
            // bmw              sedan       101.20      108         101         5800        23          29          16430
            // nissan           wagon       100.40      181         152         5200        17          22          14399
            // dodge            hatchback   93.70       90          68          5500        31          38          6377
            // bmw              sedan       101.20      164         121         4250        21          28          20970
            // alfa-romero      convertible 88.60       130         111         5000        21          27          13495
            // mercedes-benz    wagon       110.00      183         123         4350        22          25          28248
            // toyota           sedan       95.70       110         56          4500        34          36          7898
            // toyota           sedan       94.50       98          112         6600        26          29          9298
            // plymouth         hatchback   93.70       90          68          5500        37          41          5572
            // mazda            hatchback   93.10       91          68          5000        31          38          6795
            // dodge            hatchback   93.70       98          102         5500        24          30          7957
            // nissan           hatchback   91.30       181         200         5200        17          23          19699
            // mazda            hatchback   95.30       70          101         6000        17          23          13645
            // mitsubishi       sedan       96.30       110         116         5500        23          30          9279
            // mercedes-benz    sedan       115.60      183         123         4350        22          25          31600
            new AutomobileTestData("bmw", "sedan", 101.20f, 108, 101, 5800, 23, 29, 16430),
            new AutomobileTestData("nissan", "wagon", 100.40f, 181, 152, 5200, 17, 22, 14399),
            new AutomobileTestData("dodge", "hatchback", 93.70f, 90, 68, 5500, 31, 38, 6377),
            new AutomobileTestData("bmw", "sedan", 101.20f, 164, 121, 4250, 21, 28, 20970),
            new AutomobileTestData("alfa-romeo", "convertible", 88.60f, 130, 111, 5000, 21, 27, 13495),
            new AutomobileTestData("mercedes-benz", "wagon", 110.00f, 183, 123, 4350, 22, 25, 28248),
            new AutomobileTestData("toyota", "sedan", 95.70f, 110, 56, 4500, 34, 36, 7898),
            new AutomobileTestData("toyota", "sedan", 94.50f, 98, 112, 6600, 26, 29, 9298),
            new AutomobileTestData("plymouth", "hatchback", 93.70f, 90, 68, 5500, 37, 41, 5572),
            new AutomobileTestData("mazda", "hatchback", 93.10f, 91, 68, 5000, 31, 38, 6795),
            new AutomobileTestData("dodge", "hatchback", 93.70f, 98, 102, 5500, 24, 30, 7957),
            new AutomobileTestData("nissan", "hatchback", 91.30f, 181, 200, 5200, 17, 23, 19699),
            new AutomobileTestData("mazda", "hatchback", 95.30f, 70, 101, 6000, 17, 23, 13645),
            new AutomobileTestData("mitsubishi", "sedan", 96.30f, 110, 116, 5500, 23, 30, 9279),
            new AutomobileTestData("mercedes-benz", "sedan", 115.60f, 183, 123, 4350, 22, 25, 31600),
        };
   }
}
