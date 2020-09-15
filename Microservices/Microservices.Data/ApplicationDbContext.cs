using Microservices.Data.Base;
using Microservices.Entities;
using Microsoft.EntityFrameworkCore;

namespace Microservices.Data
{
    /// <summary>
    /// Database for application
    /// </summary>
    public class ApplicationDbContext : DbContextBase<ApplicationDbContext>, IApplicationDbContext
    {
        /// <inheritdoc />
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        #region System

        public DbSet<Log> Logs { get; set; }

        #endregion
    }
}