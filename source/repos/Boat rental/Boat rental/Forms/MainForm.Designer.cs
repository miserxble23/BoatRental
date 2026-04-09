namespace Boat_rental
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Лодки");
            TreeNode treeNode2 = new TreeNode("Клиенты");
            TreeNode treeNode3 = new TreeNode("Аренды");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            CloseButton = new Button();
            ShowButton = new Button();
            LoadJsonButton = new Button();
            LoadXmlButton = new Button();
            Panel = new Panel();
            TreeView = new TreeView();
            pictureBox = new PictureBox();
            dataGridViewInfo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(128, 255, 128);
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Candara", 13.8461533F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.Black;
            CloseButton.Location = new Point(826, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(126, 75);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "Закрыть";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // ShowButton
            // 
            ShowButton.BackColor = Color.FromArgb(128, 255, 128);
            ShowButton.Cursor = Cursors.Hand;
            ShowButton.Font = new Font("Candara", 13.8461533F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ShowButton.ForeColor = Color.Black;
            ShowButton.Location = new Point(694, 12);
            ShowButton.Name = "ShowButton";
            ShowButton.Size = new Size(126, 75);
            ShowButton.TabIndex = 1;
            ShowButton.Text = "Показать";
            ShowButton.UseVisualStyleBackColor = false;
            ShowButton.Click += ShowButton_Click;
            // 
            // LoadJsonButton
            // 
            LoadJsonButton.BackColor = Color.FromArgb(128, 255, 128);
            LoadJsonButton.Cursor = Cursors.Hand;
            LoadJsonButton.Font = new Font("Candara", 13.8461533F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoadJsonButton.ForeColor = Color.Black;
            LoadJsonButton.Location = new Point(525, 12);
            LoadJsonButton.Name = "LoadJsonButton";
            LoadJsonButton.Size = new Size(163, 75);
            LoadJsonButton.TabIndex = 2;
            LoadJsonButton.Text = "Загрузить JSON";
            LoadJsonButton.UseVisualStyleBackColor = false;
            LoadJsonButton.Click += LoadJsonButton_Click;
            // 
            // LoadXmlButton
            // 
            LoadXmlButton.BackColor = Color.FromArgb(128, 255, 128);
            LoadXmlButton.Cursor = Cursors.Hand;
            LoadXmlButton.Font = new Font("Candara", 13.8461533F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoadXmlButton.ForeColor = Color.Black;
            LoadXmlButton.Location = new Point(356, 12);
            LoadXmlButton.Name = "LoadXmlButton";
            LoadXmlButton.Size = new Size(163, 75);
            LoadXmlButton.TabIndex = 3;
            LoadXmlButton.Text = "Загрузить XML";
            LoadXmlButton.UseVisualStyleBackColor = false;
            LoadXmlButton.Click += LoadXmlButton_Click;
            // 
            // Panel
            // 
            Panel.BackColor = Color.Gray;
            Panel.ForeColor = Color.Yellow;
            Panel.Location = new Point(282, 2);
            Panel.Name = "Panel";
            Panel.Size = new Size(10, 653);
            Panel.TabIndex = 5;
            // 
            // TreeView
            // 
            TreeView.BackColor = Color.FromArgb(128, 255, 128);
            TreeView.BorderStyle = BorderStyle.None;
            TreeView.Cursor = Cursors.Hand;
            TreeView.Font = new Font("Candara", 19.9384613F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TreeView.Location = new Point(12, 226);
            TreeView.Name = "TreeView";
            treeNode1.Name = "Boats";
            treeNode1.Text = "Лодки";
            treeNode2.Name = "Clients";
            treeNode2.Text = "Клиенты";
            treeNode3.Name = "Rents";
            treeNode3.Text = "Аренды";
            TreeView.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeView.Size = new Size(173, 147);
            TreeView.TabIndex = 6;
            TreeView.AfterSelect += TreeView_AfterSelect;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(173, 147);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 7;
            pictureBox.TabStop = false;
            // 
            // dataGridViewInfo
            // 
            dataGridViewInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInfo.BackgroundColor = Color.FromArgb(128, 255, 128);
            dataGridViewInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfo.Location = new Point(356, 144);
            dataGridViewInfo.MultiSelect = false;
            dataGridViewInfo.Name = "dataGridViewInfo";
            dataGridViewInfo.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewInfo.RowHeadersWidth = 56;
            dataGridViewInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInfo.Size = new Size(596, 431);
            dataGridViewInfo.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(964, 655);
            Controls.Add(dataGridViewInfo);
            Controls.Add(pictureBox);
            Controls.Add(TreeView);
            Controls.Add(Panel);
            Controls.Add(LoadXmlButton);
            Controls.Add(LoadJsonButton);
            Controls.Add(ShowButton);
            Controls.Add(CloseButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            MouseDown += MainForm_MouseDown;
            MouseMove += MainForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CloseButton;
        private Button ShowButton;
        private Button LoadJsonButton;
        private Button LoadXmlButton;
        private PictureBox CatPicture;
        private Panel Panel;
        private TreeView TreeView;
        private PictureBox pictureBox;
        private DataGridView dataGridViewInfo;
    }
}