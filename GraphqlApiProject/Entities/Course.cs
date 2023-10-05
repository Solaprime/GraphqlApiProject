﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlApiProject.Entities
{
    public class Course
    {


        public Guid Id { get; set; }

       
        public string Title { get; set; }

        

        public string Description { get; set; }

        public Author Author { get; set; }

        public Guid AuthorId { get; set; }

    }
}
//Similar to ItemData
