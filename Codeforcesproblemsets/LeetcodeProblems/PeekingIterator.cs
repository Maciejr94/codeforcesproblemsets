using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems
{
    public class PeekingIterator
    {
        private readonly IEnumerator<int> iterator;
        public bool hasNext;
        public PeekingIterator(IEnumerator<int> iterator)
        {
            this.iterator = iterator;
            hasNext = iterator.MoveNext();
        }

        // Returns the next element in the iteration without advancing the iterator.
        public int Peek()
        {
            return iterator.Current;
        }

        // Returns the next element in the iteration and advances the iterator.
        public int Next()
        {
            int curr = iterator.Current;
            hasNext = iterator.MoveNext();
            return curr;
        }

        // Returns false if the iterator is refering to the end of the array of true otherwise.
        public bool HasNext()
        {
            return hasNext;
        }
    }
}
