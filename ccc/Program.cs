using System.Collections.Generic;
using System.Text;

var st1 = new MStack(6);
st1.Push(1);
st1.Push(66);
st1.Push(55556);
st1.Push(66);
st1.Push(6);
st1.Push(500);

Console.WriteLine(st1.ToString());
st1.sort_ascending();
Console.WriteLine(st1.ToString());
class MStack
{
    private int[] stack;
    private int top_index = -1;

    //cons
    public MStack(int size)
    {
        stack = new int[size];
    }
    //push
    public void Push(int num)
    {
        // full write msg
        if (top_index == stack.Length) Console.WriteLine("It's full bro!");
        //else push
        else
        {
            top_index++;
            stack[top_index] = num;
        }
    }
    //pop
    public int Pop()
    {
        if (top_index == -1) { Console.WriteLine("It's empty bro!"); return 0; }
        else
        {
            top_index--;
            return stack[top_index + 1];
        }
    }
    //peek
    public int Peek()
    {
        if (top_index == -1) { Console.WriteLine("It's empty bro!"); return 0; }
        else
        {
            return stack[top_index];
        }
    }
    //sort_ascending
    public void sort_ascending()
    {
        var temp_list = new List<int> { };
        // if not empty
        //pour them into a list
        for (int i = 0; i < top_index + 1; i++)
        {
            temp_list.Add(stack[i]);
        }
        //sort
        temp_list.Sort();
        temp_list.Reverse();
        //pour them back
        for (int i = 0; i < top_index + 1; i++)
        {
            stack[i] = temp_list[i];
        }
    }
    //+override
    public static MStack operator +(MStack a, MStack b)
    {
        return new MStack(2);
    }
    //ToString override
    public override string ToString()
    {
        var result = new StringBuilder();
        // var int_list = new List<int> { };
        for (int i = 0; i < top_index + 1; i++)
        {
            result.Append(stack[i]);
            result.Append(" ,");
        }
        return result.ToString();
    }
}














