using System;
using System.ComponentModel;

namespace ZwiftPower
{
	public enum Category
	{
		A = 10,
		B = 9,
		C = 8,
		D = 7,
		E = 6,
		F = 5,
		G = 4,
		H = 3,
		I = 2,
		J = 1,
		Unknown = 0
	};

	public static class CategoryHelper
	{
		public static Category FromString(string category)
		{
			if (Enum.TryParse<Category>(category, out var cat) == false)
			{
				return Category.Unknown;
			}

			return cat;
		}

		public static int AsInt(string category)
		{
			return FromString(category) switch
			{
				Category.A => 0,
				Category.B => 1,
				Category.C => 2,
				Category.D => 3,
				_ => throw new InvalidEnumArgumentException()
			};
		}

		public static Category FromDivision(int division)
		{
			return division switch
			{
				5 => Category.A,
				10 => Category.A,
				20 => Category.B,
				30 => Category.C,
				40 => Category.D,
				_ => Category.Unknown
			};
		}

		public static Category FromWkgMixed(float wkg, float watts)
		{
			if (wkg >= 4.0 && watts >= 250)
				return Category.A;
			if (wkg >= 3.2 && watts >= 200)
				return Category.B;
			if (wkg >= 2.5 && watts >= 150)
				return Category.C;
			return Category.D;
		}

		public static Category FromWkgFemale(float wkg)
		{
			if (wkg >= 3.7)
				return Category.A;
			if (wkg >= 3.2)
				return Category.B;
			if (wkg >= 2.5)
				return Category.C;
			return Category.D;
		}
	}
}
