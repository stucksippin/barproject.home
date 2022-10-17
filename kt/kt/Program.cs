namespace GenericsPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase<object> database = new DataBase<object>();
            Console.WriteLine("Добро пожаловать в базу данных! \n 1. Добавить элемент \n 2. Вывести список на экран \n 3. Вывести определённые эмементы списка");
            int read;
            do
            {
                int.TryParse(Console.ReadLine(), out read);
                switch (read)
                {
                    case 1:
                        Console.Write("enter the element: ");
                        database.Add(Console.ReadLine());
                        Console.WriteLine("The element is recorded. You can select one of the menu items again:\n 1. Add an element \n 2. Display the list on the screen \n 3. Display certain elements of the list");
                        break;
                    case 2:
                        Console.WriteLine("elements");
                        database.Output();
                        Console.WriteLine("1. Add an element \n 2. Display the list on the screen \n 3. Display certain elements of the list");
                        break;
                    case 3:
                        Console.Write("Enter the required data type:");
                        string datat = Console.ReadLine();
                        switch (datat)
                        {
                            case "int":
                                string i = "System.Int32";
                                database.OutputType(i);
                                break;
                            default:
                                Console.WriteLine("You entered the data type incorrectly");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Select one of the menu items");
                        continue;
                }
            }
            while (true);

            Console.ReadLine();
        }
    }
}