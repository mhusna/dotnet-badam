namespace Events_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if(control is Button)
                    control.Click += Control_Click;
            }
        }

        private void Control_Click(object? sender, EventArgs e)
        {
            tbxDisplay.Text += ((Button)sender).Text;
        }
    }
}