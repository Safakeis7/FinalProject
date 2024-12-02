//Vy Huynh - Group 6
namespace FinalProject.Models
{
    public class Cartoon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Studio { get; set; }
        public DateOnly FirstAired { get; set; }
        public string MainCharacter { get; set; }

        public Cartoon() { }
        public Cartoon(int id, string name, string studio, DateOnly firstAired, string mainCharacter)
        {
            Id = id;
            Name = name;
            Studio = studio;
            FirstAired = firstAired;
            MainCharacter = mainCharacter;
        }

        public static implicit operator Cartoon(List<Cartoon> v)
        {
            throw new NotImplementedException();
        }
    }
}
