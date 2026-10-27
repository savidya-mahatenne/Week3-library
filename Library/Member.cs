namespace Library
{
    public class Member
    {
        // private backing fields
        private int memberId;
        private string name;
        private string address;
        private string phone; // Changed to string to keep the leading zeros

        // Public properties
        public int MemberId
        {
            get { return memberId; }
            private set                 // Private setter makes it read-only from outside the class
            {
                if (value > 0)
                {
                    memberId = value;
                }
                else
                {
                    Console.WriteLine("Error: Member ID must be greater than zero");
                }
            }
        }
        public string Name
        {
            get { return name; }  // get method
            set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Member name cannot be blank or contain numbers.");
                }
            } // set method
        }
        public string Address
        {
            get { return address; }  // get method
            set { address = value; } // set method
        }
        public string Phone
        {
            get { return phone; }  // get method
            set { phone = value; } // set method
        }

        // Constructor using standard C# casing conventions
        public Member(int memberId, string name, string address, string phone)
        {
            this.MemberId = memberId;  // Assign the camelCase parameter to the PascalCase property
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        // Method to display information about a member
        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member name: {Name}");
            Console.WriteLine($"Member address: {Address}");
            Console.WriteLine($"Member phone no: {Phone}");
            Console.WriteLine();
        }
    }
}
