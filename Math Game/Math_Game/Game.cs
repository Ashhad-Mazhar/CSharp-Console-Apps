class MathGame {
    public MathGame() {

    }
    public void PrintMenu() {
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Division");
        Console.WriteLine("3. Subtraction");
        Console.WriteLine("4. Multiplication");
    }
    public int GetMenuChoice() {
        // Keeps getting choice from user till a valid one is received
        string choice;
        int number = 0;
        bool isValid = false;
        while (!isValid) {
            Console.Clear();
            PrintMenu();
            Console.Write("Enter choice: ");
            choice = Console.ReadLine();
            isValid = ValidateInput(choice, ref number);
            if (!isValid) {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
        return number;
    }
    public bool ValidateInput(string input, ref int result) {
        // Checks if the choice is a valid integer between the range 1-4
        // Assigns the converted integer to the result variable
        if (string.IsNullOrEmpty(input)) {
            return false;
        }
        bool isValid = int.TryParse(input, out result);
        if (isValid) {
            if (result >= 1 && result <= 4) {               
                return true;
            }
            else {
                return false;
            }
        }
        else {
            return false;
        }
    }
}