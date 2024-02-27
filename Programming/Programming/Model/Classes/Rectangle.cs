using System;
///<summary>
///Прямоугольник. 
///</summary>
public class Rectangle
{
	private double _height;
	private double _width;
	private string _color;

    ///<summary>
    ///Возвращает и задает длину прямоугольника
    ///</summary>
    private double Height
    {
        get
        {
            return _height;
        }
        set
        {
            if (value < 0.0)
            {
                throw new ArgumentException();
            }
            _height = value;
        }
    }

    ///<summary>
    ///Возвращает и задает ширину прямоугольника
    ///</summary>
    private double Width
    {
        get
        {
            return _width;
        }
        set
        {
            if (value < 0.0)
            {
                throw new ArgumentException();
            }
            _width = value;
        }
    }

    ///<summary>
    ///Возвращает и задает цвет прямоугольника
    ///</summary>
    private string Color { get; set; }

	///<summary>
	///Создает экземпляр прямоугольника
	///</summary>
	///<param name = "name">Длина.</param>
	///<param name = "name">Ширина.</param>
	///<param name = "name">Цвет.</param>
	public Rectangle(double height, double width, string color)
	{
		Height = height;
		Width = width;
		Color = color;
	}
}