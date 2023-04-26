using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forditoprog
{
    public partial class Form2 : Form
    {
        Form1 form;
        public Form2(string[,] grid, Form1 form)
        {
            this.form = form;
            InitializeComponent();
            this.Text = "Táblázat";

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                string[] row = new string[grid.GetLength(1)];

                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    row[j] = grid[i, j];
                }
                tabla.Rows.Add(row);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int c = tabla.Columns.Count;
            int r = tabla.Rows.Count;



            string[,] a = new string[r, c];


            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    a[i, j] = tabla.Rows[i].Cells[j].Value.ToString();
                }
            }
            form.tablazat = a;
            this.Close();


        }
    }
}

