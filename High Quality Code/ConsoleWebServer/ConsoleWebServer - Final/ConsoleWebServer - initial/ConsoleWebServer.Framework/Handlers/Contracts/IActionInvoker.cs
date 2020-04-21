namespace ConsoleWebServer.Framework.Handlers.Contracts
{
    using ConsoleWebServer.Framework.ActionResults;
    using ConsoleWebServer.Framework.Contracts;

    public interface IActionInvoker
    {
        IActionResult InvokeAction(Controller controller, IActionDescriptor actionDescriptor);
    }
}
