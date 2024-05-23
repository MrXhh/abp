using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace learn.Data;

/* This is used if database provider does't define
 * IlearnDbSchemaMigrator implementation.
 */
public class NulllearnDbSchemaMigrator : IlearnDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
