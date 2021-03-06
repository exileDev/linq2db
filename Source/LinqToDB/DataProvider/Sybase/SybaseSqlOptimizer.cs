﻿namespace LinqToDB.DataProvider.Sybase
{
	using SqlProvider;

	using SqlQuery;

	class SybaseSqlOptimizer : BasicSqlOptimizer
	{
		public SybaseSqlOptimizer(SqlProviderFlags sqlProviderFlags) : base(sqlProviderFlags)
		{
		}

		public override ISqlExpression ConvertExpression(ISqlExpression expr, bool withParameters)
		{
			expr = base.ConvertExpression(expr, withParameters);

			if (expr is SqlFunction func)
			{
				switch (func.Name)
				{
					case "CharIndex" :
						if (func.Parameters.Length == 3)
							return Add<int>(
								ConvertExpression(new SqlFunction(func.SystemType, "CharIndex",
									func.Parameters[0],
									ConvertExpression(new SqlFunction(typeof(string), "Substring",
											func.Parameters[1],
											func.Parameters[2],
											new SqlFunction(typeof(int), "Len", func.Parameters[1])),
										withParameters)), withParameters),
								Sub(func.Parameters[2], 1));
						break;

					case "Stuff"     :
						if (func.Parameters[3] is SqlValue value)
						{
							if (value.Value is string @string && string.IsNullOrEmpty(@string))
								return new SqlFunction(
									func.SystemType,
									func.Name,
									false,
									func.Precedence,
									func.Parameters[0],
									func.Parameters[1],
									func.Parameters[1],
									new SqlValue(value.ValueType, null));
						}

						break;
				}
			}

			return expr;
		}
	}
}
