using NotificationApp.Services;
using NotificationApp.Core;
using NotificationApp.Logging;
namespace NotificationApp
{
    public partial class MainForm : Form
    {
        private List<INotificationService> services;
        Point LastPoint;
        private ILogger logger;
        public MainForm(List<INotificationService> services, ILogger logger)
        {
            InitializeComponent();
            this.services = services;
            this.logger = logger;
            serviceComboBox.DataSource = this.services;
            serviceComboBox.DisplayMember = "Name";
            serviceComboBox.SelectedIndex = 0;
            AddLog("Приложение запущено");
        }
        private void AddLog(string text)
        {
            logRichTextBox.AppendText(DateTime.Now + ": " + text + "\n");
            logger.Log(text);
        }
        private void AddError(string text)
        {
            logRichTextBox.AppendText(DateTime.Now + ": [ERROR] " + text + "\n");
            logger.Error(text);
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
        private void SendNotificationButton_Click(object sender, EventArgs e)
        {
            string message = MessageTextBox.Text.Trim();
            if (message == "")
            {
                MessageBox.Show("Сообщение не может быть пустым", "Ошибка");
                AddError("Попытка отправить пустое сообщение");
                return;
            }
            try
            {
                INotificationService service = (INotificationService)serviceComboBox.SelectedItem;
                NotificationSender notificationSender = new NotificationSender(service, logger);
                AddLog("Выбран сервис: " + notificationSender.GetServiceName());
                AddLog("Сообщение: " + message);
                notificationSender.Send(message);
                MessageBox.Show("Уведомление отправлено через " + notificationSender.GetServiceName(), "Успешно");
                AddLog("Уведомление отправлено через " + notificationSender.GetServiceName());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                AddError(ex.Message);
            }
            if (message.ToLower() == "пасхалка")
            {
                string imagePath = Path.Combine(Application.StartupPath, "Easter.jpg");
                if (File.Exists(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    Easter easter = new Easter(image);
                    easter.Show();
                    AddLog("Пасхалка активирована");
                }
                else
                {
                    MessageBox.Show("Файл Easter.jpg не найден", "Ошибка");
                    AddError("Файл Easter.jpg не найден");
                }
                return;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
