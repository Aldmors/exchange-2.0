using System.ComponentModel.DataAnnotations;

namespace ExchangeServer.Models
{
    public class Shipment
    {
        public int ShipmentId { get; set; }
        public string ExOrderId { get; set; }
        public string LabelId { get; set; }
        public string UserId { get; set; }
        public string Status { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateTime { get; set; }
    }
}
