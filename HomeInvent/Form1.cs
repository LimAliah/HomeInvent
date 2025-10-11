namespace HomeInvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comboBox1 = cbxLivingR.Text;
            string comboBox2 = cbxDecor.Text;
            string comboBox3 = cbxBathL.Text;
            string comboBox4 = cbxKitch.Text;
            string ListItems = lstItems.Text;


            Button clickedButton = btnAdd;
            Button clickedButton2 = btnRem;


            if (clickedButton == btnAdd)
            {
                lstItems.Items.Add(comboBox1);
                lstItems.Items.Add(comboBox2);
                lstItems.Items.Add(comboBox3);
                lstItems.Items.Add(comboBox4);
                lstItems.ClearSelected();


            }
            else if (clickedButton2 == btnRem)
            {
                lstItems.Items.RemoveAt(0);
                lstItems.ClearSelected();

            }
        }




        private void cbxDecor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            string comboBox1 = cbxLivingR.Text;
            string comboBox2 = cbxDecor.Text;
            string comboBox3 = cbxBathL.Text;
            string comboBox4 = cbxKitch.Text;
            string ListItems = lstItems.Text;


            Button clickedButton = btnAdd;
            Button clickedButton2 = btnRem;


            if (clickedButton2 == btnRem)
            {
                lstItems.Items.RemoveAt(0);
                lstItems.ClearSelected();

            }
        }
    }
}


