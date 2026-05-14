using System.ComponentModel.DataAnnotations;

namespace Snape_Lite.Models
{
    public class Sensors
    {
        [Key]
        public int SensorId { get; set; }
        public int DeviceId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Readings { get; set; }
        public string? Status { get; set; }
        public DateTime LastUpdated { get; set; }

    }
}
