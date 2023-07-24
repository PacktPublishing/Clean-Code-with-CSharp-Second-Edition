using CrossCuttingConcerns.FileSystem;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace CrossCuttingConcerns.Exceptions;

[PSerializable]
public class ExceptionAspect : OnExceptionAspect
{
    public string Message { get; set; }
    public Type ExceptionType { get; set; }
    public FlowBehavior Behavior { get; set; }

    public override void OnException(MethodExecutionArgs args)
    {
        var message = args.Exception != null ? args.Exception.Message : "Unknown error occured.";
        LogFile.AppendTextToFile(
            "Exceptions.log", $"\n{DateTime.Now}: Method: {args.Method}, Exception: {message}"
        );
        args.FlowBehavior = FlowBehavior.Continue;
    }

    public override Type GetExceptionType(System.Reflection.MethodBase targetMethod)
    {
        return ExceptionType;
    }
}