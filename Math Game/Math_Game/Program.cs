class Program {
    public static void Main() {
        MathGame game = new MathGame();
        int choice = game.GetMenuChoice();
        Console.WriteLine($"Your choice was { choice }");
    }
}