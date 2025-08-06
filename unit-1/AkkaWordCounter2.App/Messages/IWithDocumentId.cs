namespace AkkaWordCounter2.App.Messages;

public interface IWithDocumentId
{
    AbsoluteUri DocumentId { get; }
}