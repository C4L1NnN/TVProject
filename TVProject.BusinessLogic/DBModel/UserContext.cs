using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVProject.Domain.Entities.User;

namespace TVProject.BusinessLogic.DBModel
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=TVProject")
        {
            
        }
        public virtual DbSet<UDbTable> users { get; set; }
    }
}
