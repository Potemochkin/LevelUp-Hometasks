namespace LevelUp.CsharpJuniors.Hometasks.Lesson2.Models

{
    internal class Human
    {
        public string FirstName { get; }
        public string Surname { get; }
        public int Age { get; }
        public string Hobby { get; }
        public Human(string firstname, string surname, int age, string hobby)
        {
            FirstName = firstname;
            Surname = surname;
            Age = age;
            Hobby = hobby;
        }
        public void PrintParametrs()
        {
            Console.WriteLine($"\nHere your data\nName: {FirstName}\nSurname: {Surname}\nAge: {Age}\nHobby: {Hobby}\n\nHave a good day!");
        }
    }
}