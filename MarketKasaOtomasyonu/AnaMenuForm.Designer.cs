namespace MarketKasaOtomasyonu
{
    partial class AnaMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblBaslik;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblBaslik = new Label();
            SuspendLayout();
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBaslik.Location = new Point(63, 46);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(289, 25);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Market POS Ana Menu Ekrani";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 140);
            Controls.Add(lblBaslik);
            Name = "AnaMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Menu";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
