using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using algStorage.DAL_ADO.Domain;

namespace algStorage.DAL.EF
{
    public class AlgorithmStorageContext : DbContext
    {
        //static private string connectionString = "DBConnection";
        public DbSet<User> Users { get; set; }
        public DbSet<Algorithm> Algorithms { get; set; }
        public DbSet<AccessGroup> AccessGroups { get; set; }
        public AlgorithmStorageContext() : base("DBConnection") { }
    }
}
