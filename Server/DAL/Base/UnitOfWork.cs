﻿using DAL.Base.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;


namespace DAL.Base
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly TicTacToyEntities _dbContext;
       // private BaseRepository<User, int> _userRepository;



        public UnitOfWork(DbContextOptions optionsBuilder)
        {
            _dbContext = new TicTacToyEntities(optionsBuilder);
        }
        //public BaseRepository<User, int> Users
        //{
        //    get
        //    {
        //        if (_userRepository == null)
        //            _userRepository = new BaseRepository<User, int>(_dbContext);
        //        return _userRepository;
        //    }
        //}


        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}