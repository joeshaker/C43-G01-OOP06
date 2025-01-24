using AssOOP6.Q1;
using AssOOP6.Q2.Class;
using AssOOP6.Q3.Abstract;
using AssOOP6.Q3.Concrete_Classes;

namespace AssOOP6
{
    internal class Program
    {
        #region Q1Function
        //static public _3DPoints[] Sort(_3DPoints[] arr)
        //{
        //    _3DPoints Result ;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = i+1; arr.Length > j; j++)
        //        {
        //            if (arr[i].X > arr[j].X)
        //            {
        //                Result = arr[j];
        //                arr[j] = arr[i];
        //                arr[i] = Result;
        //            }
        //            else if (arr[i].X == arr[j].X)
        //            {
        //                if (arr[i].Y > arr[j].Y)
        //                {
        //                    Result = arr[j];
        //                    arr[j] = arr[i];
        //                    arr[i] = Result;
        //                }

        //            }
        //        }

        //    }
        //    return arr;
        //} 
        #endregion
        static void Main(string[] args)
        {

            #region Project1
            //_3DPoints p1 = new _3DPoints(10,10,10);
            //Console.WriteLine(p1.ToString());
            //int num;
            //bool isParsed;
            //Console.WriteLine("Enter the Coordinates of the Point:");
            //_3DPoints point = new _3DPoints();
            //Console.WriteLine("Enter the Coordinate of X :");
            //point.X = int.Parse(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine("Enter the Coordinate of X :");
            //    isParsed = int.TryParse(Console.ReadLine(), out num);
            //} while (!isParsed);
            //{
            //    point.X = num;
            //}

            //Console.WriteLine("Enter the Coordinate of Y :");
            //do
            //{
            //    Console.WriteLine("Enter the Coordinate of Y :");
            //    isParsed = int.TryParse(Console.ReadLine(), out num);
            //} while (!isParsed);
            //{
            //    point.Y = num;
            //}
            //point.Y =int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Coordinate of Z :");
            //do
            //{
            //    Console.WriteLine("Enter the Coordinate of Z :");
            //    isParsed = int.TryParse(Console.ReadLine(), out num);
            //} while (!isParsed);
            //{
            //    point.Z = num;
            //}
            //point.Z =int.Parse(Console.ReadLine());
            //Console.WriteLine(point.ToString());

            //_3DPoints p1=new _3DPoints(1,2,3);
            //_3DPoints p2=new _3DPoints(1,2,3);
            //if (p1 == p2)
            //{
            //    Console.WriteLine("Equal");
            //}
            //else {

            //    Console.WriteLine("Not Equal");
            //}
            // not working properly because it give non equal

            //_3DPoints[] Arr = new _3DPoints[] {
            //new _3DPoints(1,2,3),
            //new _3DPoints(2,4,3),
            //new _3DPoints(2,2,6),
            //new _3DPoints(4,6,5),
            //new _3DPoints(3,6,4),
            //new _3DPoints(3,5,4),
            //};
            //_3DPoints[] Result = Sort(Arr);
            //foreach (_3DPoints p in Result) {

            //    Console.WriteLine(p.ToString());
            //}
            //_3DPoints p1= new _3DPoints(1,2,3);
            //_3DPoints p2= new _3DPoints(4,2,3);
            //Console.WriteLine($"GetHash:{p1.GetHashCode()}"); 
            //Console.WriteLine($"GetHash:{p2.GetHashCode()}"); 
            //p2 = (_3DPoints)p1.Clone();
            //Console.WriteLine("After Clone");
            //Console.WriteLine($"GetHash:{p1.GetHashCode()}");
            //Console.WriteLine($"GetHash:{p2.GetHashCode()}");
            //Console.WriteLine(p1.ToString() ); 
            //Console.WriteLine(p2.ToString() ); 
            #endregion
            #region Project2
            //Console.WriteLine(Maths.Add(1, 2));
            //Console.WriteLine(Maths.Multiply(2, 3));
            //Console.WriteLine(Maths.Divide(2,0 ));
            //Console.WriteLine(Maths.Divide(0,2 ));
            //Console.WriteLine(Maths.Subtract(3, 0)); 
            #endregion
            #region Project3 
            //Console.WriteLine("Welcome to our E-commerce");
            //Console.WriteLine("Please enter your user type (Regular, Premium, Guest):");
            //string userType = Console.ReadLine();
            //userType.ToUpper();

            //User user;

            //if (userType == "Regular")
            //{
            //    user = new RegularUser();
            //}
            //else if (userType == "Premium")
            //{
            //    user = new PremiumUser();
            //}
            //else if (userType == "Guest")
            //{
            //    user = new GuestUser();
            //}
            //else
            //{
            //    Console.WriteLine("INVALID TYPE OF USER");
            //    return;
            //}

            //decimal price;
            //int quantity;
            //bool isParsed;

            //do
            //{
            //    Console.WriteLine("Please enter the price of the product:");
            //    isParsed = decimal.TryParse(Console.ReadLine(), out price);
            //} while (!isParsed);

            //do
            //{
            //    Console.WriteLine("Please enter the quantity of the product:");
            //    isParsed = int.TryParse(Console.ReadLine(), out quantity);
            //} while (!isParsed);

            //Discount discount = user.GetDiscount();
            //if (discount == null)
            //{
            //    Console.WriteLine("No discount applied for Guest users.");
            //    Console.WriteLine($"Final Price: {price * quantity:C2}");
            //}
            //else
            //{
            //    decimal discountAmount = discount.CalculateDiscount(price, quantity);
            //    decimal finalPrice = (price * quantity) - discountAmount;
            //    Console.WriteLine($"Discount Applied: {discount.type}");
            //    Console.WriteLine($"Total Discount: {discountAmount:C2}");
            //    Console.WriteLine($"Final Price: {finalPrice:C2}");
            //} 
            #endregion

        }

    }
}
