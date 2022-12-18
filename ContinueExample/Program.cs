namespace ContinueExample
{
	class Program
	{
		static void Main(string[] args)
		{
			// loop
			for (int i = 1; i <= 10; i++)
			{
				if (i == 6)
				{
					continue;
				}
				System.Console.WriteLine(i);
			}

			System.Console.ReadKey();
		}
	}
}
