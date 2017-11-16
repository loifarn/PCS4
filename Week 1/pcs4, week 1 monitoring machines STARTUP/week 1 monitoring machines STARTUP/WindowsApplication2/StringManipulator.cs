using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication2
{
    class StringManipulator
    {
        public delegate string StringManipulatorHandler(string s);
        public StringManipulatorHandler manipulatorHandler;

        public StringManipulator ()
        {
            //Empty body
        }

        public string ToCapital(string s)
        {
            return s.ToUpper();
        }

        public string ToNextchar (string s)
        {
            char[] chars = s.ToCharArray(); //now chars is an array containing all the characters of string s
            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];
                if ((ch >= 'a' && ch < 'z') || (ch >= 'A' && ch < 'Z'))
                {
                    chars[i]++;
                }
                else
                {
                    if (ch == 'z') { chars[i] = 'a'; }
                    if (ch == 'Z') { chars[i] = 'A'; }
                }
            }
            //now add the characters in the array chars one by one to the answer-string
            string answer = "";
            foreach (char ch in chars) { answer += ch; }
            return answer;

        }

        public string testMethod(string s)
        {
            char[] chars = s.ToCharArray();
            int counter = 0;

            foreach (Char ch in chars)
            {
                if ((ch >= 'a' && ch < 'z') || (ch >= 'A' && ch < 'Z'))
                {
                    chars[counter]++;
                }
                else
                {
                    if (ch == 'z') { chars[counter] = 'a'; }
                    if (ch == 'Z') { chars[counter] = 'A'; }
                }
                counter++;
            }

            string answer = "";
            foreach (char ch in chars) { answer += ch; }
            return answer;
        }

        public string ToFormerChar (string s)
        {
            char[] chars = s.ToCharArray(); //now chars is an array containing all the characters of string s
            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];
                if ((ch >= 'a' && ch < 'z') || (ch >= 'A' && ch < 'Z'))
                {
                    chars[i]--;
                }
                else
                {
                    if (ch == 'z') { chars[i] = 'a'; }
                    if (ch == 'Z') { chars[i] = 'A'; }
                }
            }
            //now add the characters in the array chars one by one to the answer-string
            string answer = "";
            foreach (char ch in chars) { answer += ch; }
            return answer;
        }

        public string ToWhat(string s)
        {
            return s.ToLower();
        }
    }
}
