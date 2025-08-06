namespace AkkaWordCounter2.App.Messages;

public static class DocumentCommands
{
    public sealed record ScanDocument(AbsoluteUri DocumentId) : IWithDocumentId;

    public sealed record ScanDocuments(IReadOnlyList<AbsoluteUri> DocumentIds);
}