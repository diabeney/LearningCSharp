
namespace Inheritance {
    class Mammals {

        private string name;
        private int numberOfLegs;
        private bool hasEyes;

        public int NumberOfLegs {
            get { return numberOfLegs; }
            set { numberOfLegs = value; }
        }

        public bool HasEyes { get; set;}
        public Mammals(string name) {
            this.name = name;
        }
        public bool isColdBlooded() {
            return true;
        }

        public string modeOfReproduction() {
            return "By birth";
        }
        
    }

    class Horse: Mammals {
        public Horse(string name) 
            : base(name) {
            }

        public string  ModeOfMovement() {
            return "By Jumping";
        }

    }
}