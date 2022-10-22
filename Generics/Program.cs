// See https://aka.ms/new-console-template for more information


using Generics;

int[] arr = { 1, 2, 3 };
List<int> list = new List<int>
{
    10,
    1,
    5
};

List<Square> dbList = new List<Square>();

Console.WriteLine();
Console.WriteLine("Lists");
list.Add(12);
list.Add(20);
list.Add(12);
list.Add(10);
for (int i = 0; i < list.Count; i++) //arr.Length
{
    Console.WriteLine(list[i]);
}

list.Remove(12);
Console.WriteLine();
for (int i = 0; i < list.Count; i++) //arr.Length
{
    Console.WriteLine(list[i]);
}


Console.WriteLine();
Console.WriteLine("Custom Generic");

GenericArray<int> genericArray = new GenericArray<int>(10);

genericArray.AddElement(2, 5);

Console.WriteLine(genericArray.ElementAtIndex(2));


Console.WriteLine("Stack");
//"((3+4)*5)*(2+3)"
//x=7*5=35*5
//y=2+3=5
Stack<int> stack = new Stack<int>(); //FI LO

stack.Push(1);
stack.Push(2);
stack.Push(3);
//3 2 1

while (stack.Count != 0)
{
    int element = stack.Peek();
    Console.WriteLine(element);
    stack.Pop();

    //3 2 1
    //2 1
    //1
    //
}

Console.WriteLine("Queue");
Queue<int> queue = new Queue<int>(); //FI FO

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
while (queue.Count != 0)
{
    var el = queue.Peek();
    Console.WriteLine(el);
    queue.Dequeue();
}