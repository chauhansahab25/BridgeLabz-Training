using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int q = Convert.ToInt32(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        Stack<string> history= new Stack<string>();
        for(int i =0;i<q;i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int type = Convert.ToInt32(input[0]);
            if(type ==1)
            {
                string w = input[1];
                history.Push("1" + w);
                sb.Append(w);
            }
            else if (type ==2)
            {
                int k = Convert.ToInt32(input[1]);
                string deleted = sb.ToString(sb.Length -k,k);
                history.Push("2" + deleted);
                sb.Remove(sb.Length - k,k);
            }
            else if(type ==3)
            {
                int k = Convert.ToInt32(input[1]);
                Console.WriteLine(sb[k-1]);
            }
            else if(type ==4)
            {
                string last =history.Pop();
                int oldType= last[0] - '0';
                string data = last.Substring(1);
                if(oldType ==1)
                {
                    sb.Remove(sb.Length - data.Length, data.Length);
                }






                
                else if (oldType ==2)
                {
                    
                    sb.Append(data);
                }
            }
        }
    }
}