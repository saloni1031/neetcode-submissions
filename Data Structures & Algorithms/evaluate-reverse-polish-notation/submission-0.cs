public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach(string c in tokens){
            if(c == "+")
                stack.Push(stack.Pop() + stack.Pop());
            else if(c == "-")
            {
                int right = stack.Pop();
                int left = stack.Pop();
                stack.Push(left - right);
            }
            else if(c == "*")
                stack.Push(stack.Pop() * stack.Pop());
            else if(c == "/")
            {
                int right = stack.Pop();
                int left = stack.Pop();
                stack.Push(left / right);
            }
            else{
                stack.Push(int.Parse(c));
            }
        }

        return stack.Peek();
    }
}
