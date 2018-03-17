using System;
namespace FirstTest
{
    public class person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void eat()  {  } 
        public void poop()  {  } 
        public person() { }
        public walkable walkableBehaviour { get; set; }
        public person(string name, int age, walkable WalkableBehaviour)
        {
            Name = name;
            Age = age;
            walkableBehaviour = WalkableBehaviour;
        }
    }
}
