namespace PRG521_FA2.Class
{
    /// <summary>
    /// Base class representing an animal.
    /// </summary>
    public class Animal : Interfaces.IFeedable, Interfaces.IMovable
    {
        /// <summary>
        /// The habitat of the animal.
        /// </summary>
        public required string Habitat { get; set; }

        /// <summary>
        /// The name of the animal.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// The age of the animal.
        /// </summary>
        public required decimal Age { get; set; }

        /// <summary>
        /// List of characteristics of the animal.
        /// </summary>
        public List<string> characteristics = new List<string>();

        /// <summary>
        /// Initializes a new instance of the Animal class, aka creating a new Animal.
        /// </summary>
        public Animal()
        {
            AddCharacteristic("Animal");
        }

        /// <summary>
        /// Adds a characteristic to the animal.
        /// </summary>
        /// <param name="characteristic">The characteristic to add.</param>
        protected void AddCharacteristic(string characteristic)
        {
            characteristics.Add(characteristic);
        }

        public virtual string Eat()
        {
            return $"{Name}, the animal is eating.";
        }

        public virtual string Eat(string food)
        {
            return $"{Name}, the animal is eating {food}.";
        }

        public virtual string Sleep()
        {
            return $"{Name}, the animal is sleeping.";
        }

        public virtual string Speak()
        {
            return $"{Name}, the animal makes a sound.";
        }

        public virtual string Move()
        {
            return $"{Name}, the animal is moving.";
        }

        public virtual string Feed()
        {
            return $"{Name}, the animal is being fed.";
        }
    }


    public class Land : Animal, Interfaces.IFeedable, Interfaces.IMovable
    {
        /// <summary>
        /// Initializes a new instance of the Land class, aka creating a new Land Animal.
        /// </summary>
        public Land()
        {
            AddCharacteristic("Lives on land");
        }

        public override string Eat()
        {
            return $"{Name}, the land animal is eating.";
        }

        public override string Eat(string food)
        {
            return $"{Name}, the land animal is eating {food}.";
        }

        public override string Sleep()
        {
            return $"{Name}, the land animal is sleeping.";
        }

        public override string Speak()
        {
            return $"{Name}, the land animal makes a sound.";
        }

        public override string Move()
        {
            return $"{Name}, the land animal is moving.";
        }

        public override string Feed()
        {
            return $"{Name}, the land animal is being fed.";
        }
    }


    public class Lion : Land, Interfaces.IFeedable, Interfaces.IMovable
    {
        /// <summary>
        /// Initializes a new instance of the Lion class, aka creating a new Lion.
        /// </summary>
        public Lion()
        {
            AddCharacteristic("Lion");
        }

        public override string Speak()
        {
            return $"{Name}, the lion roars!";
        }

        public override string Eat()
        {
            return $"{Name}, the lion eats meat.";
        }

        public override string Eat(string food)
        {
            return $"{Name}, the lion is eating {food}.";
        }

        public override string Move()
        {
            return $"{Name}, the lion is running.";
        }

        public override string Feed()
        {
            return $"{Name}, the lion is feeding on meat.";
        }

        public override string Sleep()
        {
            return $"{Name}, the lion is sleeping.";
        }
    }


    public class Parrot : Land, Interfaces.IFeedable, Interfaces.IMovable
    {
        /// <summary>
        /// Initializes a new instance of the Parrot class, aka creating a new Parrot.
        /// </summary>
        public Parrot()
        {
            AddCharacteristic("Parrot");
        }

        public override string Speak()
        {
            return $"{Name}, the parrot squawks!";
        }

        public override string Move()
        {
            return $"{Name}, the parrot is flying.";
        }

        public override string Eat()
        {
            return $"{Name}, the parrot is eating.";
        }

        public override string Eat(string food)
        {
            return $"{Name}, the parrot is eating {food}.";
        }

        public override string Feed()
        {
            return $"{Name}, the parrot is feeding on seeds.";
        }

        public override string Sleep()
        {
            return $"{Name}, the parrot is sleeping.";
        }
    }


    public class Turtle : Land, Interfaces.IFeedable, Interfaces.IMovable
    {
        /// <summary>
        /// Initializes a new instance of the Turtle class, aka creating a new Turtle.
        /// </summary>
        public Turtle()
        {
            AddCharacteristic("Turtle");
        }

