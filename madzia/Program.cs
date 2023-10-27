List<int> list2 = new List<int>() { 2, 1, 2, 3 };
List<int> list1 = new List<int>() { 9, 5, 6 };

list1.Reverse();
list2.Reverse();

if(list1.Count > list2.Count)
{
    for(int i =0; i < list2.Count; i++)
    {
        list1[i] += list2[i];
    }

    for(int i=0; i<list1.Count; i++)
    {
        if (list1[i] > 9)
        {
            if(i+1 < list1.Count-1)
            {
                list1.Insert(i+1, 0);
            }
            list1[i + 1] += 1;
            list1[i] -= 10;
        }
    }

    list1.Reverse();
    showList(list1);
}
else
{
    for (int i = 0; i < list1.Count; i++)
    {
        list2[i] += list1[i];
    }

    for (int i = 0; i < list2.Count; i++)
    {
        if (list2[i] > 9)
        {
            if (i + 1 < list2.Count - 1)
            {
                list2.Insert(i + 1, 0);
            }
            list2[i + 1] += 1;
            list2[i] -= 10;
        }
    }
    list2.Reverse();
    showList(list2);
}

void showList(List<int> list)
{
    foreach(var x in list)
    {
        Console.Write(x);
    }
    Console.Write("\n");
}