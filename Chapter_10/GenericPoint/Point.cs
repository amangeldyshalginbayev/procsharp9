namespace GenericPoint
{
    public struct Point<T>
    {
        private T _xPos;
        private T _yPos;

        public Point(T xPos, T yPos)
        {
            _xPos = xPos;
            _yPos = yPos;
        }

        public T XPos
        {
            get => _xPos;
            set => _xPos = value;
        }

        public T YPos
        {
            get => _yPos;
            set => _yPos = value;
        }

        public override string ToString() => $"[{_xPos}, {_yPos}]";

        public void ResetPoint()
        {
            // _xPos = default(T);
            // _yPos = default(T);
            _xPos = default;
            _yPos = default;
        }
    }
}