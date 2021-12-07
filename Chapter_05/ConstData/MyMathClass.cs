namespace ConstData
{
    public class MyMathClass
    {
        public const double PI = 3.14;

        public readonly double READ_ONLY_PI;

        public static readonly double STATIC_READ_ONLY_PI = 3.14;

        public MyMathClass()
        {
            // const can be set only during declaration
            //PI = 3.1444;
            
            // read only can be set during declaration and in ctor
            READ_ONLY_PI = 3.1444;

            // error! can change only in static ctor!
            //STATIC_READ_ONLY_PI = 3.14444444;
        }

        public void ChangeReadOnlyPI()
        {
            // error! can not change outside ctor!
            //READ_ONLY_PI = 3.14444444;
        }

        static MyMathClass()
        {
            // static read only can be set during declaration and inside static ctor
            STATIC_READ_ONLY_PI = 3.144444444;
        }
    }
}