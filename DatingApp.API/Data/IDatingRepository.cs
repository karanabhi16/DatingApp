﻿using DatingApp.API.Models;
using DatingApp.API.Models.SendModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<UserDetail> GetUser(int id);
        Task<IEnumerable<UserDetail>> GetAllUsers();
    }
}
