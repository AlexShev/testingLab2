using System.Drawing;

namespace testingLab2;

/// <summary>
/// Интерфейс для классов картинок
/// </summary>
public interface IBitmap
{
    /// <summary>
    /// Ширина изображения
    /// </summary>
    public int Width { get; }


    /// <summary>
    /// Высота изображения
    /// </summary>
    public int Height { get; }


    /// <summary>
    /// Установить значения пикселя
    /// </summary>
    /// <param name="x">Координата по оси OX</param>
    /// <param name="y">Координата по оси OY</param>
    /// <param name="color">Значение цвета</param>
    public void SetPixel(int x, int y, Color color);


    /// <summary>
    /// Получить значения пикселя
    /// </summary>
    /// <param name="x">Координата по оси OX</param>
    /// <param name="y">Координата по оси OY</param>
    public Color GetPixel(int x, int y);
}