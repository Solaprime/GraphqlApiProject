using GraphqlApiProject.ApplicationContext;
using GraphqlApiProject.Entities;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlApiProject.GraphqlAppQueries
{
    public class AppQuery
    {
        //U need to specify service before AppDbContext
        public IQueryable<Author> GetList([Service] AppDBContext  context )
        {
            return context.Authors;
        }
    }
}


// note query and list
//query
//{
//    list{
//        id
//        firstName
//        lastName
//        dateOfBirth
//    }
//}