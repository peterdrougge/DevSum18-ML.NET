using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomobilePricePredictor.Models
{
    public class AutomobileData
    {
        [Column(ordinal: "0")]
        public string symboling;
        [Column(ordinal: "1")]
        public float normalizedLosses;
        [Column(ordinal: "2")]
        public string make;
        [Column(ordinal: "3")]
        public string fuelType;
        [Column(ordinal: "4")]
        public string aspiration;
        [Column(ordinal: "5")]
        public float numOfDoors;
        [Column(ordinal: "6")]
        public string bodyStyle;
        [Column(ordinal: "7")]
        public string driveWheels;
        [Column(ordinal: "8")]
        public string engineLocation;
        [Column(ordinal: "9")]
        public float wheelBase;
        [Column(ordinal: "10")]
        public float length;
        [Column(ordinal: "11")]
        public float width;
        [Column(ordinal: "12")]
        public float height;
        [Column(ordinal: "13")]
        public float curbHeight;
        [Column(ordinal: "14")]
        public float engineType;
        [Column(ordinal: "15")]
        public string numOfCylinders;
        [Column(ordinal: "16")]
        public float engineSize;
        [Column(ordinal: "17")]
        public string fuelSystem;
        [Column(ordinal: "18")]
        public float bore;
        [Column(ordinal: "19")]
        public float stroke;
        [Column(ordinal: "20")]
        public float compressionRatio;
        [Column(ordinal: "21")]
        public float horsepower;
        [Column(ordinal: "22")]
        public float peakRpm;
        [Column(ordinal: "23")]
        public float cityMpg;
        [Column(ordinal: "24")]
        public float highwayMpg;
        [Column(ordinal: "25")]
        public float price;
    }
}
