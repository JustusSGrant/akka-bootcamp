using System.Collections.Immutable;

namespace AkkaWordCounter2.App.Messages;

public static class DocumentEvents
{
    public sealed record DocumentScanFailed(AbsoluteUri DocumentId, string Reason) : IWithDocumentId;
    
    public sealed record WordsFound(AbsoluteUri DocumentId, IReadOnlyList<string> Tokens) : IWithDocumentId;

    public sealed record EndOfDocumentReached(AbsoluteUri DocumentId) : IWithDocumentId;
    
    public sealed record CountsTabulatedForDocument(AbsoluteUri DocumentId, ImmutableDictionary<string, int> WordFrequencies) : IWithDocumentId;

    public sealed record CountsTabulatedForDocuments(
        IReadOnlyList<AbsoluteUri> Documents,
        IImmutableDictionary<string, int> WordFrequencies);
}