namespace AkkaWordCounter2.App.Messages;

public class DocumentQueries
{
    public sealed record FetchCounts(AbsoluteUri DocumentId) : IWithDocumentId;

    public sealed class SubscribeToAlCounts
    {
        public static readonly SubscribeToAlCounts Instance = new();
        private SubscribeToAlCounts() {}
    }
}