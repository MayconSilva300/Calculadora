using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        int numero = 10;
        int numero1 = 0;
        int numero2 = 0;
        int cal = 0;
        double valor1 = 0;
        double valor2 = 0;
        double total = 0;
        bool calculo = false;
        bool calculo1 = false;
        bool comvirgula = false;

        private void NUMEROS()
        {
            int num = numero;
            if (numero2 == 2) { numero2 = 1; FUNCIONALIDADES(); };
            switch (num)
            {
                case 0: tela.Text = tela.Text + "0"; break;
                case 1: tela.Text = tela.Text + "1"; break;
                case 2: tela.Text = tela.Text + "2"; break;
                case 3: tela.Text = tela.Text + "3"; break;
                case 4: tela.Text = tela.Text + "4"; break;
                case 5: tela.Text = tela.Text + "5"; break;
                case 6: tela.Text = tela.Text + "6"; break;
                case 7: tela.Text = tela.Text + "7"; break;
                case 8: tela.Text = tela.Text + "8"; break;
                case 9: tela.Text = tela.Text + "9"; break;
            } historico.Focus();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            numero = 0; NUMEROS();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            numero = 1; NUMEROS();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            numero = 2; NUMEROS();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            numero = 3; NUMEROS();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            numero = 4; NUMEROS();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            numero = 5; NUMEROS();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            numero = 6; NUMEROS();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            numero = 7; NUMEROS();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            numero = 8; NUMEROS();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            numero = 9; NUMEROS();
        }

        private void CALCULOS()
        {
            if(tela.Text == "") { } else {
                if (numero2 == 2) { numero2 = 1; FUNCIONALIDADES(); }
                else
                {
                    if (calculo == false)
                    {
                        valor1 = Convert.ToDouble(tela.Text);
                        switch (numero1)
                        {
                            case 1: historico.Text = tela.Text + " + "; tela.Text = ""; total = valor1; break;
                            case 2: historico.Text = tela.Text + " - "; tela.Text = ""; total = valor1; break;
                            case 3: historico.Text = tela.Text + " / "; tela.Text = ""; total = valor1; break;
                            case 4: historico.Text = tela.Text + " x "; tela.Text = ""; total = valor1; break;
                        }
                    }
                    else if (calculo == true)
                    {
                        valor2 = Convert.ToDouble(tela.Text);
                        switch (cal)
                        {
                            case 1:
                                if (calculo1 == true) { total = total + valor2; }
                                else { total = valor1 + valor2; calculo1 = true; }
                                break;

                            case 2:
                                if (calculo1 == true) { total = total - valor2; }
                                else { total = valor1 - valor2; calculo1 = true; }
                                break;


                            case 3:
                                if (calculo1 == true) { total = total / valor2; }
                                else { total = valor1 / valor2; calculo1 = true; }
                                break;

                            case 4:
                                if (calculo1 == true) { total = total * valor2; }
                                else { total = valor1 * valor2; calculo1 = true; }
                                break;
                        }
                        switch (numero1)
                        {
                            case 1: historico.Text = historico.Text + tela.Text + " + "; tela.Text = ""; break;
                            case 2: historico.Text = historico.Text + tela.Text + " - "; tela.Text = ""; break;
                            case 3: historico.Text = historico.Text + tela.Text + " / "; tela.Text = ""; break;
                            case 4: historico.Text = historico.Text + tela.Text + " x "; tela.Text = ""; break;
                        }
                    }
                }
                cal = numero1;
                calculo = true; historico.Focus();
            }        
        }

        private void bmais_Click(object sender, EventArgs e)
        {
            numero1 = 1; CALCULOS();
        }

        private void bmenos_Click(object sender, EventArgs e)
        {
            numero1 = 2; CALCULOS();
        }

        private void bdividir_Click(object sender, EventArgs e)
        {
            numero1 = 3; CALCULOS();
        }

        private void bvezes_Click(object sender, EventArgs e)
        {
            numero1 = 4; CALCULOS();
        }

        private void FUNCIONALIDADES()
        {
                switch (numero2)
                {
                case 1:
                        if (numero2 == 2) { numero2 = 1; FUNCIONALIDADES(); };
                        numero = 10; numero1 = 0; numero2 = 0; valor1 = 0; valor2 = 0; calculo = false;
                        calculo1 = false; historico.Text = ""; tela.Text = ""; cal = 0; comvirgula = false; break;
                case 2:
                        switch (numero1)
                        {
                            case 1: total = total + Convert.ToDouble(tela.Text); historico.Text = historico.Text + tela.Text; break;
                            case 2: total = total - Convert.ToDouble(tela.Text); historico.Text = historico.Text + tela.Text; break;
                            case 3: total = total / Convert.ToDouble(tela.Text); historico.Text = historico.Text + tela.Text; break;
                            case 4: total = total * Convert.ToDouble(tela.Text); historico.Text = historico.Text + tela.Text; break;
                        }
                        tela.Text = Convert.ToString(total); break;
                case 3:
                        if (numero2 == 2) { numero2 = 1; FUNCIONALIDADES(); }
                        else
                        {
                            int x = tela.Text.Length - 1;
                            if (x >= 0) { tela.Text = tela.Text.Substring(0, x); }
                        }
                        break;
                case 4:
                        double invert = 0;
                        invert = Convert.ToDouble(tela.Text) * -1;
                        tela.Text = Convert.ToString(invert); break;
                case 5: if (comvirgula == false) { tela.Text = tela.Text + ","; comvirgula  = true; }
                    else{ } break;
                }
            historico.Focus();
        }

        private void binverte_Click(object sender, EventArgs e)
        {
            if (numero2 == 2) { numero2 = 1; FUNCIONALIDADES(); historico.Focus(); }
            else if (tela.Text == "") { }
            else { numero2 = 4; FUNCIONALIDADES(); }
            historico.Focus();
        }

        private void blimpar_Click(object sender, EventArgs e)
        {
            numero2 = 1; FUNCIONALIDADES(); historico.Focus();
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            if (numero2 == 2) { numero2 = 1; FUNCIONALIDADES(); historico.Focus(); }
            else if (tela.Text == "") { }
            else
            {
                numero2 = 3; FUNCIONALIDADES();
            }
            historico.Focus();
        }

        private void bvirgula_Click(object sender, EventArgs e)
        {
            if (numero2 == 2) { numero2 = 1; FUNCIONALIDADES(); historico.Focus(); }
            else if (tela.Text == "") { }
            else { numero2 = 5; FUNCIONALIDADES(); }
            historico.Focus();
        }

        private void bresultado_Click(object sender, EventArgs e)
        {   if (tela.Text == "") { }
            else { numero2 = 2; FUNCIONALIDADES(); historico.Focus(); }
        }

        private void Calculadora_KeyDown(object sender, KeyEventArgs e)
        {
            // NUMEROS NO TECLADO
            if (e.KeyValue >= 48 & e.KeyValue <= 57 || e.KeyValue >= 96 & e.KeyValue <= 105)
            {
                if (e.KeyValue == 48 || e.KeyValue == 96 || numero == 0) { numero = 0; NUMEROS(); };
                if (e.KeyValue == 49 || e.KeyValue == 97 || numero == 1) { numero = 1; NUMEROS(); };
                if (e.KeyValue == 50 || e.KeyValue == 98 || numero == 2) { numero = 2; NUMEROS(); };
                if (e.KeyValue == 51 || e.KeyValue == 99 || numero == 3) { numero = 3; NUMEROS(); };
                if (e.KeyValue == 52 || e.KeyValue == 100 || numero == 4) { numero = 4; NUMEROS(); };
                if (e.KeyValue == 53 || e.KeyValue == 101 || numero == 5) { numero = 5; NUMEROS(); };
                if (e.KeyValue == 54 || e.KeyValue == 102 || numero == 6) { numero = 6; NUMEROS(); };
                if (e.KeyValue == 55 || e.KeyValue == 103 || numero == 7) { numero = 7; NUMEROS(); };
                if (e.KeyValue == 56 || e.KeyValue == 104 || numero == 8) { numero = 8; NUMEROS(); };
                if (e.KeyValue == 57 || e.KeyValue == 105 || numero == 9) { numero = 9; NUMEROS(); };
                numero = 11;
            }

            // CALCULOS NO TECLADO
            if (e.KeyValue <= 106 || e.KeyValue <= 107 || e.KeyValue <= 109 || e.KeyValue <= 111 || e.KeyValue <= 189)
            {
                switch (e.KeyValue)
                {
                    case 106: numero1 = 4; CALCULOS(); break;
                    case 107: numero1 = 1; CALCULOS(); break;
                    case 109: numero1 = 2; CALCULOS(); break;
                    case 111: numero1 = 3; CALCULOS(); break;
                    case 189: numero1 = 2; CALCULOS(); break;
                }
            }
 
            // FUNCIONALIDADES NO TECLADO
            if (e.KeyValue == 8 || e.KeyValue == 13 || e.KeyValue == 27 || e.KeyValue == 110 || e.KeyValue == 187 || e.KeyValue == 188 || e.KeyValue == 194 || e.KeyValue == 46)
            {
                switch (e.KeyValue)
                {
                    case 8:
                        if (numero2 == 2) { numero2 = 1; FUNCIONALIDADES(); historico.Focus(); }
                        else if (tela.Text == "") { }
                        else { numero2 = 3; FUNCIONALIDADES(); } break;
                    case 13: if (tela.Text == "") { }
                        else { numero2 = 2; FUNCIONALIDADES(); historico.Focus(); } break;
                    case 27: numero2 = 1; FUNCIONALIDADES(); break;
                    case 46: numero2 = 1; FUNCIONALIDADES(); break;
                    case 110: if (numero2 == 2) { numero2 = 1; FUNCIONALIDADES(); historico.Focus(); }
                        else if (tela.Text == "") { }
                        else { numero2 = 5; FUNCIONALIDADES(); } break;
                    case 187: if (tela.Text == "") { }
                        else { numero2 = 2; FUNCIONALIDADES(); historico.Focus(); } break;
                    case 188: if (numero2 == 2) { numero2 = 1; FUNCIONALIDADES(); historico.Focus(); }
                        else if (tela.Text == "") { }
                        else { numero2 = 5; FUNCIONALIDADES(); } break;
                    case 194: if (numero2 == 2) { numero2 = 1; FUNCIONALIDADES(); historico.Focus(); }
                        else if (tela.Text == "") { }
                        else { numero2 = 4; FUNCIONALIDADES(); } break;
                }
            }
            historico.Focus();
        }
    }
}
