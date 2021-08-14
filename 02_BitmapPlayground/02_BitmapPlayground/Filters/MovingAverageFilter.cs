using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _02_BitmapPlayground.Filters
{
    public class MovingAverageFilter : IFilter
    {
        public async Task<Color[,]> Apply(Color[,] input)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            Color[,] result = new Color[width, height];
            int averageR =0;
            int averageG = 0;
            int averageB = 0;
            int totl = 0;
            
            for(int x = 4; x < width-4; x++)
            {
                for(int y = 4; y < height-4; y++)
                {
                    var p = input[x, y];
                    averageR += p.R;
                    averageG += p.G;
                    averageB += p.B;
                    totl = totl + 1;
                    result[x, y] = Color.FromArgb(averageR / totl, averageG / totl, averageB / totl);
                    if(totl==2)
                    {
                        averageR = 0;
                        averageG = 0;
                        averageB = 0;
                        totl = 0;
                    }
                }
            }
            return result;
        }

        public string Name => "Moving average filter";

        public override string ToString()
        => Name;
    }
}
