﻿using System;
using System.Collections.Generic;
using System.Text;
using TelekinesisCoreApp.Application.ViewModels.Common;

namespace TelekinesisCoreApp.Application.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();
        List<SlideViewModel> GetSlides(string groupAlias);
        SystemConfigViewModel GetSystemConfig(string code);
    }
}
