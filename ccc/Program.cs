//have a list 
var mlist = new List<int> { 2, 111, 0, -10, 68, 8, 9, 13, 13, 13 };
var sorted_list = new List<int> { };
//problem here
heapify_all(mlist);
do
{
    Swap(mlist, 0, mlist.Count - 1);
    sorted_list.Add(mlist[mlist.Count - 1]);
    mlist.RemoveAt(mlist.Count - 1);
    heapify_all(mlist);
    //repeat until mlist.count==1
} while (mlist.Count > 0);
//write the sorted list
foreach (var item in sorted_list)
{
    Console.Write($"{item},");
}

void heapify_all(List<int> list)
{
    for (int i = list.Count - 1; i > 0; i--)
    {
        heapify(list, i);
    }
}

void heapify(List<int> list, int i)
{
    //if i==0 return
    if (i == 0) return;
    int parent = (i - 1) / 2;
    //if parent<child -> swap and heapify parent
    if (list[parent] < list[i])
    {
        Swap(list, parent, i);
        heapify(list, parent);
    }
}

void Swap(List<int> li, int a, int b)
{
    int temp;
    temp = li[b];
    li[b] = li[a];
    li[a] = temp;
}















