using WebApp.Dto;
using WebApp.Model;

namespace WebApp.Service
{
    public interface IStudentService
    {
        public Student AddStudent(Student student);
        public Student AddStudentFromDto(ScheduleClassDto scheduleClassDto);
    }
}
