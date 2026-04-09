using RentalPaymentModel;
using RentalRouteModel;
namespace RentalModel
{
    public class Rental
    {
        public int Id { get; set; }
        public int BoatId { get; set; }
        public int ClientId { get; set; }
        public string Date { get; set; }
        public int Hours { get; set; }
        public decimal TotalPrice { get; set; }
        public RentalPayment Payment { get; set; }
        public RentalRoute Route { get; set; }
    }
}
