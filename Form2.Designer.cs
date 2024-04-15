namespace Gra_Gdzie_jest_Dydelf
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            odliczanie_czasu = new Label();
            plansza = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)plansza).BeginInit();
            SuspendLayout();
            // 
            // odliczanie_czasu
            // 
            odliczanie_czasu.AutoSize = true;
            odliczanie_czasu.Location = new Point(240, 381);
            odliczanie_czasu.Name = "odliczanie_czasu";
            odliczanie_czasu.Size = new Size(59, 25);
            odliczanie_czasu.TabIndex = 0;
            odliczanie_czasu.Text = "label1";
            odliczanie_czasu.Click += odliczanie_czasu_Click;
            // 
            // plansza
            // 
            plansza.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            plansza.Location = new Point(44, 32);
            plansza.Name = "plansza";
            plansza.RowHeadersWidth = 62;
            plansza.Size = new Size(449, 305);
            plansza.TabIndex = 1;
            plansza.CellContentClick += plansza_CellContentClick;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 450);
            Controls.Add(plansza);
            Controls.Add(odliczanie_czasu);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)plansza).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label odliczanie_czasu;
        private DataGridView plansza;
        private System.Windows.Forms.Timer timer1;
    }
}