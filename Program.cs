using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIP_Practice_Csh
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delete Duplicate in array
            Delete_Duplicate run = new Delete_Duplicate();
           //run.delete_dup();

            //Number of Primes, up to n
            all_Primes all = new all_Primes();
            //all.prime_calculator();

            //7.7 phone permuations
            // phone_Permute ph = new phone_Permute("2276696");
            //ph.all_permutations_phone();

            //7.8 Looksay Sequence
            //return alist of numbers up till n
            //get first 4 number of look say
           // int n = 2;
            Look_Say say = new Look_Say();
            //say.Look(n);



    }//end Program method
}

    //6.6
    class Delete_Duplicate
    {
        //private array method
        int[] arry = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 10, 11, 11 };

        public void delete_dup()
        {
            int j = 1;
            for(int i = 1; i < arry.Count()-1; ++i)
            {
                //j keeps the spot of a duplicate, and is only incremented when the previous, and current value aren't equal
                //when they are equal, only i increments until they are not equal, and the next values are written in j
                if(arry[j-1] != arry[i]) {
                    arry[j] = arry[i];
                    ++j;
                }
            }//for loop

            foreach (int b in arry)
            {
                Console.WriteLine(b);
            }

        }
    }//end class Delete Duplicate

    
    // 6.8 
    class all_Primes
    {
        //constructor
        public all_Primes()
        {
            //intalize a bitArry, to size of primes, all false
            byt_arry = new BitArray( n, true );

        }
        
        //create prime calculator
        public void prime_calculator()
        {
            //intalize 0, 1 to be true, since these values are prime
            if(n < 4)
            {
                Console.WriteLine("2" + " ");
                Console.WriteLine("3" + " ");
                return;
            }
            //outerloop, goes through
            for(int i = 2; i <100; ++i)
            {
                for(int j = 2; j < n; ++j)
                {
                    if(i*j > n -1) { break; }
                    byt_arry[i * j] = false;
                }
            }

            for (int i = 2; i < n; ++i)
            {
                if (byt_arry[i]) { Console.Write(i + " "); }
            }
        }

        //private byte[] array method, initalized in the constructor through the value that is passed in
       private BitArray byt_arry;
        int n = 6;
    } //end class all_Primes

    /*RETUREN TO 7.7*/
    //7.7 Compute all nemonics for cellphone number: Given a phone number 7 digits, write all the permutations of words that can be made
    class phone_Permute
    {

        //ctor TAB TAB, constructor shorcut
        public phone_Permute(string in_)
        {
            phone = in_;

            //create hashmap: char -> string
            phone_num.Add('2', "ABC");
            phone_num.Add('3', "DEF");
            phone_num.Add('4', "GHI");
            phone_num.Add('5', "JKL");
            phone_num.Add('6', "MNO");
            phone_num.Add('7', "PQRS");
            phone_num.Add('8', "TUV");
            phone_num.Add('9', "WXYZ");
        }

        //example 2276696 = "Acryonym": Compute all the rest
        public void all_permutations_phone() {
    
               //Loop through the phone string, get character. 

        }



        //private hashtable variable
        Hashtable phone_num = new Hashtable();

        //phone number intalized through the constructor
        private string phone;

    } // end class permute


    class Look_Say
    {
        public void Look(int n)
        {

            string ret = "";

            //get the first n values of look-say
            for (int i = 1; i < n; ++i)
            {
                for (int s = 0; s < looky.Length; ++s)
                {
                    int count = 1;
                    while (i + 1 < looky.Length && looky[i] == looky[i + 1])
                    {
                        ++i; ++count;
                    }
                    ret += count.ToString() + looky[i];
                }//second for
                looky = ret;

            }//end first for

            Console.WriteLine("String in Looksay is: " + looky);
        }//end look

        //private method
        private string looky =  "1" ;
    }

}//end of namespace
