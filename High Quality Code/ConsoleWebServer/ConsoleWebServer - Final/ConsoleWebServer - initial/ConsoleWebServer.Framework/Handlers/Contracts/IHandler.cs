namespace ConsoleWebServer.Framework.Handlers.Contracts
{
    using ConsoleWebServer.Framework.Contracts;

    public interface IHandler
    {
        IHttpResponse HandleRequest(IHttpRequest request);
        void SetSuccessor(IHandler successor);
    }
}
