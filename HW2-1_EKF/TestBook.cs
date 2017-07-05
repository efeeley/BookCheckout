using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**************************************
 * Name: Elisabeth Feeley
 * Date: 7/5/2012
 * Assignment: HW2-1 (Book)
 * Resources: N/A
 * ***********************************/

namespace HW2_1_EKF
{
    class TestBook
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();

            b1.setTitle("The Avengers");
            b1.setAuthorLastName("Stark");
            b1.setAuthorFirstName("Tony");
            b1.setISBN("867-5309");

            Console.WriteLine(b1.checkOut());

            Console.ReadLine();

            Console.WriteLine(b1.checkIn());

            Console.ReadLine();

        }//end Main
    }//end class TestBook
}//end namespace
