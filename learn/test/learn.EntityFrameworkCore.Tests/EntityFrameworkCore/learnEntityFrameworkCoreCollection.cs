using Xunit;

namespace learn.EntityFrameworkCore;

[CollectionDefinition(learnTestConsts.CollectionDefinitionName)]
public class learnEntityFrameworkCoreCollection : ICollectionFixture<learnEntityFrameworkCoreFixture>
{

}
