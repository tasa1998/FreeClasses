using WebApp.Model;

namespace WebApp.Repository
{
    public class StudentRepository : IStudentRepository
    {

        private readonly MyDbContext _context;

        public StudentRepository(MyDbContext myDbContext)
        {
            _context = myDbContext;
        }


        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student Save(Student entity)
        {
            Student student = _context.Students.SingleOrDefault(t => t.Id == entity.Id);
            if (student == null)
            {
                _context.Students.Add(entity);
                _context.SaveChanges();
                return entity;
            }
            return null;
        }

        public Student Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
