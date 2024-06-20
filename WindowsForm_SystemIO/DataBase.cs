using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_SystemIO
{
    public class DataBase
    {

        public void DataTechnical()
        { 
        

        }

        public List<Customer> customerList (int count)
        { 
           
           List<Customer> list = new List<Customer>();

            int x = 0;

            for (int i = 0; i <= count; i++)
            {
                Customer customer = new Customer();

                customer.id = x++;
                customer.name = FakeData.NameData.GetFirstName();
                customer.surName = FakeData.NameData.GetSurname();
                customer.company = FakeData.NetworkData.GetDomain(); 
                customer.country = FakeData.PlaceData.GetCountry();

                customer.email = customer.name + "." + customer.surName + "@" + customer.company;

                list.Add(customer);

            }


            return list; 
        }

    }
}
