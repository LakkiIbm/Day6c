using System;
//--------------------------Null reference exception----------------------------
//namespace Day6c
//{

//    class exceptions
//    {
//        static void Main(string[] args)
//        {
//            string str = null;
//            try
//            {
//                Console.WriteLine(str.Substring(5));
//            }
//            catch (NullReferenceException err)
//            {
//                Console.WriteLine("Please check the string str.");
//                Console.WriteLine(err.Message);
//            }
//            Console.WriteLine("Continuing with other statments..");
//        }
//    }
//}


//---------------------Invalid cast exceptions------------------------------------------------
//namespace Day6c
//{

//    class exceptions
//    {
//        static void Main(string[] args)
//        {
//            bool s = false;
//            try
//            {
//                Console.WriteLine(Convert.ToChar(s));
//            }
//            catch (InvalidCastException err)
//            {
//                Console.WriteLine("Please check the string str.");
//                Console.WriteLine(err.Message);
//            }
//            Console.WriteLine("Continuing with other statments..");
//        }
//    }
//}



//-----------------------index out of range exception------------------------------------
namespace Demo
{
    class MyArray
    {
        static void Main(string[] args)
        {
            try
            {
                int[] n = new int[5] { 66, 33, 56, 23, 81 };
                int i, j;
                
                for (j = 0; j < 10; j++)
                {
                    Console.WriteLine("Element[{0}] = {1}", j, n[j]);
                }
                Console.ReadKey();
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
