using System.Collections.Generic;

namespace DSA_Project
{
    // Stack: LIFO undo for seat selection.
    public class UndoStack<T>
    {
          private Stack<T> items = new Stack<T>();

            public int count 
            {
            get { return items.Count; }
            }
              public void Push( T item ) // اضيف عنصر 
              {
                  items.Push (item); 
              }
              public T Pop() // اشوف واقدر اخرج اخر عنصر 
                    {

                              return items.Pop();
                    }
               public void Clear () // امسح كل العناصر اللي عندي 
               {
                              items.Clear();
               }
    
    }
}
