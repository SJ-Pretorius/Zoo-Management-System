using PRG521_FA2.Class;
using PRG521_FA2.Code;
using System.Text;

namespace PRG521_FA2
{
    public partial class MainGUI : Form
    {
        private Controller animalManager = new Controller();
        public MainGUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Refreshes the list of animals in the checked list box.
        /// </summary>
        private void RefreshList()
        {
            checkedListBox1.Items.Clear();
            Dictionary<int, Animal> dict = animalManager.GetAnimal();

            foreach (KeyValuePair<int, Animal> animalPair in dict)
            {
                int id = animalPair.Key;
                Animal animal = animalPair.Value;
                string typeName = animal.GetType().Name;
                if (typeName == "Animal" || typeName == "Land" || typeName == "Sea")
                {
                    typeName = "Other"; //Set's it to Other if no specific animal is chosen
                }
                List<string> characters = animal.characteristics;
                StringBuilder stringBuilder = new StringBuilder();
                foreach (string character in characters) //Builds the characteristics string
                {
                    stringBuilder.Append(character);
                    stringBuilder.Append(", ");
                }

                checkedListBox1.Items.Add($"ID: {id} | Habitat: {animal.Habitat} | Animal: {typeName} | Name: {animal.Name} | Age: {animal.Age} | Characteristics: {stringBuilder}");
            }
        }

        /// <summary>
        /// Event handler for the "Add Animal" button click.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            while (true)
            {
                AnimalHabitat habitatForm = new AnimalHabitat();
                habitatForm.ShowDialog();
                string habitat = habitatForm.animalHabitat;
                if (habitat == null)
                {
                    break;
                }
                string type;
                if (habitat != "Other") //Don't select a specfic animal is Habitat is set to other instead set animal type also to other
                {
                    AnimalType typeForm = new AnimalType(habitat);
                    typeForm.ShowDialog();
                    type = typeForm.animalType;
                    if (type == null)
                    {
                        break;
                    }
                }
                else
                {
                    type = "Other";
                }
                AnimalNameAge nameForm = new AnimalNameAge();
                nameForm.ShowDialog();
                string name = nameForm.animalName;
                if (name == null)
                {
                    break;
                }
                decimal age = nameForm.animalAge;
                animalManager.AddAnimals(habitat, type, name, age);
                listBox1.Items.Add($"The animal {name} has been added above.");
                RefreshList();
                break;
            }
        }

        /// <summary>
        /// Event handler for the "Eat" button click.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (object item in checkedListBox1.CheckedItems)
            {
                Animal animal = animalManager.GetAnimal(item);
                Eat eatForm = new Eat(animal);
                eatForm.ShowDialog();
                string food = eatForm.ReturnedVariable;
                if (food == null) //Allow a specific food choice otherwise use default food choice
                {
                    listBox1.Items.Add(animal.Eat());
                }
                else
                {
                    listBox1.Items.Add(animal.Eat(food));
                }
            }
        }

        /// <summary>
        /// Event handler for the "Speak" button click.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (object item in checkedListBox1.CheckedItems)
            {
                Animal animal = animalManager.GetAnimal(item);
                listBox1.Items.Add(animal.Speak());
            }
        }

        /// <summary>
        /// Event handler for the "Move" button click.
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (object item in checkedListBox1.CheckedItems)
            {
                Animal animal = animalManager.GetAnimal(item);
                listBox1.Items.Add(animal.Move());
            }
        }

        /// <summary>
        /// Event handler for the "Sleep" button click.
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (object item in checkedListBox1.CheckedItems)
            {
                Animal animal = animalManager.GetAnimal(item);
                listBox1.Items.Add(animal.Sleep());
            }
        }

        /// <summary>
        /// Event handler for the "Feed" button click.
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (object item in checkedListBox1.CheckedItems)
            {
                Animal animal = animalManager.GetAnimal(item);
                listBox1.Items.Add(animal.Feed());
            }
        }

        /// <summary>
        /// Event handler for the "Remove" button click.
        /// </summary>
        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (object item in checkedListBox1.CheckedItems)
            {
                Animal animal = animalManager.GetAnimal(item);
                animalManager.RemoveAnimal(item);
                listBox1.Items.Add($"The animal {animal.Name} has been removed.");
            }
            RefreshList();
        }
    }
}
