class Solution {
    static void Main(string[] args) {
        double meal_cost = Convert.ToDouble(Console.ReadLine());
        int tip_percent = Convert.ToInt32(Console.ReadLine());
        int tax_percent = Convert.ToInt32(Console.ReadLine());
            
        double tip = meal_cost * tip_percent / 100;
        double tax = meal_cost * tax_percent / 100;
        double totalCost = meal_cost + tip + tax;
            
        Console.WriteLine(Math.Round(totalCost));
    }
}
