using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleExercise;

public interface ICirclePicker
{
    Circle? PickMostSimilar(Circle circle, List<Circle> circles);
    List<Circle>? PickSimilar(Circle circle, List<Circle> circles, double differencePercent);
}
