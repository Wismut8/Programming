public static class CollisionManager
{
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

    //public static bool IsCollision(Ring ring1, Ring ring2)
    //{
    //double distance = Math.Sqrt(Math.Pow(ring1.RingCenter.X - ring2.RingCenter.X, 2) + Math.Pow(ring1.RingCenter.Y - ring2.RingCenter.Y, 2));
    //double sumRadii = ring1.OuterRadius + ring2.OuterRadius;

    //if (distance < sumRadii)
    //{
    //if (distance + ring1.InnerRadius < ring2.OuterRadius || distance + ring2.InnerRadius < ring1.OuterRadius)
    //{
    //return false; // учет коллизии
    //}
    //return true;
    //}
    //return false;
    //}
}