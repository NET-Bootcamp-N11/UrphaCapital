﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrphaCapital.Application.ViewModels;

namespace UrphaCapital.Application.UseCases.Help_.Commands
{
    public class CreateHelpCommand: IRequest<ResponseModel>
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string CourseType { get; set; }
    }
}
