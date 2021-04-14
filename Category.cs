namespace ZwiftPower
{
	public enum Category { A = 5, B = 4, C = 3, D = 2, Unknown = 1 };

	public static class CategoryHelper
	{
		public static Category FromString(string category)
		{
			return category switch
			{
				"A" => Category.A,
				"B" => Category.B,
				"C" => Category.C,
				"D" => Category.D,
				_ => Category.Unknown
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
