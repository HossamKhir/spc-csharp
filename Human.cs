using System;

namespace Classes
{
    public class Human
    {
        private string _forename;
        private string _surname;

        // INFO: by default, each class would have an empty default constructor
        //  unless at one new constructor is defined

        // INFO: constructors have no return type, but they still do have access modifiers
        public Human(string forename, string surname)
        {
            this._forename = forename;
            this._surname = surname;
        }

        public void IntroduceYourself()
        {
            System.Console.WriteLine($"My name is {_surname}, {_forename} {_surname}!");
        }
    }
}