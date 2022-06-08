using WebApp.Repository;

namespace WebApp.Service
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;

        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }
        public bool Delete(int id)
        => _scheduleRepository.Delete(id);
    }
}
