using System;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class UnitConverter : Form
    {

        public UnitConverter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbfrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbtype.SelectedItem == "Length")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                cbfrom.Items.Add("Centimetres");
                cbfrom.Items.Add("Metres");
                cbfrom.Items.Add("Kilometres");
                cbto.Items.Add("Centimetres");
                cbto.Items.Add("Metres");
                cbto.Items.Add("Kilometres");
            }

            if (cbtype.SelectedItem == "Temperature")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();
                cbfrom.Items.Add("Celsius");
                cbfrom.Items.Add("Fahrenheit");
                cbfrom.Items.Add("Kelvin");
                cbto.Items.Add("Celsius");
                cbto.Items.Add("Fahrenheit");
                cbto.Items.Add("Kelvin");
            }
            if (cbtype.SelectedItem == "Area")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();

                cbfrom.Items.Add("Metre");
                cbfrom.Items.Add("Inches");
                cbfrom.Items.Add("Foot");
                cbto.Items.Add("Metre");
                cbto.Items.Add("Inches");
                cbto.Items.Add("Foot");

            }
            if (cbtype.SelectedItem == "Time")
            {
                cbfrom.Items.Clear();
                cbto.Items.Clear();

                cbfrom.Items.Add("Seconds");
                cbfrom.Items.Add("Minutes");
                cbfrom.Items.Add("Hours");
                cbto.Items.Add("Seconds");
                cbto.Items.Add("Minutes");
                cbto.Items.Add("Hours");

            }

        }
        private void tbto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            if (tbfrom.Text != "")
            {

            }
            if (cbtype.SelectedItem == "Length")
            {

                if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Centimetres")
                {
                    tbto.Text = tbfrom.Text;
                }
                if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Metres")
                {
                    tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100);
                }
                if (cbfrom.SelectedItem == "Centimetres" && cbto.SelectedItem == "Kilometres")
                {
                    tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 100000);
                }

                if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Centimetres")
                {
                    tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100);
                }
                if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Metres")
                {
                    tbto.Text = tbfrom.Text;
                }
                if (cbfrom.SelectedItem == "Metres" && cbto.SelectedItem == "Kilometres")
                {
                    tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1000);
                }

            }
            if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Centimetres")
            {
                tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 100000);
            }
            if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Metres")
            {
                tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1000);
            }
            if (cbfrom.SelectedItem == "Kilometres" && cbto.SelectedItem == "Kilometres")
            {
                tbto.Text = tbfrom.Text;
            }



            if (cbtype.SelectedItem == "Temperature")
            {
                if (cbfrom.SelectedItem == "Celsius" && cbto.SelectedItem == "Fahrenheit")
                {
                    Double C = Convert.ToDouble(tbfrom.Text);
                    tbto.Text = Convert.ToString((1.8 * C) + 32);
                }
                if (cbfrom.SelectedItem == "Fahrenheit" && cbto.SelectedItem == "Celsius")
                {
                    Double F = Convert.ToDouble(tbfrom.Text);
                    Double C = (F - 32) * (5.0 / 9.0);
                    tbto.Text = Convert.ToString(C);
                }
                if (cbfrom.SelectedItem == "Fahrenheit" && cbto.SelectedItem == "Kelvin")
                {
                    Double F = Convert.ToDouble(tbfrom.Text);
                    Double K = (F - 32) * (5.0 / 9.0) + 273.15;
                    tbto.Text = Convert.ToString(K);
                }
                if (cbfrom.SelectedItem == "Kelvin" && cbto.SelectedItem == "Fahrenheit")
                {
                    Double K = Convert.ToDouble(tbfrom.Text);
                    Double F = (K - 273.15) * (9.0 / 5.0) + 32;
                    tbto.Text = Convert.ToString(F);
                }
                if (cbfrom.SelectedItem == "Celsius" && cbto.SelectedItem == "Kelvin")
                {
                    Double C = Convert.ToDouble(tbfrom.Text);
                    Double K = C + 273.15;
                    tbto.Text = Convert.ToString(K);
                }
                if (cbfrom.SelectedItem == "Kelvin" && cbto.SelectedItem == "Celsius")
                {
                    Double K = Convert.ToDouble(tbfrom.Text);
                    Double C = K - 273.15;
                    tbto.Text = Convert.ToString(C);
                }
                if (cbfrom.SelectedItem == "Celsius" && cbto.SelectedItem == "Celsius")
                {
                    tbto.Text = tbfrom.Text;
                }
                if (cbfrom.SelectedItem == "Fahrenheit" && cbto.SelectedItem == "Fahrenheit")
                {
                    tbto.Text = tbfrom.Text;
                }
                if (cbfrom.SelectedItem == "Kelvin" && cbto.SelectedItem == "Kelvin")
                {
                    tbto.Text = tbfrom.Text;
                }
            }

            if (cbtype.SelectedItem == "Area")
            {


                if (cbfrom.SelectedItem == "Metre" && cbto.SelectedItem == "Metre")
                {
                    tbto.Text = tbfrom.Text;
                }

                if (cbfrom.SelectedItem == "Metre" && cbto.SelectedItem == "Inches")
                {
                    tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 1550.003);
                }
                if (cbfrom.SelectedItem == "Metre" && cbto.SelectedItem == "Foot")
                {
                    tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 10.76391);
                }

                if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Metre")
                {
                    tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 1550.003);
                }

                if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Inches")
                {
                    tbto.Text = tbfrom.Text;
                }
                if (cbfrom.SelectedItem == "Inches" && cbto.SelectedItem == "Foot")
                {
                    tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 144);
                }


                if (cbfrom.SelectedItem == "Foot" && cbto.SelectedItem == "Metre")
                {
                    tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) / 3.281);

                    if (cbfrom.SelectedItem == "Foot" && cbto.SelectedItem == "Inches")
                    {
                        tbto.Text = Convert.ToString(Convert.ToDouble(tbfrom.Text) * 144);
                    }
                    if (cbfrom.SelectedItem == "Foot" && cbto.SelectedItem == "Foot")
                    {
                        tbto.Text = tbfrom.Text;
                    }




                    if (cbtype.SelectedItem == "Time")
                    {

                        if (cbfrom.SelectedItem == "Seconds" && cbto.SelectedItem == "Seconds")
                        {
                            tbto.Text = tbfrom.Text;
                        }
                        if (cbfrom.SelectedItem == "Seconds" && cbto.SelectedItem == "Minutes")
                        {
                            tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 60);
                        }
                        if (cbfrom.SelectedItem == "Seconds" && cbto.SelectedItem == "Hours")
                        {
                            tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 3600);
                        }


                        if (cbfrom.SelectedItem == "Minutes" && cbto.SelectedItem == "Seconds")
                        {
                            tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 60);
                        }
                        if (cbfrom.SelectedItem == "Minutes" && cbto.SelectedItem == "Minutes")
                        {
                            tbto.Text = tbfrom.Text;
                        }
                        if (cbfrom.SelectedItem == "Minutes" && cbto.SelectedItem == "Hours")
                        {
                            tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) / 60);
                        }


                        if (cbfrom.SelectedItem == "Hours" && cbto.SelectedItem == "Seconds")
                        {
                            tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 3600);
                        }
                        if (cbfrom.SelectedItem == "Hours" && cbto.SelectedItem == "Minutes")
                        {
                            tbto.Text = Convert.ToString(Decimal.Parse(tbfrom.Text) * 60);
                        }
                        if (cbfrom.SelectedItem == "Hours" && cbto.SelectedItem == "Hours")
                        {
                            tbto.Text = tbfrom.Text;
                        }

                    }
                }

                else
                {
                    tbto.Text = "";
                }

            }
        }
    }
}
