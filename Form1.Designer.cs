namespace Gra_Gdzie_jest_Dydelf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            przycisk_startu = new Button();
            przycisk_przekierowujacy_do_ustawien = new Button();
            przycisk_wysjcia_z_gry = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // przycisk_startu
            // 
            przycisk_startu.Location = new Point(62, 140);
            przycisk_startu.Name = "przycisk_startu";
            przycisk_startu.Size = new Size(112, 34);
            przycisk_startu.TabIndex = 0;
            przycisk_startu.Text = "start";
            przycisk_startu.UseVisualStyleBackColor = true;
            przycisk_startu.Click += przycisk_startu_Click;
            // 
            // przycisk_przekierowujacy_do_ustawien
            // 
            przycisk_przekierowujacy_do_ustawien.Location = new Point(62, 226);
            przycisk_przekierowujacy_do_ustawien.Name = "przycisk_przekierowujacy_do_ustawien";
            przycisk_przekierowujacy_do_ustawien.Size = new Size(112, 34);
            przycisk_przekierowujacy_do_ustawien.TabIndex = 1;
            przycisk_przekierowujacy_do_ustawien.Text = "ustawienia";
            przycisk_przekierowujacy_do_ustawien.UseVisualStyleBackColor = true;
            przycisk_przekierowujacy_do_ustawien.Click += przycisk_przekierowujacy_do_ustawien_Click;
            // 
            // przycisk_wysjcia_z_gry
            // 
            przycisk_wysjcia_z_gry.Location = new Point(62, 320);
            przycisk_wysjcia_z_gry.Name = "przycisk_wysjcia_z_gry";
            przycisk_wysjcia_z_gry.Size = new Size(112, 34);
            przycisk_wysjcia_z_gry.TabIndex = 2;
            przycisk_wysjcia_z_gry.Text = "koniec";
            przycisk_wysjcia_z_gry.UseVisualStyleBackColor = true;
            przycisk_wysjcia_z_gry.Click += przycisk_wysjcia_z_gry_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 57);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 3;
            label1.Text = "GDZIE JEST DYDELF?";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 398);
            Controls.Add(label1);
            Controls.Add(przycisk_wysjcia_z_gry);
            Controls.Add(przycisk_przekierowujacy_do_ustawien);
            Controls.Add(przycisk_startu);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button przycisk_startu;
        private Button przycisk_przekierowujacy_do_ustawien;
        private Button przycisk_wysjcia_z_gry;
        private Label label1;
    }
}
