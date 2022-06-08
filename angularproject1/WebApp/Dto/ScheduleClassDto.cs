namespace WebApp.Dto
{
    public class ScheduleClassDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }  
        public int ProfesorId { get; set; }
        public int ScheduleId { get; set; }

        public ScheduleClassDto(string name,string surname,string email, int profesorId, int scheduleId)
        {
            Name = name;
            Surname = surname;
            Email = email;
            ProfesorId = profesorId;
            ScheduleId = scheduleId;

        }

        public ScheduleClassDto() { }
    }
}
