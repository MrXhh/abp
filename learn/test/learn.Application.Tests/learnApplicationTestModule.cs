using Volo.Abp.Modularity;

namespace learn;

[DependsOn(
    typeof(learnApplicationModule),
    typeof(learnDomainTestModule)
)]
public class learnApplicationTestModule : AbpModule
{

}
