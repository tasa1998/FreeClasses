using WebApp.Model;

namespace WebApp.Service
{
    public interface IProfesorService
    {
        public List<Profesor> GetProfesors();
        public Profesor GetProfesor(int id);
        public List<Schedule> GetSchedules(int id);
    }
}
