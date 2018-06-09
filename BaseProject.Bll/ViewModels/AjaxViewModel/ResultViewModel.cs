using System;
using System.Collections.Generic;
using System.Text;
using BaseProject.Bll.ViewModels.Enums;

namespace BaseProject.Bll.ViewModels.AjaxViewModel
{
    public class ResultViewModel
    {
        public bool Result { get; set; }
        public Object Model { get; set; }
        public EnumMenssage Menssage { get; set; }
    }
}
