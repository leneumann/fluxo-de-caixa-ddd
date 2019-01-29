namespace FluxoDeCaixa.Application
{
    public interface IHandler<T> where T : Command
    {
        ICommandResult Handle(T command);
    }
}