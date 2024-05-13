using PRG521_FA2.Class;
using System.Collections.Generic;

namespace PRG521_FA2.Code
{
    /// <summary>
    /// Controller class responsible for managing animals.
    /// </summary>
    internal class Controller
    {
        private Dictionary<int, Animal> animals = new Dictionary<int, Animal>();
        private int nextID = 1;

        /// <summary>
        /// Adds a new animal to the collection based on habitat, type, name, and age.
        /// </summary>
        /// <param name="habitat">The habitat of the animal.</param>
        /// <param name="type">The type of the animal.</param>
        /// <param name="name">The name of the animal.</param>
        /// <param name="age">The age of the animal.</param>
        public void AddAnimals(string habitat, string type, string name, decimal age)
        {
            Animal newAnimal;

            // Create the appropriate subclass of Animal based on habitat and type
            switch (habitat)
            {
                case "Land":
                    newAnimal = CreateLandAnimal(type, name, age);
                    break;
                case "Sea":
                    newAnimal = CreateSeaAnimal(type, name, age);
                    break;
                default:
                    newAnimal = new Animal { Habitat = habitat, Name = name, Age = age };
                    break;
            }

            int id = nextID++;
            animals.Add(id, newAnimal);
        }

        // Helper method to create land animals
        private Animal CreateLandAnimal(string type, string name, decimal age)
        {
            switch (type)
            {
                case "Lion":
                    return new Lion { Habitat = "Land", Name = name, Age = age };
                case "Parrot":
                    return new Parrot { Habitat = "Land", Name = name, Age = age };
                case "Turtle":
                    return new Turtle { Habitat = "Land", Name = name, Age = age };
                default:
                    return new Land { Habitat = "Land", Name = name, Age = age };
            }
        }

        // Helper method to create sea animals
        private Animal CreateSeaAnimal(string type, string name, decimal age)
        {
            switch (type)
            {
                case "Fish":
                    return new Fish { Habitat = "Sea", Name = name, Age = age };
                case "Dolphin":
                    return new Dolphin { Habitat = "Sea", Name = name, Age = age };
                case "Prawn":
                    return new Prawn { Habitat = "Sea", Name = name, Age = age };
                default:
                    return new Sea { Habitat = "Sea", Name = name, Age = age };
            }
        }

        /// <summary>
        /// Removes an animal from the collection.
        /// </summary>
        /// <param name="item">The animal to be removed.</param>
        public void RemoveAnimal(object item)
        {
            int key = RetrieveKeyFromList(item);
            animals.Remove(key);
        }

        /// <summary>
        /// Retrieves the collection of animals.
        /// </summary>
        /// <returns>The collection of animals.</returns>
        public Dictionary<int, Animal> GetAnimal()
        {
            return animals;
        }

        /// <summary>
        /// Retrieves a specific animal from the collection based on the provided object from the list.
        /// </summary>
        /// <param name="item">The object from the list representing the animal.</param>
        /// <returns>The animal object.</returns>
        public Animal GetAnimal(object item)
        {
            int key = RetrieveKeyFromList(item);
            Animal animal = animals[key];
            return animal;
        }

        // Retrieves the key of the animal from the list item
        private int RetrieveKeyFromList(object item)
        {
            string itemText = item.ToString();
            int startIndex = itemText.IndexOf("ID:") + 4;
            int endIndex = itemText.IndexOf("|", startIndex);
            string idString = itemText.Substring(startIndex, endIndex - startIndex).Trim();
            int key = int.Parse(idString);
            return key;
        }
    }
}
