using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SfListViewReorderSample.ViewModels;
using Syncfusion.ListView.XForms;
using Xamarin.Forms;

namespace SfListViewReorderSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			// enable reordering the underlying collection
			this.sflistview.DragDropController.UpdateSource = true;
		}

		/// <summary>
		/// Handles the item dragging.
		/// https://help.syncfusion.com/xamarin/sflistview/item-drag-and-drop#reorder-the-underlying-collection
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		//void Handle_ItemDragging(object sender, Syncfusion.ListView.XForms.ItemDraggingEventArgs e)
		//{
		//if (e.Action == DragAction.Drop)
		//{
		//	var vm = BindingContext as MainPageViewModel;

		//	//Swap Event
		//	var tempEvent = vm.m_Events[e.OldIndex];
		//	vm.m_Events[e.OldIndex] = vm.m_Events[e.NewIndex];
		//	vm.m_Events[e.NewIndex] = tempEvent;
		//}
		//}
	}
}
