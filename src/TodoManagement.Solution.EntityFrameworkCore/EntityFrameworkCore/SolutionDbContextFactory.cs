﻿using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TodoManagement.Solution.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SolutionDbContextFactory : IDesignTimeDbContextFactory<SolutionDbContext>
{
    public SolutionDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        SolutionEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<SolutionDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new SolutionDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TodoManagement.Solution.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
