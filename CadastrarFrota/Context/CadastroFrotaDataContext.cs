using CadastrarFrota.Domain;
using System.Data.Entity;

namespace CadastrarFrota.Context
{
    public class CadastroFrotaDataContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public CadastroFrotaDataContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CadastroFrotaDataContext>());
        }     
    }
}
