using WebApp.Model;

namespace WebApp.Repository
{
    public class ProfesorRepository : IProfessorRepository
    {

        private readonly MyDbContext _context;

        public ProfesorRepository(MyDbContext myDbContext)
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

        public List<Schedule> GetSchedules(int id)
        => _context.Schedules.Where(s => s.ProfesorId == id).ToList();

        public Profesor Get(int id)
        => _context.Profesors.FirstOrDefault(profesor => profesor.Id == id);

        public IEnumerable<Profesor> GetAll()
        {
            List<Profesor> profesors = new List<Profesor>();
            _context.Profesors.ToList().ForEach(profesor => profesors.Add(profesor));   
            return profesors;
        }

        public Profesor Save(Profesor entity)
        {
            throw new NotImplementedException();
        }

        public Profesor Update(Profesor entity)
        {
            throw new NotImplementedException();
        }
    }
}
