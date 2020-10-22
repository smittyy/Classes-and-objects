using System;

namespace DatingProfile
{
    class Profile
    {
        private string firstname;
        private string lastname;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;
        private string willWalkDogs;

        public Profile(string firstname, string lastname, int age, string city = "", string country = "", string pronouns = "they/them", string willWalkDogs = "")
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.willWalkDogs = willWalkDogs;
        }

        public Profile()
        { }


        public string ViewProfile()
        {
            string bio = ($"Name: {firstname} {lastname}\nAge: {age}\nCity: {city}\nCountry: {country}\nGender: {pronouns}");


            if (this.hobbies.Length != 0)
            {
                foreach (string s in this.hobbies)
                {
                    bio += $"\nHobbies: {s}";
                }
            }

            return age < 18 ? "You are not of age to view this profile" : bio;
        }

        public void SetHobbies(string[] hobbies) => this.hobbies = hobbies;

        public string MaleOrFemale(string s) => s == "MALE" ? "Male" : "Female";
    }
}
