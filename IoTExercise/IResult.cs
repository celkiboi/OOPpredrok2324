using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTExercise;

public interface IResult
{
    DateTime ResultTimestamp { get; }

    string StringRepresentation { get; }
}
