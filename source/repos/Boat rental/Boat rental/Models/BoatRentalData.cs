using BoatModel;
using ClientModel;
using RentalModel;
using System.Xml.Serialization;
namespace Boat_rental.Models
{
    [XmlRoot("BoatRentalData")]
    public class BoatRentalData
    {
        [XmlArray("Boats")]
        [XmlArrayItem("Boat")]
        public List<Boat> Boats { get; set; } = new List<Boat>();
        [XmlArray("Clients")]
        [XmlArrayItem("Client")]
        public List<Client> Clients { get; set; } = new List<Client>();
        [XmlArray("Rentals")]
        [XmlArrayItem("Rental")]
        public List<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
