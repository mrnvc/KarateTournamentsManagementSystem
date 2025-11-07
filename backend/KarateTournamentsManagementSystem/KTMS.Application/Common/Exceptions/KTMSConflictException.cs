namespace KTMS.Application.Common.Exceptions;

public sealed class KTMSConflictException : Exception
{
    public KTMSConflictException(string message) : base(message) { }
}
