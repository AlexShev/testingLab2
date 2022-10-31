using System.Drawing;

namespace testingLab2;

public class AlgorithmB
{
    private static readonly Point[] pixelZigns = new Point[]
    {
            new Point(1, 1),   // ( x, y), ( y, x)
            new Point(-1, 1),  // (-x, y), (-y, x)
            new Point(-1, -1), // (-x,-y), (-y,-x)
            new Point(1, -1),  // ( x,-y), ( y,-x)
    };

    private static readonly double[] SupportAngles = new double[]
    {
        Math.PI / 4,
        3*  Math.PI / 4,
        5 * Math.PI / 4,
        7 * Math.PI / 4,
    };

    // public AlgorithmInspector? AlgorithmExpector { get; set; }

    public void FillCircle(IBitmap bitmap, Color color, Point center, int R)
    {
        int x = R, y = 0;
        int d = 3 - 2 * R;

        while (y <= x)
        {
            // Console.WriteLine($"{x} {y}");
            draw_pixels(bitmap, color, center.X - x, center.X + x, center.Y + y);
            draw_pixels(bitmap, color, center.X - x, center.X + x, center.Y - y);
            
            // Thread.Sleep(10);

            draw_pixels(bitmap, color, center.X - y, center.X + y, center.Y + x);
            draw_pixels(bitmap, color, center.X - y, center.X + y, center.Y - x);

            if (d <= 0)
            {
                d += 4 * y + 6;
                ++y;
            }
            else
            {
                d += 4 * (y - x) + 10;
                --x;
                ++y;
            }

            // Thread.Sleep(10);
        }
    }

    void draw_pixels(IBitmap bitmap, Color color, int x1, int x2, int y)
    {
        for (int x = x1; x <= x2; x++)
        {
            // AlgorithmExpector?.IncrimentPixelCounter();
            bitmap.SetPixel(x, y, color);
        }
    }
}
