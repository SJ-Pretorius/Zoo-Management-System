using PRG521_FA2.Class;
using System;
using System.Windows.Forms;

namespace PRG521_FA2
{
    /// <summary>
    /// Represents a form for feeding food to an animal.
    /// </summary>
    public partial class Eat : Form
    {
        /// <summary>
        /// The variable holding the food entered by the user.
        /// </summary>
        public string ReturnedVariable;

        /// <summary>
        /// Initializes a new instance of the Eat class.
        /// </summary>
        /// <param name="animal">The animal to feed.</param>
        public Eat(Animal animal)
        {
            InitializeComponent();
            label1.Text = $"Please enter the food you want to feed to {animal.Name}, the {animal.GetType().Name}:";
        }

        /// <summary>
        /// Handles the Click event of the button1 control for setting the ReturnedVariable for giving custom food.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    throw new Exception("Please enter food.");
                }
                else
                {
                    ReturnedVariable = textBox1.Text;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Closes the form and does'nt set a variable.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
