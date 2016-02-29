using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IocSimpleProject.Models
{
    public class Company : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}