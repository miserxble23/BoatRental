using BoatStatusModel;
using BoatLocationModel;
namespace BoatModel
{
    public class Boat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public decimal PricePerHour { get; set; }
        public BoatStatus Status { get; set; }
        public BoatLocation Location { get; set; }
    }
}
