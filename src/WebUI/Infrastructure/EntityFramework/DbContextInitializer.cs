using System.Data.Entity;
using BuildHealth2013.WebUI.App_Start.BootStrap;

namespace BuildHealth2013.WebUI.Infrastructure.EntityFramework
{
    public class DbContextInitializer : IBootstrapTask
    {
        public void Bootstrap()
        {
            Database.SetInitializer(new BuildHealthContextInitilizer());
        }

        public int Order
        {
            get { return 0; }
        }
    }
}