﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrphaCapital.Application.UseCases.GlobalIdServices
{
    public interface IGlobalIdService
    {
        public Task<long> GetNextGlobalIdAsync();
    }
}
