using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            petrolName.SelectedIndex = 0;
        }

        private void petrolCountRB_CheckedChanged(object sender, EventArgs e)
        {
            var obj = (sender as RadioButton);

            if(obj.Checked && obj.Name == "petrolCountRB")
            {
                petrolTotalPay.Text = "Total payments";
                textBox7.Text = "$";
                petrolCountTB.Enabled = true;
                petrolSumTB.Enabled = false;
                petrolSumTB.Text = "0";
                
            }
            else
            {
                petrolTotalPay.Text = "To issue";
                textBox7.Text = "л.";
                petrolCountTB.Enabled = false;
                petrolSumTB.Enabled = true;
                petrolCountTB.Text = "0";
            }
        }

        private void petrolName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = sender as ComboBox;
            switch(obj.Text)
            {
                case "A-72":
                    {
                        petrolPrice.Text = "21";
                        break;
                    }
                case "A-76":
                    {
                        petrolPrice.Text = "22,40";
                        break;
                    }
                case "AI-93":
                    {
                        petrolPrice.Text = "26,70";
                        break;
                    }
                case "A-95":
                    {
                        petrolPrice.Text = "29,50";
                        break;
                    }
                case "AI-98":
                    {
                        petrolPrice.Text = "33,20";
                        break;
                    }
            }

        }
        static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if(c == ',')
                {
                    continue;
                }
                else if (c < '0' || c > '9')
                {
                    return false;
                }
                   
            }

            return true;
        }

        private void petrolCountTB_TextChanged(object sender, EventArgs e)
        {
            if(IsDigitsOnly((sender as TextBox).Text) & !String.IsNullOrEmpty((sender as TextBox).Text))
            {
                petrolTotalPayments.Text = (Convert.ToDouble((sender as TextBox).Text) * Convert.ToDouble(petrolPrice.Text)).ToString();
            }
            else
            {
                petrolTotalPayments.Text = "0";
            }
            
        }

        private void petrolSumTB_TextChanged(object sender, EventArgs e)
        {
            if(IsDigitsOnly((sender as TextBox).Text) & !String.IsNullOrEmpty((sender as TextBox).Text))
            {
                petrolTotalPayments.Text = (Convert.ToDouble((sender as TextBox).Text) / Convert.ToDouble(petrolPrice.Text)).ToString();
            }
            else
            {
                petrolTotalPayments.Text = "0";
            }
        }

        private void hotDogCB_CheckedChanged(object sender, EventArgs e)
        {
            var obj = (sender as CheckBox);
            if (obj.Checked)
            {
                switch(obj.Text)
                {
                    case "Hot-Dog":
                        {
                            hotDogNumberTB.Enabled = true;
                            break;
                        }
                    case "Hamburger":
                        {
                            hambNumberTB.Enabled = true;
                            break;
                        }
                    case "Fries":
                        {
                            friesNumberTB.Enabled = true;
                            break;
                        }
                    case "Coca-Cola":
                        {
                            cocaColaNumberTB.Enabled = true;
                            break;
                        }
                }
                
            }
            else
            {
                switch (obj.Text)
                {
                    case "Hot-Dog":
                        {
                            hotDogNumberTB.Enabled = false;
                            hotDogNumberTB.Text = "0";
                            break;
                        }
                    case "Hamburger":
                        {
                            hambNumberTB.Enabled = false;
                            hambNumberTB.Text = "0";
                            break;
                        }
                    case "Fries":
                        {
                            friesNumberTB.Enabled = false;
                            friesNumberTB.Text = "0";
                            break;
                        }
                    case "Coca-Cola":
                        {
                            cocaColaNumberTB.Enabled = false;
                            cocaColaNumberTB.Text = "0";
                            break;
                        }
                }
            }
        }

        private void hotDogNumberTB_TextChanged(object sender, EventArgs e)
        {
            if(IsDigitsOnly((sender as TextBox).Text) & !String.IsNullOrEmpty((sender as TextBox).Text))
            {
                var hotDogTotal = hotDogCB.Checked ? Convert.ToDouble(hotDogPriceTB.Text) * Convert.ToInt32(hotDogNumberTB.Text) : 0;
                var hamburgerTotal = hamburgerCB.Checked ? Convert.ToDouble(hambPriceTB.Text) * Convert.ToInt32(hambNumberTB.Text) : 0;
                var friesTotal = friesCB.Checked ? Convert.ToDouble(friesPriceTB.Text) * Convert.ToInt32(friesNumberTB.Text) : 0;
                var cocaColaTotal = cocaColaCB.Checked ? Convert.ToDouble(cocaColaPriceTB.Text) * Convert.ToInt32(cocaColaNumberTB.Text) : 0;

                cafeTotalPayments.Text = (hotDogTotal + hamburgerTotal + friesTotal + cocaColaTotal).ToString();
            }
            else
            {
                cafeTotalPayments.Text = "0";
            }
            
        }
        public void MakeFieldsDefault()
        {
            petrolName.SelectedIndex = 0;
            petrolTotalPayments.Text = "0";
            foreach(var c in PetrolStation.Controls)
            {
                if(c is TextBox && ((TextBox)c).Enabled)
                {
                    ((TextBox)c).Text = "0";
                    ((TextBox)c).Enabled = false;
                }
            }
            foreach (var c in Cafe.Controls)
            {
                if(c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
            foreach(var c in groupBox1.Controls)
            {
                if(c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }

        private void countTotalPay_Click(object sender, EventArgs e)
        {
            var petrolTruePayments = petrolCountRB.Checked ? petrolTotalPayments.Text : petrolSumTB.Text;
            totalDayPaymentsTB.Text = (Convert.ToDouble(petrolTruePayments) + Convert.ToDouble(cafeTotalPayments.Text)).ToString();
            dayPaymentsTB.Text = (Convert.ToDouble(totalDayPaymentsTB.Text) + Convert.ToDouble(dayPaymentsTB.Text)).ToString();
            totalDayPaymentsTB.Refresh();
            dayPaymentsTB.Refresh();

            System.Threading.Thread.Sleep(5000);
            Form2 form2 = new(this);
            this.Enabled = false;
            form2.Show();
        }
    }
}
