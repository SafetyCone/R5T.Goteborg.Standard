using System;

using Microsoft.Extensions.Configuration;

using R5T.Polidea.Suebia;


namespace R5T.Goteborg.Standard
{
    public static class IConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddGitHubConfiguration(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            configurationBuilder.AddGitHubAuthenticationConfiguration(configurationServiceProvider);

            return configurationBuilder;
        }
    }
}
