using System;
using Prism.Mvvm;

namespace SfListViewReorderSample.Models
{
	public class Event : BindableBase
	{
		#region BindableProperty
		private DateTime _StartTime;
		public DateTime m_StartTime
		{
			get { return _StartTime; }
			set { this.SetProperty(ref this._StartTime, value); }
		}
		private string _Title;
		public string m_Title
		{
			get { return _Title; }
			set { this.SetProperty(ref this._Title, value); }
		}
		#endregion
	}
}
