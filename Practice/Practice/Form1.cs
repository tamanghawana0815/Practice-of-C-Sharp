namespace Practice
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Romiya Dangol", "Manamaiju", "9856556");
            dataGridView1.Rows.Add("Sama Nemkul", "Lubhu", "10000");
            dataGridView1.Rows.Add("Dipesh Adhikari", "Thali", "2454455");
        }
    }
}