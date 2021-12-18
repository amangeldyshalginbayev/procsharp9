using System;

namespace ProcessMultipleExceptions
{
    public class CarIsDeadException : ApplicationException
    {
        private string _messageDetails = String.Empty;
        public DateTime ErrorTimeSTamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException()
        {
        }

        public CarIsDeadException(DateTime errorTimeSTamp, string causeOfError) : this(string.Empty,causeOfError,errorTimeSTamp)
        {
        }

        public CarIsDeadException(string message, string causeOfError, DateTime errorTimeSTamp) : this(causeOfError,errorTimeSTamp,message,null)
        {
        }

        public CarIsDeadException(string cause, DateTime time, string message, System.Exception inner) : base(message,inner)
        {
            CauseOfError = cause;
            ErrorTimeSTamp = time;
        }

        public override string Message => $"Car Error Message: {_messageDetails}";
    }
}