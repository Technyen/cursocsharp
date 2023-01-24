﻿using Microsoft.Build.Framework;

namespace ApiBackend.Models.DataModels
{
    public class Category:BaseEntity
    {
        [Required]
        public string Name { get; set; }=string.Empty;

        public ICollection<Course> Courses { get; set; } = new List<Course>();
       

    }
}