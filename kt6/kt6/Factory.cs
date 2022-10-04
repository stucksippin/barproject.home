namespace kt6
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.CreatePen(50);
            factory.CreatePencil(50);
            factory.ShowCost();
            factory.ShowResources();
            
        }
    }

    class Factory
    {
        int wood = 3000;
        int plastic = 2000;
        List<IForSale> products = new List<IForSale>();
        public void CreatePen(int h)
        {
            for (int i = 0; i < h; i++)
            { Pensil pensil = new Pensil();
            products.Add(pensil);
                wood -= 12;
                plastic -= 20;
            }
        }
        public void CreatePencil(int p)
        {
            for (int i = 0;i < p; i++)
            {
                Pen pen = new Pen();
                products.Add(pen);
                wood -= 30;
            }
        }
        public void ShowResources()
        {
            Console.WriteLine($"Затрачено дерева:{wood}  Затрачено пластика:{plastic}");
        }
        public void ShowCost()
        {
            var m = 0;
            foreach (var s in products)
            {
                m += s.Sale();
            }
            Console.WriteLine(m);
        }


    }

    public class Pen : IForSale
    {
     public int Sale()
        {
            Random random = new Random();   
            int c = random.Next(3,5);
            return c;
        }
    }
   internal class Pensil : IForSale
    {
     
        public int Sale()
        {
            int a = 10;
            return a;
        }
    }
}
