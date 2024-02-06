using System.Runtime.Serialization;

namespace IoTExercise
{
    [Serializable]
    public class SensorFailException : Exception
    {
        public SensorFailException() : base("Sensor has already failed!")
        { }
    }
}