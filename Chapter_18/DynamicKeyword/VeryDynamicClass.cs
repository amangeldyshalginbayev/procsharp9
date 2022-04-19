namespace DynamicKeyword
{
    public class VeryDynamicClass
    {
        private static dynamic _myDynamicField;
        public dynamic DynamicProperty { get; set; }
        
        public dynamic DynamicMethod(dynamic dynamicParameter) {
            dynamic dynamicLocalVar = "Local variable";
            int myInt = 10;

            if (dynamicParameter is int)
            {
                return dynamicLocalVar;
            }

            return myInt;
        }
         
    }
}