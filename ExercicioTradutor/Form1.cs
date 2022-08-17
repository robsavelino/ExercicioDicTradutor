namespace ExercicioTradutor
{
    public partial class ExercicioTradutor : Form
    {
        public ExercicioTradutor()
        {
            InitializeComponent();
        }

        private void txbInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Services.StartDictionary(dic);
            lblOutput.Text = Services.TranslatePhrase(dic, txbInput.Text.ToLower());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbInput.Clear();
            lblOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }
    }
}