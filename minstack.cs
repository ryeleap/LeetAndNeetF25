// Minimum Stack (C# 7/14/25)

public class MinStack
{
  private Stack<int> stack;
  private Stack<int> minStack;

  public MinStack()
  {
    stack = new Stack<int>();
    minStack = new Stack<int>();
  }

  public void Push(int val)
  {
    stack.Push(val);
    if (minStack.Count == 0)
    {
      minStack.Push(val);
    }
    else
    {
      val = Math.Min(val, minStack.Peek());
      minStack.Push(val);
    }
  }

  public void Pop()
  {
    minStack.Pop();
    stack.Pop();

  }

  public int Top()
  {
    return stack.Peek();
  }

  public int GetMin()
  {
    return minStack.Peek();
  }
}
