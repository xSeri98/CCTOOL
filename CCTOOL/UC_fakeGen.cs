using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTOOL
{
    public partial class UC_fakeGen : UserControl
    {
 
        public UC_fakeGen()
        {
            InitializeComponent();

            List<string> nationality = new List<string>();
            var nat = "US,BR,CA,CH,DE,DK,ES,FI,FR,GB,IE,IN,IR,MX,NL,NO,NZ,RS,TR,UA,AU";

            foreach (string nats in nat.Split(','))
            {
                nationality.Add(nats);
            }

            natBox.DataSource = nationality;
            
        }

        private async void genButton_Click(object sender, EventArgs e)
        {
            string nat = natBox.Text.ToLower();
            

            Handshaker handshake = new Handshaker();
            //try
            //{

            await    handshake.HandShakeAsync(nat);
                
                    fnameBox.Text = handshake._fname;
                    lnameBox.Text = handshake._lname;
                    phoneBox.Text = new string(handshake._phoneNumber.Where(x => char.IsDigit(x)).ToArray());
                    streetBox.Text = handshake._street;
                    postCodeBox.Text = handshake._postCode;
                    countryBox.Text = handshake._country;
                    stateBox.Text = handshake._state;
                    cityBox.Text = handshake._city;
                
            //}
            //catch (Exception x)
            //{
            //    MessageBox.Show("I-generate muli","Message");
                
            //}
        }
    }
}
