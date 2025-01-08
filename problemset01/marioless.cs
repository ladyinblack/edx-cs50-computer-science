class Program {
  public static void Main(string[] args) {
    MarioLess();
  }

  /** 
   * Towards the end of World 1-1 in Nintendo's Super Mario Bros., 
   * Mario must ascend right-aligned pyramid of bricks.
   */
  public static void MarioLess()
  {
    const int bricksCount = 8;

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
      Console.WriteLine();
    }
  }
}
