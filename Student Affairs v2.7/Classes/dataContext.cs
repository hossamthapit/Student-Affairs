using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Student_Affairs_v2._7.Classes {
    class dataContext : DbContext {
        public dataContext() : base("name=DBconnection") {

        }
        public DbSet <User> Users { get; set; }
    }
}
