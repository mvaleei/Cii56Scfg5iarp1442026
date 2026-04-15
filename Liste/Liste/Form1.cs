namespace Liste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il nuemro di città presenti nella lista è:" + cmb_citta.Items.Count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La città selezionata dalla lista è:" + cmb_citta.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("L'indice della voce selezionata è:" + cmb_citta.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool inserisci = true;
            for (int i = 0; i < cmb_citta.Items.Count; i++)
            {
                //MessageBox.Show("Posizione n." + i);
                cmb_citta.SelectedIndex = i;
                //MessageBox.Show("Il valore della posizione è: " + cmb_citta.SelectedItem);

                if (cmb_citta.SelectedItem.ToString().ToLower() == txt_nuova.Text.ToLower()) // == "pordenone")
                {
                    inserisci = false;
                }
            }


            if (inserisci == true)  // (inserisci)
            {
                cmb_citta.Items.Add(txt_nuova.Text);// "Pordenone");
            }
            else
            {
                MessageBox.Show("Attenzione città esistente. Non'è possibile inserirla");
            }
            //
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmb_citta.SelectedIndex = 1;
        }

        private void cmb_citta_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmb_citta.SelectedIndex.ToString() + "-" + cmb_citta.SelectedItem.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chk_nazionalita.Checked.ToString());
        }

        private void chk_nazionalita_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(chk_nazionalita.Checked.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Controls.Count.ToString());
            for (int i =0; i< this.Controls.Count; i++)
            {
                //MessageBox.Show(i.ToString());
                MessageBox.Show(this.Controls[i].Text);
            }
        }
    }
}
