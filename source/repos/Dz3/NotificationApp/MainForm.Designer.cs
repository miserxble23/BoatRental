namespace NotificationApp
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
            MessageLabel = new Label();
            MessageTextBox = new TextBox();
            NotificationLabel = new Label();
            serviceComboBox = new ComboBox();
            SendNotificationButton = new Button();
            LogsLabel = new Label();
            logRichTextBox = new RichTextBox();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Font = new Font("Candara", 18.2769222F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MessageLabel.Location = new Point(22, 54);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(191, 40);
            MessageLabel.TabIndex = 0;
            MessageLabel.Text = "Сообщение:";
            // 
            // MessageTextBox
            // 
            MessageTextBox.BackColor = Color.Silver;
            MessageTextBox.Font = new Font("Candara", 16.0615387F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MessageTextBox.Location = new Point(303, 36);
            MessageTextBox.Multiline = true;
            MessageTextBox.Name = "MessageTextBox";
            MessageTextBox.Size = new Size(754, 76);
            MessageTextBox.TabIndex = 1;
            // 
            // NotificationLabel
            // 
            NotificationLabel.AutoSize = true;
            NotificationLabel.Font = new Font("Candara", 18.2769222F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NotificationLabel.Location = new Point(22, 167);
            NotificationLabel.Name = "NotificationLabel";
            NotificationLabel.Size = new Size(275, 40);
            NotificationLabel.TabIndex = 2;
            NotificationLabel.Text = "Тип уведомления:";
            // 
            // serviceComboBox
            // 
            serviceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            serviceComboBox.Font = new Font("Candara", 13.8461533F, FontStyle.Regular, GraphicsUnit.Point, 204);
            serviceComboBox.FormattingEnabled = true;
            serviceComboBox.Location = new Point(303, 178);
            serviceComboBox.Name = "serviceComboBox";
            serviceComboBox.Size = new Size(754, 39);
            serviceComboBox.TabIndex = 3;
            // 
            // SendNotificationButton
            // 
            SendNotificationButton.BackColor = Color.Silver;
            SendNotificationButton.Cursor = Cursors.Hand;
            SendNotificationButton.FlatStyle = FlatStyle.Flat;
            SendNotificationButton.Font = new Font("Candara", 13.8461533F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SendNotificationButton.Location = new Point(820, 229);
            SendNotificationButton.Name = "SendNotificationButton";
            SendNotificationButton.Size = new Size(237, 80);
            SendNotificationButton.TabIndex = 4;
            SendNotificationButton.Text = "Отправить уведомление";
            SendNotificationButton.UseVisualStyleBackColor = false;
            SendNotificationButton.Click += SendNotificationButton_Click;
            // 
            // LogsLabel
            // 
            LogsLabel.AutoSize = true;
            LogsLabel.Font = new Font("Candara", 18.2769222F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogsLabel.Location = new Point(22, 352);
            LogsLabel.Name = "LogsLabel";
            LogsLabel.Size = new Size(93, 40);
            LogsLabel.TabIndex = 5;
            LogsLabel.Text = "Логи:";
            // 
            // logRichTextBox
            // 
            logRichTextBox.BackColor = Color.Silver;
            logRichTextBox.Font = new Font("Candara", 16.0615387F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logRichTextBox.Location = new Point(303, 352);
            logRichTextBox.Name = "logRichTextBox";
            logRichTextBox.ReadOnly = true;
            logRichTextBox.Size = new Size(754, 219);
            logRichTextBox.TabIndex = 6;
            logRichTextBox.Text = "";
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Silver;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Candara", 13.8461533F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExitButton.Location = new Point(820, 591);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(237, 80);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1069, 683);
            Controls.Add(ExitButton);
            Controls.Add(logRichTextBox);
            Controls.Add(LogsLabel);
            Controls.Add(SendNotificationButton);
            Controls.Add(serviceComboBox);
            Controls.Add(NotificationLabel);
            Controls.Add(MessageTextBox);
            Controls.Add(MessageLabel);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            MouseDown += MainForm_MouseDown;
            MouseMove += MainForm_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MessageLabel;
        private TextBox MessageTextBox;
        private Label NotificationLabel;
        private ComboBox serviceComboBox;
        private Button SendNotificationButton;
        private Label LogsLabel;
        private RichTextBox logRichTextBox;
        private Button ExitButton;
    }
}