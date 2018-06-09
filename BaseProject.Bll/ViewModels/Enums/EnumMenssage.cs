using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BaseProject.Bll.ViewModels.Enums
{
    public enum EnumMenssage
    {
        [Description("Success")]
        Success = 1,

        [Description("Error")]
        Error = 2,

        [Description("Warning")]
        Warning = 3
       
    }
}
