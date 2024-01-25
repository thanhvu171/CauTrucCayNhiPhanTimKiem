using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CayNhiPhanTimKiem
{
    class TNode
    {
        public int info;
        public TNode left;
        public TNode right;
        public TNode(int x)
        {
            info = x;
            left = null;
            right = null;
        }
    }
    class SearchBinaryTree
    {
        public TNode Root;
        public SearchBinaryTree()
        {
            Root = null;
        }
        public void NLR(TNode root)
        {
            if (root != null)
            {
                Console.Write($"{root.info} ->");
                NLR(root.left);
                NLR(root.right);
            }
        }
        public void LNR(TNode root)
        {
            if (root != null)
            {
                Console.Write($"{root.info} ->");
                LNR(root.left);
                LNR(root.right);
            }
        }
        public void LRN(TNode root)
        {
            if (root != null)
            {
                Console.Write($"{root.info} ->");
                LRN(root.left);
                LRN(root.right);
            }
        }
        public void themNode(ref TNode root, int x)
        {
            if (root == null)
            {
                TNode p = new TNode(x);
                root = p;
            }
            else if (root.info > x)
                themNode(ref root.left, x);
            else if (root.info < x)
                themNode(ref root.right, x);
        }
        public void taoCay()
        {
            Console.Write("Cho biet so nut trong cay: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Nhap gia tri node thu" + i + ": ");
                int x = int.Parse(Console.ReadLine());
                themNode(ref Root, x);
            }
        }
        public int timKiem(int x)
        {
            TNode kq = null;
            if (Root != null)
            {
                if (Root.info == x)
                    kq = Root;
                else if (x < Root.info)
                    kq = timKiem(Root.left, x);
                else
                    kq = timKiem(Root.right, x);
            }
            return timKiem;
        }
    }
}
