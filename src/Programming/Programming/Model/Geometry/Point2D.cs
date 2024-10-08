using System;

///<summary>
/// Хранит координаты точки в декартовой системе координат. 
///</summary>
public class Point2D
{
    /// <summary>
    /// Хранит координату Х.
    /// </summary>
    private int _x;
    /// <summary>
    /// Хранит координату У.
    /// </summary>
    private int _y;

    ///<summary>
    ///Возвращает и задает координату Х.
    ///</summary>
    public int X { get; set; }

    ///<summary>
    ///Возвращает и задает координату У.
    ///</summary>
    public int Y {  get; set; }

    ///<summary>
    ///Создает экземпляр точки. <see cref="Point2D"/>
    ///</summary>
    ///<param name = "x">Координата Х. Только положительное значение.</param>
    ///<param name = "y">Координата У. Только положительное значение.</param>
    public Point2D(int x, int y)
    {
        if (x < 0 || y < 0)
        {
            throw new ArgumentException("Coordinates must be non-negative");
        }

        X = x;
        Y = y;
    }
}