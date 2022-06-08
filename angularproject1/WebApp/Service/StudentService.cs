using WebApp.Dto;
using WebApp.Model;
using WebApp.Repository;

namespace WebApp.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IScheduleRepository _scheduleRepository;

        public StudentService(IStudentRepository studentRepository, IScheduleRepository scheduleRepository)
        {
            _studentRepository = studentRepository;
            _scheduleRepository = scheduleRepository;   
        }
        public Student AddStudent(Student student)
        {
            Student student1 = _studentRepository.Save(student);
            return student1;
        }

        public Student AddStudentFromDto(ScheduleClassDto scheduleClassDto)
        {
            Student student = MapperStudent.mapDtoToStudent(scheduleClassDto);
            Student student1 = _studentRepository.Save(student);
            _scheduleRepository.Delete(scheduleClassDto.ScheduleId);
            return student1;
        }
    }
}
