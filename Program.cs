namespace CSharp_BubbleSort
{
	public static class BubbleSortMethods
	{
		//The "this" keyword before the method parameter identifies this as a C# extension
		//method, which can be called using instance method syntax on any generic list,
		//without having to modify the generic List<T> code provided by the .NET framework.
		public static void BubbleSort<T>(this List<T> list) where T : IComparable
		{
			bool madeChanges;
			int itemCount = list.Count;
			do
			{
				madeChanges = false;
				itemCount--;
				for (int i = 0; i < itemCount; i++)
				{
					if (list[i].CompareTo(list[i + 1]) > 0)
					{
						T temp = list[i + 1];
						list[i + 1] = list[i];
						list[i] = temp;
						madeChanges = true;
					}
				}
			} while (madeChanges);
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			//Sorting
			List<int> testList = new List<int> { 3, 7, 3, 2, 1, -4, 10, 12, 4 };
			testList.BubbleSort();
			foreach (var t in testList) Console.Write(t + " ");
		}
	}
}