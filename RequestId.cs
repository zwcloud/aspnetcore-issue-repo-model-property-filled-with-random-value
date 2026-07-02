using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace WebApp;

public readonly record struct RequestId : IParsable<RequestId>
{
    public Guid Guid { get; } = Guid.Empty;

    public RequestId(Guid guid)
    {
        Guid = guid;
    }

    public RequestId()
    {
        Guid = Guid.NewGuid();
    }

    public override string ToString()
    {
        return Guid.ToString();
    }

    public static implicit operator RequestId(Guid id)
    {
        Debugger.Break();
        return new RequestId(id);
    }

    public static RequestId Default { get; } = new RequestId(Guid.Empty);
    public static RequestId Parse(string s, IFormatProvider? provider)
    {
        //Debugger.Break();//This is never triggered in incorrect Case
        return new RequestId(Guid.Parse(s, provider));
    }

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, out RequestId result)
    {
        //Debugger.Break();//This is never triggered in incorrect Case
        if (!Guid.TryParse(s, provider, out Guid guid))
        {
            result = Empty;
            return false;
        }
        result = new RequestId(guid);
        return true;
    }

    public static RequestId Empty { get; } = new(Guid.Empty);
}
