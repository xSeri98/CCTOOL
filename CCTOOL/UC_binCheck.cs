using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTOOL
{
    public partial class UC_binCheck : UserControl
    {
        public UC_binCheck()
        {
            InitializeComponent();
        }

        private async void checkButton_Click(object sender, EventArgs e)
        {
            binCheck bin = new binCheck();

            try
            {
                if (binBox.Text.Length > 5)
                {
                    await bin.CheckBin(binBox.Text);
                    brandBox.Text = bin._cardName;
                    countryBox.Text = bin._country;
                    levelBox.Text = bin._cardLevel;
                    typeBox.Text = bin._cardType;
                    if (bin._isValid)
                    {
                        statusBox.Text = "Valid";
                    }
                    else
                    {
                        statusBox.Text = "Invalid";
                    }
                }
                else
                {
                    MessageBox.Show("Input first six digit of the card.", "Message");
                }
            }
            catch(Exception x)
            {
                MessageBox.Show("Bin may not be valid","Message");
            }
            
            //catch(Exception x)
            //{
            //    MessageBox.Show("I-check ulit","Message");
            //}
        }
    }
}
