﻿using System;
using System.Collections.Generic;
using System.Text;
using TelekinesisCoreApp.Data.Entities;
using TelekinesisCoreApp.Infrastructure.Interfaces;

namespace TelekinesisCoreApp.Data.IRepositories
{
    public interface IFunctionRepository : IRepository<Function,string>
    {
    }
}
