using TMSLesson8.Struct;

namespace TMSLesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape
            var shape1 = new Triangle() { SideA = 10, SideB = 20, SideC = 10 };
            var shape2 = new Triangle() { SideA = 10, SideB = 20, SideC = 10 };
            var shape3 = new Rectangle() { SideA = 10, SideB = 20 };
            var shape4 = new Circle() { Radius = 2.9 };
            var shape5 = new Circle() { Radius = 52 };

            Shape[] shapes = { shape1, shape2, shape3, shape4, shape5 };

            double sumPerimeter = 0;

            foreach (Shape shape in shapes)
            {
                sumPerimeter += shape.GetPerimeter();
            }

            Console.WriteLine($"Сумма периметра пяти фигур: {sumPerimeter:F3}\n");

            //JobTitle
            var director = new Director();
            director.ShowTitle();

            var accountant = new Accountant();
            accountant.ShowTitle();

            var worker = new Worker();
            worker.ShowTitle();

            //Register
            Console.WriteLine();

            var register = new Register();

            var document1 = new SupplyContract() { Number = "SC000001", Date = new DateTime(2023, 02, 23), ProductTypeId = 2, ProductCount = 204 };
            register.Save(document1);
            register.GetInformation(document1);

            var document2 = new EmployeeContract() { Number = "EC000001", Date = new DateTime(2023, 02, 23), EmployeeName = "Иванов Иван Иванович", EndDate = new DateTime(2026, 01, 31) };
            register.Save(document2);
            register.GetInformation(document2);

            var document3 = new FinancialInvoice() { Number = "FI000001", Date = new DateTime(2023, 02, 23), DepartmentCode = 1342, Sum = 1586.365M };
            register.Save(document3);
            register.GetInformation(document3);

            //Enum
            foreach (var day in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();

            //Struct
            var user = new UserInfo() 
            { 
                Name = "Валера", 
                Surname = "Пряников", 
                Login = "pryanikov", 
                Address = "г.Минск, пр.Независимости, 177", 
                Age = 44, 
                Password = "pass" 
            };

            Console.WriteLine("Информация о пользователе");
            Console.WriteLine($"Имя: {user.Name}");
            Console.WriteLine($"Фамилия: {user.Surname}");
            Console.WriteLine($"Возраст: {user.Age}");
            Console.WriteLine($"Адрес: {user.Address}");
            Console.WriteLine($"Логин: {user.Login}");
            Console.WriteLine($"Пароль: {user.Password}");
        }
    }
}
