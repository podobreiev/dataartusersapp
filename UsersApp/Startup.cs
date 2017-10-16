using Owin;

namespace UsersApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Configure(app);
        }
    }
}