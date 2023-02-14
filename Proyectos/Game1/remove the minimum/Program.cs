public class Program
{
    static void Main(string[] args)
    { var myList = new List<int> () { 1,3,6,8,1,3};
        Remover.RemoveSmallest(myList);
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
    }
}
public class Remover
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
       
          numbers.Distinct().ToList().Remove(numbers.Min());
        return numbers;
    }
}