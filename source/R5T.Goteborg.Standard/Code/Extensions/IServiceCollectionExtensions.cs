using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Goteborg.Octokit.Default;
using R5T.Goteborg.Octokit.Sardinia;
using R5T.Polidea.Sardinia;


namespace R5T.Goteborg.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddGitHubOperator(this IServiceCollection services)
        {
            services
                .AddGitHubAuthenticationOptions()
                .AddGitHubConfiguration()
                .AddDefaultOctokitGitHubOperatorServices<ConfigurationBasedProductHeaderValueProvider>()
                ;

            return services;
        }
    }
}
