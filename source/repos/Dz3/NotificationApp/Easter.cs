namespace NotificationApp
{
    public partial class Easter : Form
    {
        public Easter(Image image)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = image;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
