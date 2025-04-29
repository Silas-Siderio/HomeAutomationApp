using Microsoft.ML;
using Microsoft.ML.Data;
using System;

namespace HomeAutomationApp.Services
{
    public class MLService
    {
        private readonly MLContext _mlContext;
        private PredictionEngine<SensorData, SensorPrediction> _predictionEngine;

        public MLService()
        {
            _mlContext = new MLContext();
            LoadModel();
        }

        private void LoadModel()
        {
            DataViewSchema modelSchema;
            var model = _mlContext.Model.Load("model.zip", out modelSchema);
            _predictionEngine = _mlContext.Model.CreatePredictionEngine<SensorData, SensorPrediction>(model);
        }

        public bool PredictMovement(SensorData input)
        {
            var prediction = _predictionEngine.Predict(input);
            return prediction.PredictedLabel;
        }
    }

    public class SensorData
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float MotionDetected { get; set; }
    }

    public class SensorPrediction
    {
        [ColumnName("PredictedLabel")]
        public bool PredictedLabel { get; set; }
    }
}