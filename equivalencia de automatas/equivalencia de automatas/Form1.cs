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
        public Maquina a;
        
        public int machineCount;

        public Form1()
        {
            InitializeComponent();
            initializeVars();
            generateMealyMatrix();


        }

        public void initializeVars() {


            machineCount = 0;
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
                    States = entriesTextyBox.Text.Split(',');                 

                    if (this.radioButtonMealy.Checked==true)
                    {
                        this.tabControl1.TabPages.Remove(tabPage1);
                        this.dataGridViewMealy.Columns.Add("States", "States/Entries");
                        for (int i = 0; i < W.Length; i++)
                        {                           
                            this.dataGridViewMealy.Columns.Add(W[i], W[i]);   
                            
                        }
                        for (int i = 0; i <States.Length; i++)
                        {
                            this.dataGridViewMealy.Rows.Add(States[i]);
                        }
                        this.radioButtonMoore.Enabled = false;
                    }
                    else if(this.radioButtonMoore.Checked==true)
                    {
                        this.tabControl1.TabPages.Remove(tabPage2);
                        this.dataGridViewMoore.Columns.Add("States", "States/Entries");
                        for (int i = 0; i < W.Length; i++)
                        {
                            this.dataGridViewMoore.Columns.Add(W[i], W[i]);
                        }
                        for (int i = 0; i < States.Length; i++)
                        {
                            this.dataGridViewMoore.Rows.Add(States[i]);
                        }
                        this.dataGridViewMealy.Columns.Add("Outputs", "Outputs");
                        this.radioButtonMealy.Enabled = false;
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
           //mealy probar equivalencia
         
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //mealy maquina completa

            if (machineCount == 0)
            {
                Estado[] estados = new Estado[States.Length];

                for (int i = 0; i < States.Length; i++)
                {
                    estados[i] = new Estado(States[i]);

                    



                    int[] salidasCero= new int[States.Length];
                    String[] estadosSalida = new string[States.Length];
                    string[] temnporal = new string[2];
                    String temp;

                    try
                    {
                        for (int j = 0; j < W.Length; j++)
                        {
                            
                             temp=Convert.ToString(this.dataGridViewMealy.Rows[i].Cells[j].Value);
                             temnporal = temp.Split(',');
                             salidasCero[j] = int.Parse(temnporal[1]);
                             estadosSalida[j] = temnporal[0];
                             

                            
                            //importante el indice
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }



                }

                a = new Maquina();

            }else if (machineCount == 1)
            {

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //moore maquina completa

            if (machineCount == 0)
            {

            }
            else if (machineCount == 1)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //moore probar equivalencia
        }
    }
}
