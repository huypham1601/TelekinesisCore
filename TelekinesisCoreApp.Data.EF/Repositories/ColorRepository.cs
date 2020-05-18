using System;
using System.Collections.Generic;
using System.Text;
using TelekinesisCoreApp.Data.Entities;
using TelekinesisCoreApp.Data.IRepositories;

namespace TelekinesisCoreApp.Data.EF.Repositories
{
    public class ColorRepository : EFRepository<Color, int>, IColorRepository
    {
        public ColorRepository(AppDbContext context) : base(context)
        {
        }
    }
}
