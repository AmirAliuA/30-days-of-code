class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        
        int i2;
        double d2;
        string s2;
        i2 = int.Parse(Console.ReadLine());
        d2 = double.Parse(Console.ReadLine());
        s2 = Console.ReadLine();

        Console.WriteLine(i + i2);
        Console.WriteLine("{0:F1}", d + d2);
        Console.WriteLine("{0}{1}", s, s2);
    }
}
