using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forditoprog
{
    public partial class Form1 : Form 
    {
        public string[,] tablazat;
        Stack szabalyElemekStack = new Stack();

        int tablazatY = 0;
        int tablazatX = 0;
        string y = "";
        string x = "";
        string allapot = "";
        string output = "";
        //input:
        //(3*3)+2 (i*i)+i# 
        //3*3+2 3+3*2
        public Form1(string[,] tablazat)
        {
            this.tablazat = tablazat;
        }


        public Form1()
        {
            this.Text = "Beadandó";

            InitializeComponent();
            tablazat = new string[,]
            {
                {
                    "E", "", "", "(TE',1)", "", "(TE',1)", ""
                },

                {
                    "E'", "(+TE',2)", "", "", "(e,3)", "", "(e,3)"
                },

                {
                    "T", "", "", "(FT',4)", "", "(FT',4)", ""
                },

                {
                    "T'", "(e,6)", "(*FT',5)", "", "(e,6)", "", "(e,6)"
                },

                {
                    "F", "", "", "((E),7)", "", "(i,8)", ""
                },

                {
                    "+", "pop", "", "", "", "", ""
                },

                {
                    "*", "", "pop", "", "", "", ""
                },

                {
                    "(", "", "", "pop", "", "", ""
                },

                {
                    ")", "", "", "", "pop", "", ""
                },

                {
                    "i", "", "", "", "", "pop", ""
                },

                {
                    "#", "", "", "", "", "", "elfogad"
                },
            };
        }


        private void accept_Click(object sender, EventArgs e)
        {
            accept.Visible = false;
            stepsListBox1.Text = "";
            string input = inputText.Text;
            int index = 0;
            szabalyElemekStack.Push("#");
            szabalyElemekStack.Push("E");
            stepsListBox1.Text += input + "\n";
            input = Regex.Replace(input, "[0-9]+", "i");
            if (input.Last<char>() != '#') input += "#";
            originalInput.Text = inputText.Text;
            inputText.Text = input;
            int count = 0;
            do
            {

                y = input[index].ToString();
                x = szabalyElemekStack.Pop().ToString();


                switch (y)
                {
                    case "+": tablazatY = 1;
                        break;
                    case "*": tablazatY = 2;
                        break;
                    case "(": tablazatY = 3;
                        break;
                    case ")": tablazatY = 4;
                        break;
                    case "i": tablazatY = 5;
                        break;
                    case "#": tablazatY = 6;
                        break;
                    default:
                        break;
                }
                switch (x)
                {
                    case "E": tablazatX = 0;
                        break;
                    case "E'": tablazatX = 1;
                        break;
                    case "T": tablazatX = 2;
                        break;
                    case "T'": tablazatX = 3;
                        break;
                    case "F": tablazatX = 4;
                        break;
                    case "+": tablazatX = 5;
                        break;
                    case "*": tablazatX = 6;
                        break;
                    case "(": tablazatX = 7;
                        break;
                    case ")": tablazatX = 8;
                        break;
                    case "i": tablazatX = 9;
                        break;
                    case "#": tablazatX = 10;
                        break;
                    default:
                        break;
                }
                switch (tablazat[tablazatX, tablazatY])
                {

                    case "":
                        allapot = "hiba";
                        break;
                    case "elfogad":
                        allapot = "Sikeres";
                        break;
                    case "pop":
                        if (index + 1 <= input.Length) index++;
                        stepsListBox1.Text += string.Format("({0}, ", input.Remove(0, index));
                        foreach (var item in szabalyElemekStack)
                        {
                            stepsListBox1.Text += string.Format("{0}", item);
                        }
                        stepsListBox1.Text += string.Format(", {0})\n", output);
                        break;
                    default:
                        try
                        {
                            string[] karakterek = tablazat[tablazatX, tablazatY].Split(',');
                            karakterek[0] = karakterek[0].Remove(0, 1);
                            karakterek[1] = karakterek[1].Remove(1, 1);
                            char[] szabalyElemek = karakterek[0].ToArray();
                            output += karakterek[1];
                            for (int i = szabalyElemek.Length - 1; i >= 0; i--)
                            {
                                if (szabalyElemek[i] == 'e')
                                {
                                }
                                else if (szabalyElemek[i] == '\'')
                                {
                                    szabalyElemekStack.Push(szabalyElemek[i - 1].ToString() + szabalyElemek[i].ToString());
                                    i--;
                                }
                                else szabalyElemekStack.Push(szabalyElemek[i]);
                            }
                            stepsListBox1.Text += string.Format("({0}, ", input.Remove(0, index));
                            foreach (var item in szabalyElemekStack)
                            {
                                stepsListBox1.Text += string.Format("{0}", item);
                            }
                            stepsListBox1.Text += string.Format(", {0})\n", output);
                            break;
                        }
                        catch (Exception)
                        {
                            allapot = "Error";
                            break;
                        }
                }
                count++;

            }
            while (allapot == "");
            labelCount.Text = count-1 + " lépésből lett " + allapot.ToLower() + " végállapot";
            stepsListBox1.Text += string.Format("\n{0}", allapot);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var szabalyzat = new Form2(tablazat, this);
            szabalyzat.Show();
        }
    }
}
