namespace PRG521_FA2
{
    /// <summary>
    /// Represents a form for entering an animal's name and age.
    /// </summary>
    public partial class AnimalNameAge : Form
    {
        /// <summary>
        /// The name of the animal entered by the user.
        /// </summary>
        public string animalName;

        /// <summary>
        /// The age of the animal entered by the user.
        /// </summary>
        public decimal animalAge;

        /// <summary>
        /// Initializes a new instance of the AnimalNameAge class.
        /// </summary>
        public AnimalNameAge()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set's name and age of animal from form.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            animalName = textBox1.Text;
            animalAge = numericUpDown1.Value;
            try
            {
                if (animalName == "") //Make sure a animal name is given, a animal can't be nameless.
                {
                    throw new Exception("Please enter an animal name.");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Closes form.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
