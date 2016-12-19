using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace FriendOrFoe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

    }

    public static class Kata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            foreach (var str in names)
            {
                Console.WriteLine(str);
            }
            
            var friends = names?.Where(name => name.Length == 4);
            return friends;
        }
    }

}
