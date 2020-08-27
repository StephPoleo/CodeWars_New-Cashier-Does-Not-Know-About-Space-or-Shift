using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		string order = GetOrder("milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza");
		Console.WriteLine(order);
	}
	
	public static string GetOrder(string input)
  { 
    
            List<string> list = new List<string>();
            List<string> temp = new List<string>();

            list.Add("Burger");
            list.Add("Fries");
            list.Add("Chicken");
            list.Add("Pizza");
            list.Add("Sandwich");
            list.Add("Onionrings");
            list.Add("Milkshake");
            list.Add("Coke");

            string order = "";

            for(int i=0; i < list.Count(); i++)
            {
                string com = list.ElementAt(i).ToLower();

                //Check if the string has the element  
                if (input.Contains(com))
                {
                  //Bingo
                    if (com[0] == input[0]&& com[1] == input[1])
                    {
                       temp.Add(list.ElementAt(i));
                       input = input.Substring(com.Length);
                       
                       if(input == "")
                        {
                            i = list.Count();
                        }

                       i = -1;
                    }
                   
                }

            }

            int count = 0;

            //Reorganize the list
            for (int i = 0; i < list.Count(); i++)
            {
                for(int j=0; j < temp.Count(); j++)
                {
                    if (list[i] == temp[j])
                    {
                        if(count + 1 == temp.Count())
                        {
                            order = order + temp[j];
                        }

                        else
                        {
                            order = order + temp[j] + " ";
                            count++;
                        }
                        
                    }

                }
                
            }
                return order;
  }
}
