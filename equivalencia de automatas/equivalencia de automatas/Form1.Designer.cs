namespace equivalencia_de_automatas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewMoore = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridViewMealy = new System.Windows.Forms.DataGridView();
            this.entryNumberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButtonMealy = new System.Windows.Forms.RadioButton();
            this.radioButtonMoore = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.entriesTextyBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonmealycompleta = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoore)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMealy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(269, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 511);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dataGridViewMoore);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Moore";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(395, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Maquina completa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 437);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Probar equivalencia";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewMoore
            // 
            this.dataGridViewMoore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoore.Location = new System.Drawing.Point(31, 64);
            this.dataGridViewMoore.Name = "dataGridViewMoore";
            this.dataGridViewMoore.Size = new System.Drawing.Size(533, 354);
            this.dataGridViewMoore.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonmealycompleta);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.dataGridViewMealy);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mealy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(398, 449);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "Probar equivalencia";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMealy
            // 
            this.dataGridViewMealy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMealy.Location = new System.Drawing.Point(26, 61);
            this.dataGridViewMealy.Name = "dataGridViewMealy";
            this.dataGridViewMealy.Size = new System.Drawing.Size(533, 356);
            this.dataGridViewMealy.TabIndex = 26;
            // 
            // entryNumberBox
            // 
            this.entryNumberBox.Location = new System.Drawing.Point(147, 141);
            this.entryNumberBox.Name = "entryNumberBox";
            this.entryNumberBox.Size = new System.Drawing.Size(100, 20);
            this.entryNumberBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Conjunto de entradas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::equivalencia_de_automatas.Properties.Resources.comp;
            this.pictureBox1.Location = new System.Drawing.Point(269, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 511);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(35, 207);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 18;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 5.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 545);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 8);
            this.label11.TabIndex = 19;
            this.label11.Text = "HUERTAS AND RUBIO";
            // 
            // radioButtonMealy
            // 
            this.radioButtonMealy.AutoSize = true;
            this.radioButtonMealy.Checked = true;
            this.radioButtonMealy.Location = new System.Drawing.Point(35, 94);
            this.radioButtonMealy.Name = "radioButtonMealy";
            this.radioButtonMealy.Size = new System.Drawing.Size(53, 17);
            this.radioButtonMealy.TabIndex = 20;
            this.radioButtonMealy.TabStop = true;
            this.radioButtonMealy.Text = "Mealy";
            this.radioButtonMealy.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoore
            // 
            this.radioButtonMoore.AutoSize = true;
            this.radioButtonMoore.Location = new System.Drawing.Point(137, 94);
            this.radioButtonMoore.Name = "radioButtonMoore";
            this.radioButtonMoore.Size = new System.Drawing.Size(55, 17);
            this.radioButtonMoore.TabIndex = 21;
            this.radioButtonMoore.Text = "Moore";
            this.radioButtonMoore.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tipo de maquina";
            // 
            // entriesTextyBox
            // 
            this.entriesTextyBox.Location = new System.Drawing.Point(147, 165);
            this.entriesTextyBox.Name = "entriesTextyBox";
            this.entriesTextyBox.Size = new System.Drawing.Size(100, 20);
            this.entriesTextyBox.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Conjunto de estados";
            // 
            // buttonmealycompleta
            // 
            this.buttonmealycompleta.Location = new System.Drawing.Point(398, 16);
            this.buttonmealycompleta.Name = "buttonmealycompleta";
            this.buttonmealycompleta.Size = new System.Drawing.Size(122, 23);
            this.buttonmealycompleta.TabIndex = 29;
            this.buttonmealycompleta.Text = "Maquina completa";
            this.buttonmealycompleta.UseVisualStyleBackColor = true;
            this.buttonmealycompleta.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 567);
            this.Controls.Add(this.entriesTextyBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonMoore);
            this.Controls.Add(this.radioButtonMealy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.start);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.entryNumberBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Equivalent";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoore)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMealy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox entryNumberBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewMoore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridViewMealy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButtonMealy;
        private System.Windows.Forms.RadioButton radioButtonMoore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entriesTextyBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonmealycompleta;
    }
}

