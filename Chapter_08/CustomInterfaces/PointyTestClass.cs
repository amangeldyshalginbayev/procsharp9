using System;

namespace CustomInterfaces
{
    public class PointyTestClass : IPointy
    {
        public byte Points => throw new NotImplementedException();
        
    }
}