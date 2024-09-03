﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrphaCapital.Domain.Entities;

namespace UrphaCapital.Application.UseCases.Homework.Queries
{
    public class GetHomeworkByStudentIdQuery: IRequest<IEnumerable<Homeworks>>
    {
        public long studentId { get; set; }
    }
}
