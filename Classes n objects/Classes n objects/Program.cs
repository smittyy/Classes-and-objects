﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Object of Your Affection");

            Console.Write("Please enter First Name:");
            string firstName = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(firstName))
            {
                Console.Write("Sorry, didn't understand.  What is your First Name?: ");
                firstName = Console.ReadLine();
            }

            Console.Write("Please enter Last Name:");
            string lastName = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(lastName))
            {
                Console.Write("Sorry, didn't understand.  What is your Last Name?: ");
                firstName = Console.ReadLine();
            }

            Console.Write("Please enter your Age:");
            string age = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(age))
            {
                Console.Write("Sorry, didn't understand.  What is your Age?: ");
                firstName = Console.ReadLine();
            }

            int iAge;
            while (!Int32.TryParse(age, out iAge))
            {
                Console.WriteLine("Please respond with a number for your age:");
                Console.Write("Please enter your Age:");
                age = Console.ReadLine();
            }

            Console.Write("Please enter your City:");
            string city = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(city))
            {
                Console.Write("Sorry, didn't understand.  What is your City?: ");
                city = Console.ReadLine();
            }

            Console.Write("Please enter your Country:");
            string country = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(country))
            {
                Console.Write("Sorry, didn't understand.  What is your Country?: ");
                country = Console.ReadLine();
            }

            Console.Write("Will you walk your dogs");
            string willWalkDogs = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(willWalkDogs))
            {
                Console.Write("Sorry, didn't understand.  What is your Country?: ");
                country = Console.ReadLine();
            }

            Console.Write("Please enter your Gender:");
            string gender = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(gender))
            {
                Console.Write("Sorry, what is your Gender?: ");
                gender = Console.ReadLine();
            }

            gender = gender.ToUpper();
            while (gender != "MALE" && gender != "FEMALE")
            {
                Console.Write("Sorry, didn't understand.  What is your Gender?: ");
                gender = Console.ReadLine().ToUpper();
            }

            var g = new Profile();
            gender = g.MaleOrFemale(gender);

            Console.Write("What are your hobbies?:");
            string s = Console.ReadLine();
            string[] hobbys = s.Split(' ').ToList().ToArray();

            Profile sam = new Profile(firstName, lastName, iAge, city, country, gender);

            if (hobbys != null)
            {
                sam.SetHobbies(hobbys);
            }


            Console.WriteLine(sam.ViewProfile());
        }
    }
}