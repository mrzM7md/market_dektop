using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenders.Models
{
    internal class Firm : ISharing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int AccountId { get; set; }

        public Account Account { get; set; }
        /*
         	[Id] [int] IDENTITY(1,1) NOT NULL,
	        [Name] [varchar](max) NOT NULL,
	        [Location] [varchar](max) NOT NULL,
	        [AccountId] [varchar](max) NOT NULL,
         */
    }
}
