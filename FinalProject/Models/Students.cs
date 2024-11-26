using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    //SAFA KEIS
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string CollegeProgram {  get; set; }
        public string YearInProgram { get; set; }

        public Students() { }

        public Students( int id, string name, DateTime birthday, string collegeProgram, string yearInProgram)
        {
            Id = id;
            Name = name;
            Birthday = birthday;
            CollegeProgram = collegeProgram;
            YearInProgram = yearInProgram;
        }

    }
}
