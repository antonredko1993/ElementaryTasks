using System;
using System.Collections.Generic;
using System.Text;

namespace ElementaryTasks
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string GetUserData()
        {
            int age = GetAge(DateOfBirth);
            return $"{FirstName} {LastName} {age}";
        }
        public int GetAge(DateTime DateOfBirth)
        {
            var now = DateTime.Today;
            return now.Year - DateOfBirth.Year;
        }
}
}
