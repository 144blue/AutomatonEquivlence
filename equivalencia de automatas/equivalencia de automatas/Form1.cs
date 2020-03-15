using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace equivalencia_de_automatas
{
    public partial class Form1 : Form
    {


        public String[] W;
        public String[] States;

        public Form1()
        {
            InitializeComponent();
            initializeVars();
            generateMealyMatrix();


        }

        public void initializeVars() {

           

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void generateMealyMatrix()
        {
            
           


        }


      

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (entryNumberBox.Text.Length!=0)
            {
                
                try
                {
                    this.tabControl1.Visible = true;                   
                    W = entryNumberBox.Text.Split(',');
                    States = entriesTextyBox.Text.Split(',');-                    

                    if (this.radioButtonMealy.Checked==true)
                    {
                        this.tabControl1.TabPages.Remove(tabPage1);
                        this.dataGridViewMealy.Columns.Add("States", "States");
                        for (int i = 0; i < W.Length; i++)
                        {                           
                            this.dataGridViewMealy.Columns.Add(W[i], W[i]);                            
                        }

                    }
                    else if(this.radioButtonMoore.Checked==true)
                    {
                        this.tabControl1.TabPages.Remove(tabPage2);
                        this.dataGridViewMealy.Columns.Add("States", "States");
                        for (int i = 0; i < W.Length; i++)
                        {
                            this.dataGridViewMoore.Columns.Add(W[i], W[i]);
                        }
                        this.dataGridViewMealy.Columns.Add("Outputs", "Outputs");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                
                
                
            }
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

    

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridViewMoore.Columns.Contains(textBoxEntradaMoore.Text))
            {

                foreach (DataGridViewColumn column  in dataGridViewMoore.Columns)
                {

                    if (true)
                    {
                        
                    }

                }
            }

          
        }


    }
}
