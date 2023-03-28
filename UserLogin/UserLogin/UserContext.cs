using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;




class UserContext : DbContext
{
    public UserContext()
        : base(UserLogin.Properties.Settings.Default.DbConnect)
    {
    }


}

