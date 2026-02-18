namespace lab1
{
    class Animal
    {
        private string _name;
        private int _age;
        private int _limbsCount;
        private TypeAnimal _typeAnimal;
        private LivingEnv _livingEnv;
        private Continents _continent;

        public Animal()
        {
            _name = "медведь";
            _age = 10;
            _limbsCount = 4;
            _typeAnimal = TypeAnimal.Mammal;
            _livingEnv = LivingEnv.Ground;
            _continent = Continents.Eurasia;
        }

        public Animal(string name, int age, int limbsCount, TypeAnimal typeAnimal,
        LivingEnv livingEnv, Continents continent)
        {
            _name = name;
            _age = age;
            _limbsCount = limbsCount;
            _typeAnimal = typeAnimal;
            _livingEnv = livingEnv;
            _continent = continent;
        }

        public string GetSound()
        {
          return "звук";
        }
        public bool CanFly()
        {
          if(_typeAnimal == TypeAnimal.Bird)
          {
            return true;
          }
          return false;
        }

        public bool CanSwim()
        {
          if(_typeAnimal == TypeAnimal.Fish || _typeAnimal == TypeAnimal.Amphibian)
          {
            return true;
          }
          return false;
        }

        public bool ExistTail()
        {
          if(_typeAnimal == TypeAnimal.Reptile || _typeAnimal == TypeAnimal.Amphibian)
          {
            return true;
          }
          return false;
        }

        public static bool operator ==(Animal animal1, Animal animal2)
        {
            return (animal1._name == animal2._name &&
                   animal1._age == animal2._age &&
                   animal1._limbsCount == animal2._limbsCount &&
                   animal1._typeAnimal == animal2._typeAnimal &&
                   animal1._livingEnv == animal2._livingEnv &&
                   animal1._continent == animal2._continent) ? true : false;
        }

        public static bool operator !=(Animal animal1, Animal animal2)
        {
            return (animal1._name == animal2._name &&
                   animal1._age == animal2._age &&
                   animal1._limbsCount == animal2._limbsCount &&
                   animal1._typeAnimal == animal2._typeAnimal &&
                   animal1._livingEnv == animal2._livingEnv &&
                   animal1._continent == animal2._continent) ? false : true;
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public int Age
        {
            set { _age = value; }
            get { return _age; }
        }

        public int LimbsCount
        {
            set { _limbsCount = value; }
            get { return _limbsCount; }
        }

        public TypeAnimal TypeAnimal
        {
            set { _typeAnimal = value; }
            get { return _typeAnimal; }
        }

        public LivingEnv LivingEnv
        {
            set { _livingEnv = value; }
            get { return _livingEnv; }
        }

        public Continents Continent
        {
            set { _continent = value; }
            get { return _continent; }
        }
  }
}