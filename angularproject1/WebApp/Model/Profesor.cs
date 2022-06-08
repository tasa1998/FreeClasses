namespace WebApp.Model
{
    public class Profesor
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; } 
        public Boolean IsAvailable { get; set; }

        public List<Schedule> Schedules { get; set; }   


        public Profesor(string name, string surname, List<Schedule> schedules)
        {
            Name = name;
            Surname = surname;
            IsAvailable = true;
            Schedules = schedules;
        }


        public Profesor() { }


        public Profesor(int id) {
            Id = id;
        }

    }
}
