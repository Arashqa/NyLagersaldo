namespace LagersaldoNy
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
            label1 = new Label();
            datagrid = new DataGridView();
            button3 = new Button();
            prisbox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            antalbox = new TextBox();
            idbox = new TextBox();
            färgbox = new TextBox();
            kategoribox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Trebuchet MS", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 60);
            label1.TabIndex = 0;
            label1.Text = "Lagersaldo Hantering ver. 1 - Arash Qayomi";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // datagrid
            // 
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.BackgroundColor = SystemColors.InactiveBorder;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid.Location = new Point(445, 72);
            datagrid.Name = "datagrid";
            datagrid.RowHeadersWidth = 62;
            datagrid.Size = new Size(343, 366);
            datagrid.TabIndex = 1;
            datagrid.CellContentClick += datagrid_CellContentClick;
            datagrid.CellDoubleClick += datagrid_CellDoubleClick;

            // 
            // button3
            // 
            button3.Location = new Point(288, 386);
            button3.Name = "button3";
            button3.Size = new Size(134, 31);
            button3.TabIndex = 7;
            button3.Text = "Ta bort";
            button3.UseVisualStyleBackColor = true;
            // 
            // prisbox
            // 
            prisbox.Location = new Point(60, 158);
            prisbox.Name = "prisbox";
            prisbox.Size = new Size(134, 31);
            prisbox.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(8, 386);
            button1.Name = "button1";
            button1.Size = new Size(134, 31);
            button1.TabIndex = 8;
            button1.Text = "Ny";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(148, 386);
            button2.Name = "button2";
            button2.Size = new Size(134, 31);
            button2.TabIndex = 9;
            button2.Text = "Spara";
            button2.UseVisualStyleBackColor = true;
            // 
            // antalbox
            // 
            antalbox.Location = new Point(200, 158);
            antalbox.Name = "antalbox";
            antalbox.Size = new Size(134, 31);
            antalbox.TabIndex = 10;
            // 
            // idbox
            // 
            idbox.Location = new Point(8, 92);
            idbox.Name = "idbox";
            idbox.Size = new Size(134, 31);
            idbox.TabIndex = 12;
            // 
            // färgbox
            // 
            färgbox.Location = new Point(148, 92);
            färgbox.Name = "färgbox";
            färgbox.Size = new Size(134, 31);
            färgbox.TabIndex = 13;
            // 
            // kategoribox
            // 
            kategoribox.FormattingEnabled = true;
            kategoribox.Location = new Point(288, 90);
            kategoribox.Name = "kategoribox";
            kategoribox.Size = new Size(134, 33);
            kategoribox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 64);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 15;
            label2.Text = "Produkt-ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 64);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 16;
            label3.Text = "Färg";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 64);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 17;
            label4.Text = "Kategori";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 130);
            label5.Name = "label5";
            label5.Size = new Size(40, 25);
            label5.TabIndex = 18;
            label5.Text = "Pris";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 130);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 19;
            label6.Text = "Antal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(kategoribox);
            Controls.Add(färgbox);
            Controls.Add(idbox);
            Controls.Add(antalbox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(prisbox);
            Controls.Add(datagrid);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Lagerhantering";
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView datagrid;
        private Button button3;
        private TextBox prisbox;
        private Button button1;
        private Button button2;
        private TextBox antalbox;
        private TextBox idbox;
        private TextBox färgbox;
        private ComboBox kategoribox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
