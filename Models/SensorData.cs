public class SensorData
{
    public float Temperature { get; set; }
    public float Humidity { get; set; }
    public float MotionDetected { get; set; }
    public float HourOfDay { get; set; } // NOVO campo
}

public class SensorPrediction
{
    [ColumnName("PredictedLabel")]
    public bool PredictedLabel { get; set; }
}
