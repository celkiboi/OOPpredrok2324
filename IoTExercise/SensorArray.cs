using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IoTExercise;

public class SensorArray
{
    readonly IotSensor[][] sensors;

    public SensorArray(int verticalAmount, int horizontalAmount)
    {
        sensors = new IotSensor[verticalAmount][];
        for (int i = 0; i < verticalAmount; i++)
        {
            sensors[i] = new IotSensor[horizontalAmount];
        }
    }

    public IotSensor this[int indexI, int indexJ]
    {
        set { sensors[indexI][indexJ] = value; }
    }

    public double CalculateTimeLeftInSeconds()
    {
        double minTimeLeft = sensors[0][0].CalculateTimeLeftInSeconds();

        foreach (IotSensor[] sensorRow in sensors) 
        {
            foreach (IotSensor sensor in sensorRow) 
            {
                double timeLeft = sensor.CalculateTimeLeftInSeconds();

                if (timeLeft == 0)
                    throw new SensorFailException();

                if (timeLeft < minTimeLeft)
                    minTimeLeft = timeLeft;
            }
        }

        return minTimeLeft;
    }
}
