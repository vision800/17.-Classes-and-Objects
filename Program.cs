using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            book.title = "Test";
            book.author = "Vision";
            book.pages = 23;

            Console.WriteLine("Book title : " + book.title);
            Console.WriteLine("Book author : " + book.author);
            Console.WriteLine("Book pages : " + book.pages);


            Member member = new Member();
            member.name = "Test";
            member.address = "";
            member.phone = "1234567890";
            member.age = 10;

            Console.WriteLine("Member name : " +member.name);
            Console.WriteLine("Member address: " + member.address);
            Console.WriteLine("Member phone: " + member.phone);
            Console.WriteLine("Member age: " + member.age);
        }
    }
}
