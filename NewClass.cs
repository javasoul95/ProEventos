include System;
public class Challenge
{
    public static int DescendingOrder(int num)
    {
          valor = num;
          
          List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
      
        return 0;
    }
} foreach (var item in collection)
{
    
}