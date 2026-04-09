namespace Boat_rental.Forms
{
    partial class DetailsForm
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
            textBoxDetails = new TextBox();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // textBoxDetails
            // 
            textBoxDetails.Font = new Font("Candara", 12.1846151F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxDetails.Location = new Point(0, 0);
            textBoxDetails.Multiline = true;
            textBoxDetails.Name = "textBoxDetails";
            textBoxDetails.ReadOnly = true;
            textBoxDetails.ScrollBars = ScrollBars.Vertical;
            textBoxDetails.Size = new Size(778, 547);
            textBoxDetails.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(128, 255, 128);
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Candara", 13.8461533F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.Black;
            CloseButton.Location = new Point(631, 558);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(126, 75);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Закрыть";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(778, 645);
            Controls.Add(CloseButton);
            Controls.Add(textBoxDetails);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetailsForm";
            Text = "DetailsForm";
            MouseDown += DetailsForm_MouseDown;
            MouseMove += DetailsForm_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDetails;
        private Button CloseButton;
    }
}