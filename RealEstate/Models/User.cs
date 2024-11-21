namespace RealEstate.Models
{
    public class User
    {
        public int _id;
        public string _firstName;
        public string _lastName;
        public string _email;
        public string _password;
        public string _phone;
        public string _address;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName 
        { 
            get { return _firstName; }
            set { _firstName = value; } 
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public User(int _id, string _firstName, string _lastName, string _email, string _password, string _phone, string _address)
        {
            Id = _id;
            FirstName = _firstName;
            LastName = _lastName;
            Email = _email;
            Password = _password;
            Phone = _phone;
            Address = _address;
        }
    }
}
