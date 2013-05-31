namespace BuildHealth2013.WebUI.App_Start.BootStrap
{
    public interface IBootstrapTask
    {
        void Bootstrap();

        int Order { get; }
    }
}
