using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenders.Models
{
    internal class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Int16 PermissionId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Permision Permission { get; set; }
        

        /*
         [Id] [int] IDENTITY(1,1) NOT NULL,
	    [Username] [varchar](max) NOT NULL,
	    [Password] [varchar](max) NOT NULL,
	    [PermissionId] [tinyint] NOT NULL,
	    [Email] [varchar](max) NOT NULL,
	    [Phone] [varchar](max) NOT NULL,
	    [UserId] [int] NOT NULL,
         */
    }
}
