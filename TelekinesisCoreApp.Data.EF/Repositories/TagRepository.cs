﻿using System;
using System.Collections.Generic;
using System.Text;
using TelekinesisCoreApp.Data.Entities;
using TelekinesisCoreApp.Data.IRepositories;

namespace TelekinesisCoreApp.Data.EF.Repositories
{
    public class TagRepository : EFRepository<Tag, string>, ITagRepository
    {
        public TagRepository(AppDbContext context) : base(context)
        {
        }
    }
}
