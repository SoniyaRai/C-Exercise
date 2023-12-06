


namespace ApplicationDevelop_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Exc1
            Car obj = new Car("Honda", 2020, 10000.00f);
            obj.printCarDetails();


            //Exc2
            BankAccount accountObj = new BankAccount("565476585", 0);
            accountObj.Deposit(1000);
            accountObj.Withdraw(500);
            accountObj.finalBalance();


            //Exc3
            Rectangle rectObj = new Rectangle(5, 10);
            rectObj.CalcualteArea();

       
            //Exc4
            Circle areaObj = new Circle(8);
            areaObj.CalculateArea();

            //Exc5
            Student studentObj = new Student("John Doe", 20, "Computer Science");
            studentObj.Introduce();

       
            //Exc6
            Stack<int> stackObj = new Stack<int>();
            stackObj.Push(2);
            stackObj.Push(3);
            stackObj.Push(4);
            stackObj.Pop();
            stackObj.Peek();
            stackObj.isEmpty();

        
            //Exc7
            Calendar calendar = new Calendar();
            calendar.PrintWeekdays();

            

            //Exc8
            Point2D pointA = new Point2D { X = 2.0f, Y = 5.0f };
            Point2D pointB = new Point2D { X = 4.0f, Y = 3.0f };

            float distance = DistanceCalculator.CalculateDistance(pointA, pointB);
            Console.WriteLine($"Distance between Point A and Point B: {distance}");


        }
    }
}