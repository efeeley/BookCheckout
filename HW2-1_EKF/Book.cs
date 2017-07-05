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
    class Book
    {
        //Attributes
        private string title, authorFirstName, authorLastName, isbn;

        //Methods

        public string checkOut()
        {
            return "You have checked out the book \n" + getTitle() + "\n" + getAuthorLastName() + " , " +
                getAuthorFirstName() + "\n" + getISBN();
        }//end method  checkOut

        public string checkIn()
        {
            return "You have checked in the book \n" + getTitle() + "\n" + getAuthorLastName() + " , " +
                getAuthorFirstName() + "\n" + getISBN();
        }//end method checkIn

        public void setTitle(string aTitle)
        {
            title = aTitle;
        }//end public void setTitle

        public string getTitle()
        {
            return title;
        }//end public string get Title

        public void setAuthorFirstName(string aFName)
        {
            authorFirstName = aFName;
        }//end public void setAuthorFirstName

        public string getAuthorFirstName()
        {
            return authorFirstName;
        }//end public string getAuthorFirstName

        public void setAuthorLastName(string aLName)
        {
            authorLastName = aLName;
        }//end public void setAuthorLastName

        public string getAuthorLastName()
        {
            return authorLastName;
        }//end public string getAuthorLastName

        public void setISBN(string aISBN)
        {
            isbn = aISBN;
        }//end public void setISBN

        public string getISBN()
        {
            return isbn;
        }//end public string getISBN

    }//end class Program
}//end namespace 
