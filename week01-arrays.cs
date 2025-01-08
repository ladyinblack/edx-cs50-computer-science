class Program {
  public static void Main(string[] args) {
    MarioQuestionMarks();
    MarioBricks();
    Mario3by3GridOfBricks();
  }

  public static void MarioQuestionMarks()
  {
    for (int i = 0; i < 4; i++)
    {
      Console.Write("?");
    }
    Console.WriteLine("\n");
  }

  public static void MarioBricks()
  {
    for (int i = 0; i < 3; i++)
    {
      Console.WriteLine("#");
    }
    Console.WriteLine();
  }

  public static void Mario3by3GridOfBricks()
  {
    const int n = 3;
    
    for (int i = 0; i < n; i++)
    {
      for (int j = 0; j < n; j++) 
      {
        Console.Write("#");
      }
      Console.WriteLine();
    }
  }
}
