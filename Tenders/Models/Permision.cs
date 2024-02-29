using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenders.Models
{
    internal class Permision : ISharing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /*
	    [Id] [tinyint] IDENTITY(1,1) NOT NULL,
	    [Name] [varchar](50) NOT NULL,
        CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
         */
    }
}
