using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
	internal class Program
	{
		static void Main()
		{
			List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
			List<int> list2 = new List<int>() { 5, 6, 7, 8, };



			Console.WriteLine("Union(giam dan):");
			/* su dung cong thuc de ket hop hai danh sach va loai bo cac phan tu trung*/
			var unionDescending = list1.Union(list2).OrderByDescending(x => x);
			foreach (var item in unionDescending)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine("\n\nIntersect:");
			/*su dung phuong thuc de lay cac phan tu chung giua hau danh sach.*/
			var intersect = list1.Intersect(list2);
			foreach (var item in intersect)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine("\n\nConcat(tang dan):");
			/*gia tri tang dan*/
			var Concat = list1.Concat(list2).OrderBy(x => x);
			foreach (var item in Concat)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine("\n\nExcept(xuat ra mang hinh):");
			var Except = list1.Except(list2);
			foreach(var item in Except)
			{
				Console.Write(item + " ");

			}
		}
	}
}
