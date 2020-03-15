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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewMoore = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEntradaMoore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEstadoAcutalMoore = new System.Windows.Forms.TextBox();
            this.textBoxEstadoSiguienteMoore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewMealy = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridViewMoore);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxEntradaMoore);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxEstadoAcutalMoore);
            this.tabPage1.Controls.Add(this.textBoxEstadoSiguienteMoore);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Moore";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(302, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Salida:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(395, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Maquina completa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 437);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Probar equivalencia";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewMoore
            // 
            this.dataGridViewMoore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoore.Location = new System.Drawing.Point(31, 151);
            this.dataGridViewMoore.Name = "dataGridViewMoore";
            this.dataGridViewMoore.Size = new System.Drawing.Size(533, 267);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Entrada:  ";
            // 
            // textBoxEntradaMoore
            // 
            this.textBoxEntradaMoore.Location = new System.Drawing.Point(361, 64);
            this.textBoxEntradaMoore.Name = "textBoxEntradaMoore";
            this.textBoxEntradaMoore.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntradaMoore.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estado actual: ";
            // 
            // textBoxEstadoAcutalMoore
            // 
            this.textBoxEstadoAcutalMoore.Location = new System.Drawing.Point(181, 64);
            this.textBoxEstadoAcutalMoore.Name = "textBoxEstadoAcutalMoore";
            this.textBoxEstadoAcutalMoore.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstadoAcutalMoore.TabIndex = 10;
            // 
            // textBoxEstadoSiguienteMoore
            // 
            this.textBoxEstadoSiguienteMoore.Location = new System.Drawing.Point(181, 89);
            this.textBoxEstadoSiguienteMoore.Name = "textBoxEstadoSiguienteMoore";
            this.textBoxEstadoSiguienteMoore.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstadoSiguienteMoore.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estado siguiente :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridViewMealy);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mealy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(398, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Maquina completa";
            this.button5.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Ingresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewMealy
            // 
            this.dataGridViewMealy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMealy.Location = new System.Drawing.Point(29, 176);
            this.dataGridViewMealy.Name = "dataGridViewMealy";
            this.dataGridViewMealy.Size = new System.Drawing.Size(533, 267);
            this.dataGridViewMealy.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(352, 83);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Salida:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Entrada:  ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(352, 58);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Estado actual: ";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(172, 55);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 19;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(172, 80);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Estado siguiente :";
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
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxEstadoSiguienteMoore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEstadoAcutalMoore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewMoore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEntradaMoore;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewMealy;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButtonMealy;
        private System.Windows.Forms.RadioButton radioButtonMoore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox entriesTextyBox;
        private System.Windows.Forms.Label label13;
    }
}

