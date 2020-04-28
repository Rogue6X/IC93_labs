using System;
using System.IO;

namespace ooplab6
{
    class Program
    {

        static void Main()
        {
            try
            {
                //Vars vars = new Vars(5, 0, 6, 1);
                Vars vars = new Vars(2, 5, 23, -3);
                Console.WriteLine(vars.Calc());
            }

            catch (DivideByZeroException err)
            {
                Vars.log($"Exception: {err.GetType()}, time: {DateTime.Now}");
            }
            catch (InvalidDataException err)
            {
                Vars.log($"Exception: {err.GetType()}, time: {DateTime.Now}");
            }

            finally
            {
                Console.WriteLine("End");
            }
        }
    }
}