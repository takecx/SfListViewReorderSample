using System;
using System.Collections.ObjectModel;
using Prism.Mvvm;
using SfListViewReorderSample.Models;

namespace SfListViewReorderSample.ViewModels
{
	public class MainPageViewModel : BindableBase
	{
		private DateTime _CurrentStartDate;

		#region BindableBase
		private ObservableCollection<Event> _Events;
		public ObservableCollection<Event> m_Events
		{
			get { return _Events; }
			set { this.SetProperty(ref this._Events, value); }
		}
		#endregion

		public MainPageViewModel()
		{
			// test data
			m_Events = new ObservableCollection<Event>
			{
				new Event{m_Title="title1" ,m_StartTime = new DateTime(2018,9,18)},
				new Event{m_Title="title2" ,m_StartTime = new DateTime(2018,9,19)},
				new Event{m_Title="title3" ,m_StartTime = new DateTime(2018,9,20)},
				new Event{m_Title="title4" ,m_StartTime = new DateTime(2018,9,21)},
				new Event{m_Title="title5" ,m_StartTime = new DateTime(2018,9,22)},
			};

			_CurrentStartDate = m_Events[0].m_StartTime;

			_Events.CollectionChanged += _Events_CollectionChanged;
		}

		/// <summary>
		/// Eventses the collection changed.
		/// Fire when SfListView item reodered
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		void _Events_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			// update each start-time
			var tempStartTime = _CurrentStartDate;
			for (int i = 0; i < m_Events.Count; i++)
			{
				m_Events[i].m_StartTime = tempStartTime;
				tempStartTime = tempStartTime.AddDays(1);
			}
		}
	}
}
