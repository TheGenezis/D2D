namespace D2D.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly D2DDbContext _context;

        public InitialHostDbBuilder(D2DDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
