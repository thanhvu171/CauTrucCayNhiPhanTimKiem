using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayNhiPhanTimKiem
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchBinaryTree tree = new SearchBinaryTree();
            tree.taoCay();
            Console.ReadLine();
            Console.Write("NLR: ");
            tree.NLR(tree.Root);

            Console.Write("LNR: ");
            tree.NLR(tree.Root);

            Console.Write("LRN: ");
            tree.LRN(tree.Root);
            Console.ReadLine();
        }
    }
}
