﻿using System.Collections.Generic;


namespace CodeFirstDemo.DataModels
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float FullPrice { get; set; }
        public CourseLevel Level { get; set; }
        public Author Author { get; set; }
        public ICollection<Tag> Tags { get; set; }


        public Course()
        {
            this.Tags = new List<Tag>();
        }
    }
}
