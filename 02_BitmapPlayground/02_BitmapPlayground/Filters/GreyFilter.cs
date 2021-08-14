using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _02_BitmapPlayground.Filters
{
    public class GreyFilter : IFilter
    {
        public async Task<Color[,]> Apply(Color[,] input)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            Color[,] result = new Color[width, height];
            
            for(int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    var p = input[x, y];
                    byte greyscale = (byte)(p.R / 3 + p.G / 3 + p.B / 3);
                    result[x, y] = Color.FromArgb(greyscale, greyscale, greyscale);
                }
            }
            return result;
        }

        public string Name => "Filter grey component";

        public override string ToString()
        => Name;
    }
}
