namespace RealEstate.Models
{
    public class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string phone;
        private string address;

        public int UserId
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName 
        { 
            get { return firstName; }
            set { firstName = value; } 
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public User(int id, string firstName, string lastName, string email, string password, string phone, string address)
        {
            UserId = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Phone = phone;
            Address = address;
        }
    }
}
