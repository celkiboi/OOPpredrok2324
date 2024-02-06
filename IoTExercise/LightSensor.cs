using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Ovo ne treba pisati, ova klasa postoji samo kako bi se kod kompajlirao, odnosno kako bi mogli napraviti testnu funkciju u zadatku 7
*/

namespace IoTExercise;

public class LightSensor(int samplingRateHz, double batteryPercent, double samplePowerDraw) : IotSensor(samplingRateHz, batteryPercent, samplePowerDraw)
{
    public override IEnumerable<IResult> Measure(TimeSpan timeFrame)
    {
        throw new NotImplementedException();
    }
}
