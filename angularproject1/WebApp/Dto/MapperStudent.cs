using WebApp.Model;

namespace WebApp.Dto
{
    public class MapperStudent
    {
        public static Student mapDtoToStudent(ScheduleClassDto scheduleClassDto)
        => new Student
        {
            Name = scheduleClassDto.Name,
            Surname = scheduleClassDto.Surname,
            Email = scheduleClassDto.Email,
            profesorId = scheduleClassDto.ProfesorId,
        };
    }
}
