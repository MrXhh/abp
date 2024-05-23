using learn.Samples;
using Xunit;

namespace learn.EntityFrameworkCore.Applications;

[Collection(learnTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<learnEntityFrameworkCoreTestModule>
{

}
