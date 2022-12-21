using System;

namespace Classes
{
    class Human
    {
        // INFO: both variables & functions inside a class are called members
        // INFO: classes have something called access modifiers, that controls
        //  what could be seen from outside the class scope, and how 
        //  (if possible) could that be changed:
        // the `public` modifier means the member is accessible from any given 
        //  scope
        // `private` means the member is only accessible inside the class or its 
        //  children
        // `protected` keeps the member accessible only by the class

        // INFO: variables in classes are called attributes/properties
        public string Forename;
        public string Surname;

        // INFO: functions inside classes are called methods/behaviour
        public void IntroduceYourself()
        {
            System.Console.WriteLine($"My name is {Surname}, {Forename} {Surname}!");
        }
    }
}