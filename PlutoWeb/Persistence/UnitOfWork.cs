using PlutoWeb.Core;
using PlutoWeb.Core.Repositories;
using PlutoWeb.Persistence.Repositories;

namespace PlutoWeb.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;

        //only code inside the UnitOfWork class can change the 
        //values of these properties 
        public ICourseRepository Courses { get; private set; }
        public IAuthorRepository Authors { get; private set; }

        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            Authors = new AuthorRepository(_context);
        }
        
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}