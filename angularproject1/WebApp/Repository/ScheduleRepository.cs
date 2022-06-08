using WebApp.Model;

namespace WebApp.Repository
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly MyDbContext _context;

        public ScheduleRepository(MyDbContext myDbContext)
        {
            _context = myDbContext;
        }
        public bool Delete(int id)
        {
            Schedule schedule = _context.Schedules.SingleOrDefault(e => e.Id == id);
            if(schedule != null)
            {
                _context.Schedules.Remove(schedule);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Schedule Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Schedule> GetAll()
        {
            throw new NotImplementedException();
        }

        public Schedule Save(Schedule entity)
        {
            throw new NotImplementedException();
        }

        public Schedule Update(Schedule entity)
        {
            throw new NotImplementedException();
        }
    }
}
