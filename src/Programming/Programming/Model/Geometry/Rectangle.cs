using System;
///<summary>
/// Хранит данные о прямоугольнике. 
///</summary>
public class Rectangle
{
    /// <summary>
    /// Хранит количество созданных экземпляров прямоугольников.
    /// </summary>
    private static int _allRectanglesCount = 0;
    /// <summary>
    /// Хранит id прямоугольника.
    /// </summary>
    private readonly int _id;
    /// <summary>
    /// Хранит точку центра прямоугольника.
    /// </summary>
    private Point2D _center;
    /// <summary>
    /// Хранит длину прямоугольника.
    /// </summary>
    private int _height;
    /// <summary>
    /// Хранит ширину прямоугольника.
    /// </summary>
	private int _width;

    /// <summary>
    /// Возвращает id прямоугольника.
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// Возвращает количество созданных экземпляров прямоугольников.
    /// </summary>
    /// <returns>Количество прямоугольников.</returns>
    public static int AllRectanglesCount()
    {
        return _allRectanglesCount;
    }

    ///<summary>
    ///Возвращает и задает координаты центра прямоугольника.
    ///</summary>
    public Point2D RectangleCenter { get; set; }

    ///<summary>
    ///Возвращает и задает длину прямоугольника. Только положительное значение.
    ///</summary>
    public int Height
    {
        get
        {
            return _height;
        }
        set
        {
            if (Validator.AssertOnPositiveValue(value))
            {
                _height = value;
            }
        }
    }

    ///<summary>
    ///Возвращает и задает ширину прямоугольника. Только положительное значение.
    ///</summary>
    public int Width
    {
        get
        {
            return _width;
        }
        set
        {
            if (Validator.AssertOnPositiveValue(value))
            {
               _width = value;
            }
        }
    }


    ///<summary>
    ///Возвращает и задает координаты центра прямоугольника.
    ///</summary>
    public Point2D Center { get; set; }

    ///<summary>
    ///Создает экземпляр прямоугольника. <see cref="Rectangle"/>
    ///</summary>
    ///<param name = "height">Длина. Только положительное значение.</param>
    ///<param name = "width">Ширина. Только положительное значение.</param>
    ///<param name = "center">Цвет.</param>
    public Rectangle(int height, int width, Point2D center)
	{
		Height = height;
		Width = width;
        Center = center;
        _allRectanglesCount++;
        _id = _allRectanglesCount;
    }

    public Rectangle() { }
}