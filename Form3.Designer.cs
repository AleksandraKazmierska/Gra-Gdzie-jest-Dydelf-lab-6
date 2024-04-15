namespace Gra_Gdzie_jest_Dydelf
{
    partial class Form3
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
            rozmiar_x_planszy = new Label();
            text_box_rozmiar_x_planszy = new TextBox();
            text_box_rozmiar_y_planszy = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            text_box_wpisanie_czasu_gry = new TextBox();
            text_box_ile_dydelfow = new TextBox();
            text_box_ile_korkodyli = new TextBox();
            przycisk_start = new Button();
            SuspendLayout();
            // 
            // rozmiar_x_planszy
            // 
            rozmiar_x_planszy.AutoSize = true;
            rozmiar_x_planszy.Location = new Point(128, 85);
            rozmiar_x_planszy.Name = "rozmiar_x_planszy";
            rozmiar_x_planszy.Size = new Size(0, 25);
            rozmiar_x_planszy.TabIndex = 0;
            // 
            // text_box_rozmiar_x_planszy
            // 
            text_box_rozmiar_x_planszy.Location = new Point(134, 99);
            text_box_rozmiar_x_planszy.Name = "text_box_rozmiar_x_planszy";
            text_box_rozmiar_x_planszy.Size = new Size(54, 31);
            text_box_rozmiar_x_planszy.TabIndex = 1;
            text_box_rozmiar_x_planszy.TextChanged += text_box_rozmiar_x_planszy_TextChanged;
            // 
            // text_box_rozmiar_y_planszy
            // 
            text_box_rozmiar_y_planszy.Location = new Point(134, 160);
            text_box_rozmiar_y_planszy.Name = "text_box_rozmiar_y_planszy";
            text_box_rozmiar_y_planszy.Size = new Size(54, 31);
            text_box_rozmiar_y_planszy.TabIndex = 2;
            text_box_rozmiar_y_planszy.TextChanged += text_box_rozmiar_y_planszy_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 99);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 3;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 160);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 4;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 68);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 5;
            label3.Text = "Dydelfy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 144);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 6;
            label4.Text = "Krokodyle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 242);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 7;
            label5.Text = "Czas";
            // 
            // text_box_wpisanie_czasu_gry
            // 
            text_box_wpisanie_czasu_gry.Location = new Point(281, 242);
            text_box_wpisanie_czasu_gry.Name = "text_box_wpisanie_czasu_gry";
            text_box_wpisanie_czasu_gry.Size = new Size(54, 31);
            text_box_wpisanie_czasu_gry.TabIndex = 8;
            text_box_wpisanie_czasu_gry.TextChanged += text_box_wpisanie_czasu_gry_TextChanged;
            // 
            // text_box_ile_dydelfow
            // 
            text_box_ile_dydelfow.Location = new Point(376, 99);
            text_box_ile_dydelfow.Name = "text_box_ile_dydelfow";
            text_box_ile_dydelfow.Size = new Size(54, 31);
            text_box_ile_dydelfow.TabIndex = 9;
            text_box_ile_dydelfow.TextChanged += text_box_ile_dydelfow_TextChanged;
            // 
            // text_box_ile_korkodyli
            // 
            text_box_ile_korkodyli.Location = new Point(376, 172);
            text_box_ile_korkodyli.Name = "text_box_ile_korkodyli";
            text_box_ile_korkodyli.Size = new Size(54, 31);
            text_box_ile_korkodyli.TabIndex = 10;
            text_box_ile_korkodyli.TextChanged += text_box_ile_korkodyli_TextChanged;
            // 
            // przycisk_start
            // 
            przycisk_start.Location = new Point(390, 256);
            przycisk_start.Name = "przycisk_start";
            przycisk_start.Size = new Size(112, 34);
            przycisk_start.TabIndex = 11;
            przycisk_start.Text = "Graj";
            przycisk_start.UseVisualStyleBackColor = true;
            przycisk_start.Click += przycisk_start_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 322);
            Controls.Add(przycisk_start);
            Controls.Add(text_box_ile_korkodyli);
            Controls.Add(text_box_ile_dydelfow);
            Controls.Add(text_box_wpisanie_czasu_gry);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_box_rozmiar_y_planszy);
            Controls.Add(text_box_rozmiar_x_planszy);
            Controls.Add(rozmiar_x_planszy);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label rozmiar_x_planszy;
        private TextBox text_box_rozmiar_x_planszy;
        private TextBox text_box_rozmiar_y_planszy;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox text_box_wpisanie_czasu_gry;
        private TextBox text_box_ile_dydelfow;
        private TextBox text_box_ile_korkodyli;
        private Button przycisk_start;
    }
}