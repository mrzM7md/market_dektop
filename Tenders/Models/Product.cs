using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenders.Models
{
    internal class Product : ISharing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int FirmId { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }


        public Firm Firm { get; set; }
        public Category Category { get; set; }
        /*
         	[Id] [int] IDENTITY(1,1) NOT NULL,
	        [Name] [varchar](50) NOT NULL,
	        [Price] [money] NOT NULL,
	        [FirmId] [int] NOT NULL,
	        [CategoryId] [int] NOT NULL,
            [Image] VARCHAR(MAX) NOT NULL
            Description VARCHAR(MAX) NOT NULL
            Quantity INT NOT NULL
         */
    }
}
