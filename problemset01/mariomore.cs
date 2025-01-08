class Program {
  public static void Main(string[] args) {
    MarioMore();
  }

  /** 
   * Towards the beginning of World 1-1 in Nintendo's Super Mario Bros., 
   * Mario must hop over adjacent pyramids of bricks.
   */
  public static void MarioMore()
  {
    const int bricksCount = 4;

    for (int i = 1; i <= bricksCount; i++)
    {
      for (int j = 1; j <= bricksCount - i; j++)
      {
        Console.Write(" ");
      }

      for (int k = 1; k <= i; k++)
      {
        Console.Write("#");
      }
      Console.Write(" ");
              
      for (int m = 1; m <= i; m++)
      {
        Console.Write("#");
      }
      Console.WriteLine();
    }
  }
}
