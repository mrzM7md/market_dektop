using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenders.Models
{
    internal class Client : ISharing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityImage { get; set; }
       public string Gender { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }
        /*
           	[Id] [int] IDENTITY(1,1) NOT NULL,
	        [Name] [varchar](max) NOT NULL,
	        [IdentityImage] [varchar](max) NOT NULL,
	        [Gender] [int] NULL,
	        [AccountId] [int] NOT NULL,
         */
    }
}
