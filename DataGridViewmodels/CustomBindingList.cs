using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace WindowsFormsCompaniesManager.DataGridViewmodels
{
	class CustomBindingList<T> : BindingList<T>
	{
		public CustomBindingList() { }

		public CustomBindingList(IList<T> list) : base(list) { }

		public void OrderBy<TKey>(Func<T, TKey> keySelector)
		{
			List<T> orderItems = new(Items.OrderBy(keySelector).ToList());

			Clear();
			orderItems.ForEach(item => Add(item));
		}

		public void AddRange(IList<T> list)
		{
			foreach (T item in list)
				Add(item);
		}

	}
}
