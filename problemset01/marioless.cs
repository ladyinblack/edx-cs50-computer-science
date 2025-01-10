class Program {
  /** 
   * Towards the end of World 1-1 in Nintendo's Super Mario Bros., 
   * Mario must ascend right-aligned pyramid of bricks.
   */
  public static void Main(string[] args) {
    // Prompt the user for the pyramid's height
    int height;
    do
    {
      height = Convert.ToInt32(Console.ReadLine());
    }
    while (height < 1);

    // Print a pyramid of that height
    for (int i = 0; i < height; i++)
    {
      // Print row of bricks
      print_row(height - i - 1, i + 1);
    }
  }

  public static void print_row(int spaces, int bricks)
  {
    // Print spaces
    for (int j = 0; j < spaces; j++)
    {
      Console.Write(" ");
    }

    // Print bricks
    for (int k = 0; k < bricks; k++)
    {
      Console.Write("#");
    }
    Console.WriteLine();
  }
}
