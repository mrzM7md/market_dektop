using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenders.Models
{
    internal class Admin: ISharing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AccountId { get; set; }
        public Account Account{ get; set; }
        /*
         	[Id] [int] IDENTITY(1,1) NOT NULL,
	        [Name] [varchar](50) NOT NULL,
	        [AccountId] INT NOT NULL,
         */
    }
}
