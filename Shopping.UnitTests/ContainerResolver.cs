using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.UnitTests
{
    class ContainerResolver
    {
        public IServiceProvider ServiceProvider
        {
            get; set;
        }

        public ContainerResolver()
        {
            try
            {

                var hostBuilder = Host.CreateDefaultBuilder()
                    .ConfigureWebHost(webHost =>
                    {
                        // Add TestServer
                        webHost.UseTestServer();
                        webHost.UseStartup<Startup>();
                    });

            

                                // Create and start up the host
                                // var host = hostBuilder.Start();
                                ServiceProvider = hostBuilder.Build().Services;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
}
