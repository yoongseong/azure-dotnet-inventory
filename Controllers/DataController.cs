using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace scratch.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Product> Products()
        {
            Product[] products = new Product[4]
            {
                new Product(1, "Cisco N9K-C9332C", "Cisco Nexus 9332C ACI Spine Switch with 32p 40/100G QSFP28, 2p 1/10G SFP", 2),
                new Product(2, "Cisco 93180YC-EX", "48 x 1/10/25-Gbps fiber ports and 6 x 40/100-Gbps Quad Small Form-Factor Pluggable 28 (QSFP28) ports", 6),
                new Product(3, "Cisco HXAF220c M5SX", "Cisco HyperFlex HX220c M5 Node", 10),
                new Product(4, "Dell VxRail E560", "Dell EMC VxRail Appliances", 8)
            };

            return products;
        }

        public class Product
        {
            public int Id { get; set; }
            public string Title { get; private set; }
            public string Description { get; private set; }
            public int Quantity { get; private set; }

            public Product(int id, string title, string description, int quantity)
            {
                this.Id = id;
                this.Title = title;
                this.Description = description;
                this.Quantity = quantity;
            }
        }
    }
}
