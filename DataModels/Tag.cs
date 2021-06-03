using System.Collections.Generic;


namespace CodeFirstDemo.DataModels
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }

        public Tag()
        {
            this.Courses = new List<Course>();
        }
    }
}
