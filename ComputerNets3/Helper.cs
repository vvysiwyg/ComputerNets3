using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace ComputerNets3
{
    public static class Helper
    {
        public static double GenerateUniformDistribution() => ContinuousUniform.Sample(-50, 50);

        public static double GenerateGaussDistribution()
        {
            double sample = Normal.Sample(0, 25);

            if (Math.Abs(sample) <= 50)
                return sample;

            return GenerateGaussDistribution();
        }
    }
}
