using System;
using System.Collections.Generic;
using System.IO;

namespace objected_oriented_programming
{
    internal class Program
    {
        public static void SearchMail(ref string s)
        {
            s = s.Substring(s.IndexOf('&') + 1).TrimStart(' ').TrimEnd(' ');
        }

        static void Main(string[] args)
        {
            List<string> mails = new();
            try
            {
                using (StreamReader sr = new StreamReader($"{Directory.GetCurrentDirectory()}\\name_mail.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        SearchMail(ref line);
                        mails.Add(line);
                    }
                }

                using (StreamWriter sw = File.CreateText($"{Directory.GetCurrentDirectory()}\\mails.txt"))
                {
                    foreach(string mail in mails)
                    {
                        sw.WriteLine(mail);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
