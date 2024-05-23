using System.Threading.Tasks;

namespace learn.Data;

public interface IlearnDbSchemaMigrator
{
    Task MigrateAsync();
}
