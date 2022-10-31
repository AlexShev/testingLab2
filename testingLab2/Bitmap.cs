using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingLab2;

public class Bitmap : IBitmap
{
    private Color[][] _map;

    public Bitmap(int height, int wight)
    {
        _map = new Color[height][];

        Width = wight;
        Height = height;

        for (int i = 0; i < height; i++)
        {
            Console.WriteLine($"Выделение памяти {i}");
            _map[i] = new Color[wight];
        }
    }

    public Bitmap(Bitmap bitmap)
    {
        Width = bitmap.Width;
        Height = bitmap.Height;

        _map = new Color[Height][];

        for (int i = 0; i < Height; i++)
        {
            _map[i] = new Color[Width];
        }

        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                _map[x][y] = bitmap._map[x][y];
            }
        }
    }

    public int Width { get; private set; }

    public int Height { get; private set; }

    public Color GetPixel(int x, int y)
    {
        return _map[x][y];
    }

    public void SetPixel(int x, int y, Color color)
    {
        if (IsCorrectPixel(x, y))
        {
            Math.Atan((double) x / y);
            // _map[x][y] = color;

            // new Bitmap(this);
        }
    }

    /// <summary>
    /// Проверить пиксель на принадлежность обоасти
    /// </summary>
    /// <param name="point">Рассматриваемая точка</param>
    private bool IsCorrectPixel(int x, int y)
    {
        return x > -1 && y > -1 && x < Width && y < Height;
    }
}
