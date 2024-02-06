using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleExercise;

public class CircleDrawer(ICirclePicker circlePicker, Circle pickedCircle , List<Circle> circles)
{
    public ICirclePicker CirclePicker { get; set; } = circlePicker;
    public Circle PickedCircle { get; set; } = pickedCircle;
    readonly List<Circle> Circles = new(circles);


    public double CalculatePickedArea(double differencePercent)
    {
        /* Ovo ?? [] nije potrebno da program radi, 
         * samo ne volim warninge od compilera, 
         * vidi null coalescing operators  ako te zanima 
         * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator */
        List<Circle> pickedCircles = CirclePicker.PickSimilar(PickedCircle, Circles, differencePercent) ?? []; 
        double area = 0;

        foreach (Circle circle in pickedCircles)
        {
            area += circle.Radius * 2 * Math.PI;
        }

        return area;
    }
}
