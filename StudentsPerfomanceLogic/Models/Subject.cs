using System.ComponentModel;

namespace StudentsPerformanceLogic.Models
{
    public class Subject
    {
        public int Id { get; }
        [DisplayName("Предмет")]
        public string Name { get; }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}