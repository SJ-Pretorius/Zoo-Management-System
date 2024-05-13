using System;
using System.Windows.Forms;

namespace PRG521_FA2
{
    /// <summary>
    /// Represents a form for selecting the type of animal based on habitat.
    /// </summary>
    public partial class AnimalType : Form
    {
        /// <summary>
        /// The type of animal selected by the user.
        /// </summary>
        public string animalType;

        /// <summary>
        /// Initializes a new instance of the AnimalType class.
        /// </summary>
        /// <param name="habitat">The habitat of the animal (e.g., "Land" or "Sea").</param>
        public AnimalType(string habitat)
        {
            InitializeComponent();
            if (habitat == "Land")
            {
                // Set button text for land habitat.
                button2.Text = "Lion";
                button3.Text = "Parrot";
                button4.Text = "Turtle";
            }
            else if (habitat == "Sea")
            {
                // Set button text for sea habitat.
                button2.Text = "Fish";
                button3.Text = "Dolphin";
                button4.Text = "Prawn";
            }
        }

        /// <summary>
        /// Handles the Click event for selecting a animal.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            animalType = button2.Text;
            Close();
        }

        /// <summary>
        /// Handles the Click event for selecting a animal.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            animalType = button3.Text;
            Close();
        }

        /// <summary>
        /// Handles the Click event for selecting a animal.
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            animalType = button4.Text;
            Close();
        }

        /// <summary>
        /// Handles the Click event for selecting a animal.
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            animalType = button6.Text;
            Close();
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
