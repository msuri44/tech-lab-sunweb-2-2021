﻿using GraphQL.Types;
using WebApplication1.Models;

namespace WebApplication1.Types
{
    public class BlogPostType : ObjectGraphType<BlogPost>
    {
        public BlogPostType()
        {
            Name = "BlogPost";
            Field(_ => _.Id, type:
                typeof(IdGraphType)).Description
                ("The Id of the Blog post.");
            Field(_ => _.Title).Description
                ("The title of the blog post.");
            Field(_ => _.Content).Description
                ("The content of the blog post.");
        }
    }
}