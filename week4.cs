using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many transaction today ? :");
        string numStr = Console.ReadlLine();
        int num = Int32.Parse(numStr);

        //creating an object (varibale of a certain class type)
        TransactionList trans = new TransactionList();
        //trans.Init(num); 


        for (int i=0; i < numStr; i++){
        // creating an object (variable of a certain class type)
            Transaction transaction;
            transaction = new Transaction();

            transaction.setDate( new DateTime(2008, 6, 1) );

            transaction.val = -10.5f;

            Console.WriteLine("transaction value is " + transaction.val + " at time "+ transaction.date.ToString());
            trans.Add(transaction); // classes provide API, method are button. 
        } 
        trans.Display(); //print the list of transaction
    }

}