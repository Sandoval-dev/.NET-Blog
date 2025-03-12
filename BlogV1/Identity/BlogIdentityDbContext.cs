﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogV1.Identity
{
    //only login and user actions
    public class BlogIdentityDbContext:IdentityDbContext<BlogIdentityUser, BlogIdentityRole, string>
    {
        public BlogIdentityDbContext(DbContextOptions<BlogIdentityDbContext> options) : base(options) 
        {

        }
    }
}
