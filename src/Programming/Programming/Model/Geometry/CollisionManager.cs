/// <summary>
/// Осуществляет проверку на коллизию объектов.
/// </summary>
public static class CollisionManager
{
    /// <summary>
    /// Осуществляет проверку коллизии прямоугольников.
    /// </summary>
    /// <param name="rectangle1">Первый проверяемый прямоугольник.</param>
    /// <param name="rectangle2">Второй проверяемый прямоугольник.</param>
    /// <returns>Возвращает true, если прямоугольники пересекаются и false, если прямоугольники не пересекаются.</returns>
    public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        bool result = false;

        //Расстояние между координатами.
        int differenceX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
        int differenceY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

        //Сумма значений.
        Double wideSumm = (rectangle1.Width + rectangle2.Width) / 2;
        Double lengthSum = (rectangle1.Height + rectangle2.Height) / 2;

        //Проверка на пересечение.
        if (differenceX < wideSumm && differenceY < lengthSum)
        {
            result = true;
        }
        return result;
    }

    /// <summary>
    /// Осуществляет проверку коллизии колец.
    /// </summary>
    /// <param name="ring1">Первое проверяемое кольцо.</param>
    /// <param name="ring2">Второе проверяемое кольцо.</param>
    /// <returns>Возвращает true, если кольца пересекаются и false, если кольца не пересекаются или меньшее кольцо полностью находится внутри большего кольца.</returns>
    public static bool IsCollision(Ring ring1, Ring ring2)
    {
        double distance = Math.Sqrt(Math.Pow(ring1.RingCenter.X - ring2.RingCenter.X, 2) + Math.Pow(ring1.RingCenter.Y - ring2.RingCenter.Y, 2));
        double sumRadii = ring1.OuterRadius + ring2.OuterRadius;

        if (distance < sumRadii)
        {
            if (distance + ring1.InnerRadius < ring2.OuterRadius || distance + ring2.InnerRadius < ring1.OuterRadius)
            {
                // учет коллизии
                return false; 
            }
            return true;
        }
    return false;
    }
}