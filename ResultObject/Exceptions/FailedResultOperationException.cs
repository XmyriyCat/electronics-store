namespace ResultObject.Exceptions;

public class FailedResultOperationException : Exception
{
    public FailedResultOperationException(string message) : base(message)
    {
    }
}