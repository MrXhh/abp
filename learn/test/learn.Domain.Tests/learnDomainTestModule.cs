using Volo.Abp.Modularity;

namespace learn;

[DependsOn(
    typeof(learnDomainModule),
    typeof(learnTestBaseModule)
)]
public class learnDomainTestModule : AbpModule
{

}
