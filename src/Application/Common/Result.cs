namespace Application.Common;

public class Result
{
    internal Result(bool succeeded, IEnumerable<string> errors)
    {
        Succeeded = succeeded;
        Errors = errors.ToArray();
    }

    public bool Succeeded { get; set; }

    public string[] Errors { get; set; }

    public static Result Success()
    {
        return new Result(true, Array.Empty<string>());
    }

    public static Result Failure(IEnumerable<string> errors)
    {
        return new Result(false, errors);
    }
}

public class Result<T> : Result
{
    public Result(bool succeeded, IEnumerable<string> errors, T? data) : base(succeeded, errors)
    {
        Data = data;
    }
    
    public static Result<T> SuccessWithData(T data)
    {
        return new Result<T>(true, Array.Empty<string>(), data);
    }

    public new static Result<T> Failure(IEnumerable<string> errors)
    {
        return new Result<T>(false, errors, default(T));
    }
    
    public T? Data { get; set; } 
}