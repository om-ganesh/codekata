using System;
using System.Collections.Generic;
using System.Text;

namespace csharpproject.Utility
{
    //Array Implementation of Stack
    class StackArray<T>
    {
        T[] sentence;
        int top;

        public StackArray()
        {
            sentence = new T[1];
            top = 0;
        }

        public bool isEmpty()
        {
            return top == 0;
        }

        public void push(T str)
        {
            if (top == sentence.Length)
                resize(sentence.Length * 2);
            sentence[top++] = str;
        }

        public T pop()
        {
            if (top > 0 && top == sentence.Length / 4)
                resize(sentence.Length / 2);
            top--;
            T topValue = sentence[top];
            sentence[top] = default;
            return topValue;
        }

        private void resize(int capacity)
        {
            // NOTE: Java doesn't allow generic array creation. Use: T[] newSentence = (T[]) new Object[capacity];
            T[] newCopy = new T[capacity];
            for (int i = 0; i < top; i++)
            {
                newCopy[i] = sentence[i];
            }
            sentence = newCopy;
        }

    }
}
