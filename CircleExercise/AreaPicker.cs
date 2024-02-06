using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleExercise;

public class AreaPicker : ICirclePicker
{
    public Circle? PickMostSimilar(Circle circle, List<Circle> circles)
    {
        return circles.MinBy(x => Math.Abs(CalculateArea(x) - CalculateArea(circle)));
    }

    public List<Circle> PickSimilar(Circle circle, List<Circle> circles, double differencePercent)
    {
        return circles.Where(x => CalculatePercentageDifference(x, circle) <= differencePercent).ToList();
    }

    static double CalculatePercentageDifference(Circle leftSide, Circle rightSide) 
    {
        double leftArea = CalculateArea(leftSide);
        double rightArea = CalculateArea(rightSide);

        return Math.Abs((leftArea - rightArea) / leftArea) * 100;
    }

    static double CalculateArea(Circle circle) 
    {
        return 2 * circle.Radius * Math.PI;
    }
}
