using FormBizz.EntityFrameworkCore;

namespace FormBizz.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly FormBizzDbContext _context;

        public InitialHostDbBuilder(FormBizzDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            // Creating Customer 
            new InitialPersonCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
