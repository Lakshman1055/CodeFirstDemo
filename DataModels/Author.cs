using System.Collections.Generic;


namespace CodeFirstDemo.DataModels
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }

        public Author()
        {
            this.Courses = new List<Course>();
        }
    }
}
