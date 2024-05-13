using System;
using System.Windows.Forms;

namespace PRG521_FA2
{
    /// <summary>
    /// Represents a form for selecting the habitat of an animal.
    /// </summary>
    public partial class AnimalHabitat : Form
    {
        /// <summary>
        /// The habitat selected by the user.
        /// </summary>
        public string animalHabitat;

        /// <summary>
        /// Initializes a new instance of the AnimalHabitat class.
        /// </summary>
        public AnimalHabitat()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes form.
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Set's animalHabitat to Land.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            animalHabitat = "Land";
            Close();
        }

        /// <summary>
        /// Set's animalHabitat to Sea.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            animalHabitat = "Sea";
            Close();
        }

        /// <summary>
        /// /// Set's animalHabitat to Other.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            animalHabitat = "Other";
            Close();
        }
    }
}
