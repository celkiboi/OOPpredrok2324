using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleExercise;

public static class RandomExtensions
{
    public static Circle NextCircle(this Random random, double maxRadius)
    {
        double randomValue = 1.0 + (random.NextDouble() * (maxRadius));

        return new(0, 0, randomValue);
    }
}
