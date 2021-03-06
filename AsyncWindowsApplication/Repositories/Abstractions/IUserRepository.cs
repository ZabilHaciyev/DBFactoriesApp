﻿using AsyncWindowsApplication.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncWindowsApplication.Repositories.Abstractions
{
    public interface IUserRepository
    {
        event EventHandler<ErrorEventArgs> NotifyClientErrorEvent;

        Task<int> Create(User user);
        Task Update(User user);
        Task Delete(int id);
        Task<IEnumerable<User>> Get();
    }
}
