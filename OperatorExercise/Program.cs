namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //OperationExercise1
            //For division, create two integer variables called a and b.

            //var a = 17; //var is inferred and int. is Explicit typing.
            //int b = 4;  //int. is Explicit typing.
            //var name =  //name is a reference type of string.

            var a = 41;
            var b = 17;
            var addition = a + b;   


            //var a = 17;
            //var b = 4;
            //var quotient = a / b;
            //var remainder = a % b;

            Console.WriteLine(a +  "/"  + b + " is " + quotient + " remainder " + remainder);
            // The + symbol is what concanation/pulls everthing together to form the string.
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

        }
    }
}
