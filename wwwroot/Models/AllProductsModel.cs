using System.Collections.Generic;

namespace HalalDelivery.Models
{
    public class AllProductsModel
    {
        public List<Hala> Halals { get; set; }

        public List<AdditionalProduct> AdditionalProducts { get; set; }
    }
}