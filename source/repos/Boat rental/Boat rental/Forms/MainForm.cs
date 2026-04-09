using Boat_rental.Forms;
using Boat_rental.Models;
using Newtonsoft.Json;
using System.Xml.Serialization;
namespace Boat_rental
{
    public partial class MainForm : Form
    {
        Point LastPoint;
        private BoatRentalData data;
        private string currentSection = ""; // хранит какой раздел выбран в дереве 
        public MainForm()
        {
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void LoadXmlButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "XML files (*.xml)|*.xml"; // ограничивает выбор только XMLками
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var serializer = new XmlSerializer(typeof(BoatRentalData));
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                    {
                        data = (BoatRentalData)serializer.Deserialize(fs);
                    }
                    MessageBox.Show("XML файл загружен");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }
        private void LoadJsonButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "JSON files (*.json)|*.json"; // ограничивает выбор только JSONками
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var json = File.ReadAllText(ofd.FileName);
                    data = JsonConvert.DeserializeObject<BoatRentalData>(json);
                    MessageBox.Show("JSON файл загружен");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("Сначала загрузите файл");
                { 
                    return;
                }
            }
            currentSection = e.Node.Text; //берётся текст выбранного узла из дерева и сохраняется в currentSection
            if (currentSection == "Лодки")
            {
                if (data.Boats == null || data.Boats.Count == 0)
                {
                    MessageBox.Show("Нет данных о лодках");
                    {
                        return;
                    }
                }
                dataGridViewInfo.DataSource = data.Boats.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Type,
                    x.Capacity,
                    x.PricePerHour
                }).ToList();
            }
            else if (currentSection == "Клиенты")
            {
                if (data.Clients == null || data.Clients.Count == 0)
                {
                    MessageBox.Show("Нет данных о клиентах");
                    { 
                        return;
                    }
                }
                dataGridViewInfo.DataSource = data.Clients.Select(x => new
                {
                    x.Id,
                    x.FullName,
                    x.Phone,
                    x.Passport,
                    x.Discount
                }).ToList();
            }
            else if (currentSection == "Аренды")
            {
                if (data.Rentals == null || data.Rentals.Count == 0)
                {
                    MessageBox.Show("Нет данных об арендах");
                    { 
                        return;
                    }
                }
                dataGridViewInfo.DataSource = data.Rentals.Select(x => new
                {
                    x.Id,
                    x.BoatId,
                    x.ClientId,
                    x.Date,
                    x.Hours,
                    x.TotalPrice
                }).ToList();
            }
        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("Сначала загрузите файл");
                { 
                    return;
                }
            }
            if (string.IsNullOrEmpty(currentSection))
            {
                MessageBox.Show("Сначала выберите раздел в дереве");
                { 
                    return;
                }
            }
            if (dataGridViewInfo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите запись в таблице");
                { 
                    return; 
                }
            }
            var id = Convert.ToInt32(dataGridViewInfo.SelectedRows[0].Cells[0].Value);
            var form = new DetailsForm();
            if (currentSection == "Лодки")
            {
                var boat = data.Boats.FirstOrDefault(x => x.Id == id);
                if (boat != null)
                {
                    form.ShowBoatInfo(boat);
                }
            }
            else if (currentSection == "Клиенты")
            {
                var client = data.Clients.FirstOrDefault(x => x.Id == id);
                if (client != null)
                {
                    form.ShowClientInfo(client);
                }
            }
            else if (currentSection == "Аренды")
            {
                var rental = data.Rentals.FirstOrDefault(x => x.Id == id);
                if (rental != null)
                {
                    form.ShowRentalInfo(rental);
                }
            }
            form.ShowDialog();
        }
    }
}
