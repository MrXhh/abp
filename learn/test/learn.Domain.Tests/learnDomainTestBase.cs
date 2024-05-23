using Volo.Abp.Modularity;

namespace learn;

/* Inherit from this class for your domain layer tests. */
public abstract class learnDomainTestBase<TStartupModule> : learnTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
