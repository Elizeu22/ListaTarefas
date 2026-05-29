using TodoApi.AppDbContext;

namespace TodoApi.Service
{
    public class DataBaseCreate
    {
        public static void CreateDataBase()
        {
            using (var context = new Context())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}
