namespace OverloadUnaryOperators
{
    /*
     * 
        Syntax
        public static return_type operator op (Type t)
            {
                // TODO:
            }
        • Static operator overloaded method must be static.
        • operator is a keyword used to define an operator overloaded method.
        • op use special operator symbol, describe which operator definition is going to be
        overloaded, i.e., ( +, -, ..).
        • Type where type must be struct or class.
    *
    */

    class Distance
    {
        public int Meters { get; set; }

        public static Distance operator ++(Distance distance)
        {
            distance.Meters++;
            return distance;
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            Distance d = new Distance();
            d++;

            System.Console.WriteLine($"meters of distance are {d.Meters}");
            System.Console.Read();
        }
    }
}