        public override string Move()
        {
            return $"{Name}, the turtle slowly crawls.";
        }

        public override string Eat()
        {
            return $"{Name}, the turtle is eating food.";
        }

        public override string Eat(string food)
        {
            return $"{Name}, the turtle is eating {food}.";
        }

        public override string Speak()
        {
            return $"{Name}, the turtle is making subtle sounds.";
        }

        public override string Feed()
        {
            return $"{Name}, the turtle is feeding on cabbage.";
        }

        public override string Sleep()
        {
            return $"{Name}, the turtle is sleeping.";
        }
    }


    public class Sea : Animal, Interfaces.IFeedable, Interfaces.IMovable
    {
        /// <summary>
        /// Initializes a new instance of the Sea class, aka creating a new Sea Animal.
        /// </summary>
        public Sea()
        {
            AddCharacteristic("Lives in the sea");
        }
        public override string Eat()
        {
            return $"{Name}, the sea animal is eating.";
        }

        public override string Eat(string food)
        {
            return $"{Name}, the sea animal is eating {food}.";
        }

        public override string Sleep()
        {
            return $"{Name}, the sea animal is sleeping.";
        }

        public override string Speak()
        {
            return $"{Name}, the sea animal makes a sound.";
        }

        public override string Move()
        {
            return $"{Name}, the sea animal is swimming/crawling.";
        }

        public override string Feed()
        {
            return $"{Name}, the sea animal is being fed.";
        }
    }


    public class Fish : Sea, Interfaces.IFeedable, Interfaces.IMovable
    {
        /// <summary>
        /// Initializes a new instance of the Fish class, aka creating a new Fish.
        /// </summary>
        public Fish()
        {
            AddCharacteristic("Fish");
        }
        public override string Move()
        {
            return $"{Name}, the fish is swimming.";
        }

        public override string Eat()
        {
            return $"{Name}, the fish is eating food.";
        }

        public override string Eat(string food)
        {
            return $"{Name}, the fish is eating {food}.";
        }

        public override string Speak()
        {
            return $"{Name}, the fish is making subtle sounds.";
        }

        public override string Feed()
        {
            return $"{Name}, the fish is feeding on pellets.";
        }

        public override string Sleep()
        {
            return $"{Name}, the fish is sleeping.";
        }
    }


    public class Dolphin : Sea, Interfaces.IFeedable, Interfaces.IMovable
    {
        /// <summary>
        /// Initializes a new instance of the Dolphin class, aka creating a new Dolphin.
        /// </summary>
        public Dolphin()
        {
            AddCharacteristic("Dolphin");
        }

        public override string Move()
        {
            return $"{Name}, the dolphin is swimming.";
        }

        public override string Eat()
        {
            return $"{Name}, the dolphin is eating food.";
        }

        public override string Eat(string food)
        {
            return $"{Name}, the dolphin is eating {food}.";
        }

        public override string Speak()
        {
            return $"{Name}, the dolphin is making squealing sounds.";
        }

        public override string Feed()
        {
            return $"{Name}, the dolphin is feeding on food fish.";
        }

        public override string Sleep()
        {
            return $"{Name}, the dolphin is sleeping.";
        }
    }


    public class Prawn : Sea, Interfaces.IFeedable, Interfaces.IMovable
    {
        /// <summary>
        /// Initializes a new instance of the Prawn class, aka creating a new Prawn.
        /// </summary>
        public Prawn()
        {
            AddCharacteristic("Prawn");
        }

        public override string Move()
        {
            return $"{Name}, the prawn is crawling.";
        }

        public override string Eat()
        {
            return $"{Name}, the prawn is eating food.";
        }

        public override string Eat(string food)
        {
            return $"{Name}, the prawn is eating {food}.";
        }

        public override string Speak()
        {
            return $"{Name}, the prawn is making subtle sounds.";
        }

        public override string Feed()
        {
            return $"{Name}, the prawn is feeding on dead insects.";
        }

        public override string Sleep()
        {
            return $"{Name}, the prawn is sleeping.";
        }
    }
}