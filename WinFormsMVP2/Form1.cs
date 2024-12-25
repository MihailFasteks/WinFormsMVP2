namespace WinFormsMVP2
{
    public partial class Form1 : Form, IListView
    {
        public string BookName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Author
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string Genr
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string Year
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string Data
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public event EventHandler<EventArgs> AddRemove;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var invocationList = AddRemove.GetInvocationList();
            try
            {
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                invocationList[0]?.DynamicInvoke(this, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var invocationList = AddRemove.GetInvocationList();
            try
            {
                // Представление оповещает подписчиков (Презентер) о событии нажатия на кнопку
                invocationList[1]?.DynamicInvoke(this, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
