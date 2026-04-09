using BoatModel;
using ClientModel;
using RentalModel;
using System.Text;
namespace Boat_rental.Forms
{
    public partial class DetailsForm : Form
    {
        Point LastPoint;
        public DetailsForm()
        {
            InitializeComponent();
        }
        public void ShowBoatInfo(Boat boat)
        {
            var sb = new StringBuilder();
            sb.AppendLine("ЛОДКА");
            sb.AppendLine($"Id: {boat.Id}");
            sb.AppendLine($"Название: {boat.Name}");
            sb.AppendLine($"Тип: {boat.Type}");
            sb.AppendLine($"Вместимость: {boat.Capacity}");
            sb.AppendLine($"Цена за час: {boat.PricePerHour}");
            if (boat.Status != null)
            {
                sb.AppendLine($"Доступна: {(boat.Status.IsAvailable ? "Да" : "Нет")}");
                sb.AppendLine($"Состояние: {boat.Status.Condition}");
            }
            if (boat.Location != null)
            {
                sb.AppendLine($"Доступна: {(boat.Status.IsAvailable ? "Да" : "Нет")}");
                sb.AppendLine($"Состояние: {boat.Status.Condition}");
            }
            textBoxDetails.Text = sb.ToString();
        }
        public void ShowClientInfo(Client client)
        {
            var sb = new StringBuilder();
            sb.AppendLine("КЛИЕНТ");
            sb.AppendLine($"Id: {client.Id}");
            sb.AppendLine($"ФИО: {client.FullName}");
            sb.AppendLine($"Телефон: {client.Phone}");
            sb.AppendLine($"Паспорт: {client.Passport}");
            sb.AppendLine($"Скидка: {client.Discount}");
            if (client.Address != null)
            {
                sb.AppendLine($"Город: {client.Address.City}");
                sb.AppendLine($"Улица: {client.Address.Street}");
            }
            if (client.Contact != null)
            {
                sb.AppendLine($"Email: {client.Contact.Email}");
                sb.AppendLine($"Экстренный телефон: {client.Contact.EmergencyPhone}");
            }
            textBoxDetails.Text = sb.ToString();
        }
        public void ShowRentalInfo(Rental rental)
        {
            var sb = new StringBuilder();
            sb.AppendLine("АРЕНДА");
            sb.AppendLine($"Id: {rental.Id}");
            sb.AppendLine($"Id лодки: {rental.BoatId}");
            sb.AppendLine($"Id клиента: {rental.ClientId}");
            sb.AppendLine($"Дата: {rental.Date}");
            sb.AppendLine($"Часы: {rental.Hours}");
            sb.AppendLine($"Итоговая цена: {rental.TotalPrice}");
            if (rental.Payment != null)
            {
                sb.AppendLine($"Способ оплаты: {rental.Payment.Method}");
                sb.AppendLine($"Оплачено: {(rental.Payment.IsPaid ? "Да" : "Нет")}");
            }
            if (rental.Route != null)
            {
                sb.AppendLine($"Начало маршрута: {rental.Route.StartPoint}");
                sb.AppendLine($"Конец маршрута: {rental.Route.EndPoint}");
            }
            textBoxDetails.Text = sb.ToString();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DetailsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void DetailsForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
    }
}
