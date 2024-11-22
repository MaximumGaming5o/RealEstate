namespace RealEstate.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public UserType UserType { get; set; }

        public User(int id, string firstName, string lastName, string email, string password, string phone, string address, UserType userType)
        {
            UserId = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Phone = phone;
            Address = address;
            UserType = userType;
        }
    }
}
