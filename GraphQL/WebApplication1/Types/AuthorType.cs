﻿using GraphQL.Types;
using WebApplication1.Models;

namespace WebApplication1.Types
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Name = "Author";
            Field(_ => _.Id).Description("Author's Id.");
            Field(_ => _.FirstName).Description("First name of the author");
            Field(_ => _.LastName).Description("Last name of the author");
        }
    }
}