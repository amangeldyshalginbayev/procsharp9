using System;

namespace FunWithValueAndReferenceTypes
{
    public struct Rectangle
    {
        public ShapeInfo RectInfo;

        public int RectTop, RectLeft, RectBottom, RectRight;

        public Rectangle(string info, int rectTop, int rectLeft, int rectBottom, int rectRight) : this()
        {
            RectInfo = new ShapeInfo(info);
            RectTop = rectTop;
            RectLeft = rectLeft;
            RectBottom = rectBottom;
            RectRight = rectRight;
        }

        public void Display()
        {
            Console.WriteLine($"String = {RectInfo.InfoString}, Top = {RectTop}, Bottom = {RectBottom}, Left = {RectLeft}, Right = {RectRight}");
        }
    }
}