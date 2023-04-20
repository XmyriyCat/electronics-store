namespace ResultObject.Exceptions;

public class ResultNullValueException : Exception
{
    public ResultNullValueException(string message) : base(message)
    {
    }
}