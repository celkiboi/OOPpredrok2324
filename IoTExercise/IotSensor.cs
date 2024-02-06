namespace IoTExercise;

public abstract class IotSensor
{
    protected int samplingRateHz;
    protected double batteryPercent;
    protected double samplePowerDraw;

    protected IotSensor(int samplingRateHz, double batteryPercent, double samplePowerDraw)
    {
        if (samplingRateHz <= 0)
            throw new ArgumentException("Invalid argument for sampling rate (needs to be > 0)");
        if (batteryPercent < 0 || batteryPercent > 100)
            throw new ArgumentException("Invalid argument for battery percentage (needs to be 0 <= x <= 100)");

        this.samplingRateHz = samplingRateHz;
        this.batteryPercent = batteryPercent;
        this.samplePowerDraw = samplePowerDraw;
    }

    public double CalculateTimeLeftInSeconds()
    {
        int completedSamples = 0;
        double batteryPercent = this.batteryPercent;

        while(batteryPercent > samplePowerDraw) 
        {
            completedSamples++;
            batteryPercent -= samplePowerDraw;
        }

        double timePerSample = 1 / samplingRateHz;
        return  timePerSample * completedSamples;
    }

    public int CalculateNumberOfSamples(double timeInSeconds)
    {
        int completedSamples = 0;
        double batteryPercent = this.batteryPercent;
        double timePerSample = 1 / samplingRateHz;

        while(timeInSeconds > 0 && batteryPercent > samplePowerDraw) 
        { 
            completedSamples++;
            batteryPercent -= samplePowerDraw;
            timeInSeconds -= timePerSample;
        }

        return completedSamples;
    }

    public abstract IEnumerable<IResult> Measure(TimeSpan timeFrame);
}
