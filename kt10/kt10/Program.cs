namespace paramsToFunc
{
    class Point
    {
        public int x;
        public int y;
        public Point()
        {
            Console.Write("Введите координату х: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату у: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Geometry
    {

        public void Distance(in Point point, in Point point2)
        {
            var dist = Math.Sqrt((point2.y - point.y) ^ 2 + (point2.x - point.x) ^ 2);
            Console.WriteLine(dist);
        }
        public void ChangePoint(ref Point point, ref Point point2)
        {
            Console.WriteLine("Какой элемент вы хотите изменить? \nВведите x1 - если ширину 1 точки; \nВведите у1 - высоту второй точки; \nВведите x2 - если ширину 2 точки; \nВведите у2 - высоту второй точки;");
            string par = Console.ReadLine();
            switch (par)
            {
                case "x1":
                    Console.Write("Введите новое значение точки: ");
                    int.TryParse(Console.ReadLine(), out point.x);
                    break;
                case "y1":
                    int.TryParse(Console.ReadLine(), out point.y);
                    break;
                case "x2":
                    int.TryParse(Console.ReadLine(), out point2.x);
                    break;
                case "y2":
                    int.TryParse(Console.ReadLine(), out point2.y);
                    break;
                case null:
                    par = String.Empty;
                    break;
                default:
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            Point point2 = new Point();
            Geometry geometry = new Geometry();
            geometry.Distance(in point, in point2);
            geometry.ChangePoint(ref point, ref point2);
            geometry.Distance(in point, in point2);
        }
    }
}