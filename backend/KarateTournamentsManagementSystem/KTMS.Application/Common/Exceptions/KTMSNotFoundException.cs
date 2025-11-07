namespace KTMS.Application.Common.Exceptions;

public sealed class KTMSNotFoundException : Exception
{
    public KTMSNotFoundException(string message) : base(message) { }
}
