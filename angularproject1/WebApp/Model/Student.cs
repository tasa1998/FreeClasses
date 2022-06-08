namespace WebApp.Model
{
    [Index(nameof(Email), IsUnique = true)]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int profesorId { get; set; }

        public Student(string name,string surname,string email)
        {
            Name = name;
            Surname = surname; 
            Email = email;

        }

        public Student() { }
       

    }
}
