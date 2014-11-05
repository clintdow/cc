using System;

namespace CC
{
    public class CannotSettleException: Exception
    {
        public CannotSettleException()
        { }
        public CannotSettleException(string message)
        { }
        public CannotSettleException(string message, Exception inner)
        { }
    }

    public enum CannotSettleReasons
    {
        CityExists
    }
}
