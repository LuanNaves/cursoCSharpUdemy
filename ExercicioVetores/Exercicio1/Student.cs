using System.Globalization;

namespace Exercicio1 {
    internal class Student {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Student(string name, string email, int room) { 
            Name = name;
            Email = email;
            Room = room;
        }

        public override string ToString() {
            return Room + ": " 
                + Name + ", " 
                + Email;
        }
    }
}
