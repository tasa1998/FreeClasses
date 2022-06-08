using WebApp.Model;

namespace WebApp.Repository
{
    public interface IProfessorRepository: IRepository<Profesor, int>
    {
        public List<Schedule> GetSchedules(int id);
    }
}
