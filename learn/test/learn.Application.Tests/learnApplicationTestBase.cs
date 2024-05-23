using Volo.Abp.Modularity;

namespace learn;

public abstract class learnApplicationTestBase<TStartupModule> : learnTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
