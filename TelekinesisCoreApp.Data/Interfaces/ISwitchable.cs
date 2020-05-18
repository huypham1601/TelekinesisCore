using System;
using System.Collections.Generic;
using System.Text;
using TelekinesisCoreApp.Data.Enums;

namespace TelekinesisCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
