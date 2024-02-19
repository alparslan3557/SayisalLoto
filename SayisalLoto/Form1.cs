namespace SayisalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Tanim
            //Tanim
            Random random = new Random();
            int sayi, sayi2, sayi3, sayi4, sayi5, sayi6;

            sayi = random.Next(1, 50);
            sayi2 = random.Next(1, 50);
            sayi3 = random.Next(1, 50);
            sayi4 = random.Next(1, 50);
            sayi5 = random.Next(1, 50);
            sayi6 = random.Next(1, 50);
            Sayi1.Text = sayi.ToString();
            Sayi2.Text = sayi2.ToString();
            Sayi3.Text = sayi3.ToString();
            Sayi4.Text = sayi4.ToString();
            Sayi5.Text = sayi5.ToString();
            Sayi6.Text = sayi6.ToString();
            #endregion

            #region 1. Sayi
            //1.Sayi
            if (tbSayi1.Text == Sayi1.Text)
            {
                tbSayi1.BackColor = Color.Green;
            }
            else
            {
                tbSayi1.BackColor = Color.Red;
            }
            //Aralik Tanimlamasi
            if (Convert.ToInt32(tbSayi1.Text) < 1 || Convert.ToInt32(tbSayi1.Text) > 49)
            {
                MessageBox.Show("Lütfen 1-49 Arasinda Sayi Giriniz");

            }
            else
            {

            }
            #endregion

            #region 2. Sayi
            //2.Sayi
            if (tbSayi2.Text == Sayi2.Text)
            {
                tbSayi2.BackColor = Color.Green;
            }
            else
            {
                tbSayi2.BackColor = Color.Red;
            }
            //Aralik Tanimlamasi
            if (Convert.ToInt32(tbSayi2.Text) < 1 || Convert.ToInt32(tbSayi2.Text) > 49)
            {
                MessageBox.Show("Lütfen 1-49 Arasinda Sayi Giriniz");

            }
            else
            {

            }
            #endregion

            #region 3. Sayi
            //3.Sayi
            if (tbSayi3.Text == Sayi3.Text)
            {
                tbSayi3.BackColor = Color.Green;
            }
            else
            {
                tbSayi3.BackColor = Color.Red;
            }
            //Aralik tanimlamasi
            if (Convert.ToInt32(tbSayi3.Text) < 1 || Convert.ToInt32(tbSayi3.Text) > 49)
            {
                MessageBox.Show("Lütfen 1-49 Arasinda Sayi Giriniz");

            }
            else
            {

            }
            #endregion

            #region 4. Sayi
            //4. Sayi
            if (tbSayi4.Text == Sayi4.Text)
            {
                tbSayi4.BackColor = Color.Green;
            }
            else
            {
                tbSayi4.BackColor = Color.Red;
            }
            //Aralik tanimlamasi
            if (Convert.ToInt32(tbSayi4.Text) < 1 || Convert.ToInt32(tbSayi4.Text) > 49)
            {
                MessageBox.Show("Lütfen 1-49 Arasinda Sayi Giriniz");

            }
            else
            {

            }
            #endregion

            #region 5. Sayi
            //5.Sayi
            if (tbSayi5.Text == Sayi5.Text)
            {
                tbSayi5.BackColor = Color.Green;
            }
            else
            {
                tbSayi5.BackColor = Color.Red;
            }
            //Aralik Tanimalasi
            if (Convert.ToInt32(tbSayi5.Text) < 1 || Convert.ToInt32(tbSayi5.Text) > 49)
            {
                MessageBox.Show("Lütfen 1-49 Arasinda Sayi Giriniz");

            }
            else
            {

            }
            #endregion

            #region 6. Sayi
            //6.Sayi
            if (tbSayi6.Text == Sayi6.Text)
            {
                tbSayi6.BackColor = Color.Green;
            }
            else
            {
                tbSayi6.BackColor = Color.Red;
            }
            //Aralik Tanimlamasi
            if (Convert.ToInt32(tbSayi6.Text) < 1 || Convert.ToInt32(tbSayi6.Text) > 49)
            {
                MessageBox.Show("Lütfen 1-49 Arasinda Sayi Giriniz");

            }
            else
            {

            }
            #endregion



        }
        #region Sadece Sayi Tanimlamasi
        //Sadece Sayi Tanimlamasi
        private void tbSayi1_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbSayi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tbSayi3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tbSayi4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tbSayi5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tbSayi6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion


    }
}