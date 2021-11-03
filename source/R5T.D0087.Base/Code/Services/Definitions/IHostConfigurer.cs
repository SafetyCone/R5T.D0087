using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Hosting;

using R5T.T0064;


namespace R5T.D0087
{
    [ServiceDefinitionMarker]
    public interface IHostConfigurer : IServiceDefinition
    {
        Task ConfigureHost(IHostBuilder hostBuilder);
    }
}