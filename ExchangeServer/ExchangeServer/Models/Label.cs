using System.ComponentModel.DataAnnotations;

namespace ExchangeServer.Models
{
    public class Label
    {
        public int LabelId { get; set; }
        public string ShippingType { get; set; }
        public string ShippingId { get; set; }
        public string Status { get; set; }
        public string Country { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateTime { get; set; }
    }
}
