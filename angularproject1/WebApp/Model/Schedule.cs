namespace WebApp.Model
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }
        public Profesor profesor { get; set; }
        public int ProfesorId { get; set; }

        public Schedule() { }

        public Schedule(int id,DateTime start, DateTime end)
        {
            Id = id;
            StartTime = start;
            EndTime = end;
        }

    }
}
