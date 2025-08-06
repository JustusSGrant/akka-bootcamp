namespace AkkaWordCounter2.App.Messages;

/// <Summary>
/// Value type for enforcing absolute uros
/// </Summary>
public record struct AbsoluteUri
{
    public Uri Value { get; set; }
    public override string ToString() => Value.ToString();
    
    public AbsoluteUri(Uri value)
    {
        Value = value;
        if (!value.IsAbsoluteUri) throw new ArgumentException($"Value must be an absolute URL: {nameof(value)}");
    }
}