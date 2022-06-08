using WebApp.Model;
using WebApp.Repository;

namespace WebApp.Service
{
    public class ProfesorService : IProfesorService
    {
        private readonly IProfessorRepository _profesorRepository;

        public ProfesorService(IProfessorRepository profesorRepository)
        {
            _profesorRepository = profesorRepository;
        }
        public Profesor GetProfesor(int id)
        => _profesorRepository.Get(id);

        public List<Profesor> GetProfesors()
        {
            List<Profesor> profesors = new List<Profesor>();    
            foreach(Profesor profesor in _profesorRepository.GetAll())
                if(profesor.IsAvailable == true)
                    profesors.Add(profesor);
            return profesors;
        }

        public List<Schedule> GetSchedules(int id)
        => _profesorRepository.GetSchedules(id);
    }
}
