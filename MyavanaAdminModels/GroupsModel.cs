using System;
using System.Collections.Generic;
using System.Text;

namespace MyavanaAdminModels
{
    public class Group
    {
        public string HairType { get; set; }
        public string UserEmail { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
        public bool IsUpdate { get; set; }
    }

    public class GroupsModel
    {
        public string HairType { get; set; }
        public List<Users> Users { get; set; }
    }

    public class Users
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
    }
}
