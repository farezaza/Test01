public class Program
{
    static void Owner()
    {
        string[] Owner = {"owner1","owner2","owner3"};
        int[] ID = {1,2,3};
        string[] Name = {"name1","name2","name3"};
         Console.ReadLine();
        return;
    }
    static void Main(string[] args)
    {
        double budget = 1000000;
        string BranchName = "Bangkhuntien";
        string location = "Soi Tientalea 27";

        Console.WriteLine("------------- KFC Thailand new Branch Information --------------");
        Console.WriteLine("Budget : {0} ",budget);
        Console.WriteLine(" Branch Name : {0}  ",BranchName);
        Console.WriteLine(" Location : {0} ",location);
    }
}