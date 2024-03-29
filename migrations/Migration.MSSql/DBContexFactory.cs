﻿using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace Migrations.MSSql
{
    public class DbContextFactory : IDesignTimeDbContextFactory<TicTacToyEntities>
    {
        public TicTacToyEntities CreateDbContext(string[] args)
        {
            var contextBuilder = new DbContextOptionsBuilder<TicTacToyEntities>();
            contextBuilder.UseSqlServer("Server=fake;Database=db;User=root;Password=root;", config =>
            {
                config.MigrationsAssembly("Migrations.MSSql");
            });
            return new TicTacToyEntities(contextBuilder.Options);
        }
    }
}
