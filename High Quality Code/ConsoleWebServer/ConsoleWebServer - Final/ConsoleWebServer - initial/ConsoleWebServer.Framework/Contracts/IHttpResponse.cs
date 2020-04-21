namespace ConsoleWebServer.Framework.Contracts
{
    public interface IHttpResponse : IHttpMessage
    {
        string Body { get; }
    }
}
