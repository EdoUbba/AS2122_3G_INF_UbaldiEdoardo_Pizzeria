namespace AS2122_3G_INF_UbaldiEdoardo_Pizzeria
{
    public partial class frmMain : Form
    {
        int[] arrayPizza = new int[3];
        int tipoPizza;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            if(btnOrdina.Text != "")
            {
                switch (cmbPizza.Text)
                {
                    case "Margherita":
                        tipoPizza = 0;
                        break;
                    case "4 Stagioni":
                        tipoPizza = 1;
                        break;
                    case "Verdure":
                        tipoPizza = 2;
                        break;
                }
                arrayPizza[tipoPizza] += Convert.ToInt32(txtQuant.Text);
            }
        }
    }
}