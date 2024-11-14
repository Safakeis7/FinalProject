using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Brithday { get; set; }
        public string CollegeProgram {  get; set; }
        public string YearInProgram { get; set; }

        public Students() { }

        public Students( int id, string name, DateTime brithday, string collegeProgram, string yearInProgram)
        {
            Id = id;
            Name = name;
            Brithday = brithday;
            CollegeProgram = collegeProgram;
            YearInProgram = yearInProgram;
        }

    }
}
