public class Contact
{
    #region
    public string fName { get; set; }
    public string lName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public double ZIPCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    #endregion
}

public class Program
{
    static void Main()
    {
        // Access the file
        string filePath = @"C:\Users\mater\OneDrive\Desktop\DSU\Advanced Data Structures\DynamicArrays\us-contacts.csv";

        // Create a list/array from the file
        List<Contact> contacts = new List<Contact>();
    
        if (File.Exists(filePath)) 
        { 
            foreach (string line in File.ReadLines(filePath))
            {
                string[] files = line.Split(',');

                if (files.Length > 0)
                {
                    Contact contact = new Contact()
                    {
                        fName = files[0],
                        lName = files[1],
                        Address = files[2],
                        City = files[3],
                        State = files[4],
                        ZIPCode = int.Parse(files[5]),
                        Phone = files[6],
                        Email = files[7]
                    };
                    contacts.Add(contact);
                }
                else 
                { 
                    Console.WriteLine("Invalid data in file: {line}"); 
                } 
            }

            // Display every 50th contact
            #region
            int contactNumber = 1;
            foreach (Contact contact in contacts)
            {
                if (contactNumber % 50 == 0)
                {
                    Console.WriteLine($"{contact.lName}, {contact.fName}, {contact.Address}, " +
                        $"{contact.City}, {contact.State}, {contact.ZIPCode}" +
                        $"{contact.Phone}, {contact.Email}");
                }
                contactNumber++;
            }
            #endregion
        }
        else 
        { 
            Console.WriteLine("File not found"); 
        }
    }
}