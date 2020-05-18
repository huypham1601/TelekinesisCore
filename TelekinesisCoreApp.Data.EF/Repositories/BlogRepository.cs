using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelekinesisCoreApp.Data.Entities;
using TelekinesisCoreApp.Data.Enums;
using TelekinesisCoreApp.Data.IRepositories;

namespace TelekinesisCoreApp.Data.EF.Repositories
{
    public class BlogRepository : EFRepository<Blog, int>, IBlogRepository
    {
        public BlogRepository(AppDbContext context) : base(context)
        {
        }
    }
}
