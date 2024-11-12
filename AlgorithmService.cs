// AlgorithmService.cs
using System.Collections.Generic;
using System.Linq;

namespace dotnet_fm
{
    public class AlgorithmService
    {
        public double CalculateAverageScore(List<Grade> grades)
        {
            if (grades == null || !grades.Any()) return 0.0;
            return grades.Average(g => g.Score);
        }
    }
}
