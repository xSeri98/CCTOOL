namespace CCTOOL
{
    public partial class UC_genCards : UserControl
    {
        public UC_genCards()
        {
            InitializeComponent();
            if (genAmount.Text.Equals("Amount"))
            {
                genAmount.ForeColor = Color.Gray;
            }

            List<string> year = new List<string>();
            year = GenClass.listYear();
            yearCBox.DataSource = year;

            List<string> month = new List<string>();
            month = GenClass.listMonth();
            monthCBox.DataSource = month;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (outputCC.Lines.Length > 0)
            {
                Clipboard.SetText(outputCC.Text);
                //outputCC.SelectAll();
                //outputCC.SelectionBackColor = Color.LightBlue;
                MessageBox.Show("Copied!", "Clipboard");
            }
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            if (genAmount.Text.All(x => Char.IsDigit(x)) && !String.IsNullOrEmpty(genAmount.Text))
            {
                outputCC.Lines = GenClass.ToGenerate(inputCC, Convert.ToInt32(genAmount.Text), yearCBox.Text, monthCBox.Text, cvvInput.Text);
            }
            else
            {
                MessageBox.Show("Numbers lang pwede sa amount hehe", "Amount Error");
            }
        }

        private void genAmount_TextChanged(object sender, EventArgs e)
        {
            if (genAmount.Text.All(x => Char.IsDigit(x)))
            {
                genAmount.ForeColor = Color.Black;
            }
            else
            {
                genAmount.ForeColor = Color.Gray;
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
           inputCC.Clear();
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] result = new string[outputCC.Lines.Length];
            int index = 0;
            List<string> cards = new List<string>();

            foreach(string card in outputCC.Lines)
            {
                cards.Add(card);
            }

            cards = cards.OrderBy(x => rand.Next()).ToList();
            outputCC.Clear();

            foreach(string shuffledcards in cards)
            {
                result[index] = shuffledcards;
                index++;
            }

            outputCC.Lines = result;
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            List<string> cards = new List<string>();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files (*.txt)|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string temp = string.Empty;
            
                using (StreamReader sr = new StreamReader(openFile.FileName))
                {
                    while((temp = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(temp))
                        {
                            string card = string.Empty;
                            if (temp.Contains(','))
                            {
                                int index = temp.IndexOf(',');
                                card = temp.Substring(0, index);
                            }
                            else
                            {
                                card = temp;
                            }
                            cards.Add(card);
                        }
                    }
                    sr.Close();
                }
                
                string[] results = new string[cards.Count];
                int _indexResults = 0;
                foreach(string card in cards)
                {
                    results[_indexResults] = card;
                    _indexResults++;
                }
                inputCC.Lines = results;
               
            }

        }
    }
}
