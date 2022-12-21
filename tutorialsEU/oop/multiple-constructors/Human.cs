using System;

namespace Classes
{
    public class Human
    {
        private string _forename;
        private string _surname;
        private string _eyeColour;
        private int _age;

        // INFO: by default, each class would have an empty default constructor
        //  unless at one new (optionally parametrised) constructor is defined

        public Human()
        {
            // INFO: default empty constructor
        }

        // INFO: constructors have no return type, but they still do have access modifiers
        public Human(string forename, string surname)
        {
            this._forename = forename;
            this._surname = surname;
        }
        // INFO: constructors can be overloaded
        public Human(string forename, string surname, string eyeColour, int age)
        : this(forename, surname) // NOTE: you may want to use other constructors, this is the syntax to how to do that
        {
            this._eyeColour = eyeColour;
            this._age = age;
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is {_surname}, {_forename} {_surname}!");
        }
    }
}