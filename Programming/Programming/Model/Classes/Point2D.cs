using System;

///<summary>
///Координаты точки. 
///</summary>
public class Point2D
{
    private int _x;
    private int _y;

    ///<summary>
    ///Возвращает и задает координату Х
    ///</summary>
    public int X { get; set; }

    ///<summary>
    ///Возвращает и задает координату У
    ///</summary>
    public int Y {  get; set; }

    ///<summary>
    ///Создает экземпляр точки
    ///</summary>
    ///<param name = "name">Координата Х.</param>
    ///<param name = "name">Координата У.</param>
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