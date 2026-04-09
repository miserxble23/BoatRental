using ClientAddressModel;
using ClientContactModel;
namespace ClientModel
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
        public int Discount { get; set; }
        public ClientAddress Address { get; set; }
        public ClientContact Contact { get; set; }
    }
}
