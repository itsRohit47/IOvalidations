using System;

namespace read
{
    class read
    {
        
        public read() { }

        // Integer function helps read integer values from console easily
        public int Integer(string prompt)
        {
            int choice = 0;
            bool correct = true;
            while (correct)
            {
                try
                {
                    Console.Write(prompt + " ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine($"{e.Message} (Hint: enter an integer)");
                }
            }
            return choice;
        }

        public double Double(string prompt)
        {
            double choice = 0;
            bool correct = true;
            while (correct)
            {
                try
                {
                    Console.Write(prompt + " ");
                    choice = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine($"{e.Message} (Hint: enter a double)");
                }
            }
            return choice;
        }

        //Boolean function allows user to naturally answer the boolean questions
        public bool Boolean(string prompt)
        {
            Console.WriteLine("Type your choice as 'y/Y/YES/yes' for yes and 'n/N/NO/no' for no ");
            string result = "";
            bool correct = true;
            while (correct)
            {
                Console.Write(prompt + " ");
                result = result + Console.ReadLine();
                if (result != "y" && result != "yes" && result != "Y" && result != "YES")
                {
                    if (result == "n" || result == "no" || result == "N" || result == "NO")
                    {
                        return false;
                    }
                    else
                    {
                        Console.WriteLine($"{result} is an invalid input");
                        result = "";
                    }
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }
}

