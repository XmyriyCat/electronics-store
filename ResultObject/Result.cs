using System.Reflection.Metadata.Ecma335;
using ResultObject.Exceptions;

namespace ResultObject;

public class Result
{
    public bool IsSuccess => !IsFailed;

    public bool IsFailed => Exceptions.Count > 0;

    public List<Exception> Exceptions { get; } = new();

    public Result()
    {
    }

    public Result(Exception exception)
    {
        Exceptions.Add(exception);
    }

    public void AppendException(Exception exception)
    {
        Exceptions.Add(exception);
    }
}

public class Result<T> : Result
{
    private T _value;

    public T ValueOrDefault
    {
        get => _value;
        set => _value = value;
    }

    public T Value
    {
        get
        {
            if (IsFailed)
            {
                throw new FailedResultOperationException("Result operation is failed");
            }

            if (_value is null)
            {
                throw new ResultNullValueException("Result value is null");
            }

            return _value;
        }
    }

    public static implicit operator Result<T>(T value) => new Result<T>().WithValue(value);

    public Result<T> WithValue(T value)
    {
        _value = value;

        return this;
    }
}