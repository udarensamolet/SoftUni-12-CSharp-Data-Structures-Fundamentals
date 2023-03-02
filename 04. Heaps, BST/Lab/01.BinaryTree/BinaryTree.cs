namespace _01.BinaryTree
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class BinaryTree<T> : IAbstractBinaryTree<T>
    {
        public BinaryTree(T element, IAbstractBinaryTree<T> left, IAbstractBinaryTree<T> right)
        {
            this.Value = element;
            this.LeftChild = left;
            this.RightChild = right;
        }

        public T Value { get; private set; }

        public IAbstractBinaryTree<T> LeftChild { get; private set; }

        public IAbstractBinaryTree<T> RightChild { get; private set; }

        public string AsIndentedPreOrder(int indent)
        {
            var sb = new StringBuilder();
            this.PreOrderDfs(sb, indent, this);
            return sb.ToString();
        }

        private void PreOrderDfs(StringBuilder sb, int indent, IAbstractBinaryTree<T> binaryTree)
        {
            sb.Append(new string(' ', indent)).AppendLine(binaryTree.Value.ToString());
            if(binaryTree.LeftChild != null)
            {
                this.PreOrderDfs(sb, indent + 2, binaryTree.LeftChild);
            }
            if (binaryTree.RightChild != null)
            {
                this.PreOrderDfs(sb, indent + 2, binaryTree.RightChild);
            }
        }

        public void ForEachInOrder(Action<T> action)
        {
            this.ForEachInOrder(this, action);
        }

        private void ForEachInOrder(IAbstractBinaryTree<T> tree, Action<T> action)
        {
            if (tree == null)
            {
                return;
            }
            this.ForEachInOrder(tree.LeftChild, action);
            action(tree.Value);
            this.ForEachInOrder(tree.RightChild, action);
        }

        public IEnumerable<IAbstractBinaryTree<T>> InOrder()
        {
            var result = new List<IAbstractBinaryTree<T>>();
            //попълване на колекция
            if (this.LeftChild != null)
            {
                result.AddRange(this.LeftChild.InOrder());
            }
            result.Add(this);
            if (this.RightChild != null)
            {
                result.AddRange(this.RightChild.InOrder());
            }
            
            return result;
        }

        public IEnumerable<IAbstractBinaryTree<T>> PostOrder()
        {
            var result = new List<IAbstractBinaryTree<T>>();
            //попълване на колекция
            if (this.LeftChild != null)
            {
                result.AddRange(this.LeftChild.PostOrder());
            }
            if (this.RightChild != null)
            {
                result.AddRange(this.RightChild.PostOrder());
            }
            result.Add(this);

            return result;
        }

        public IEnumerable<IAbstractBinaryTree<T>> PreOrder()
        {
            var result = new List<IAbstractBinaryTree<T>>();
            //попълване на колекция
            result.Add(this);
            if (this.LeftChild != null)
            {
                result.AddRange(this.LeftChild.PreOrder());
            }
            if (this.RightChild != null)
            {
                result.AddRange(this.RightChild.PreOrder());
            }

            return result;
        }
    }
}
