using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormAndSettingDemoPage : ContentPage
	{
		public FormAndSettingDemoPage()
		{
			InitializeComponent();

			Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);

		}
		// --------- DATE PICKER ---------
		//void OnDateSelected(object sender, DateChangedEventArgs args)
		//{
		//	Recalculate();
		//}

		//void OnSwitchToggled(object sender, ToggledEventArgs args)
		//{
		//	Recalculate();
		//}

		//void Recalculate()
		//{
		//	TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date +
		//		(includeSwitch.IsToggled ? TimeSpan.FromDays(1) : TimeSpan.Zero);

		//	resultLabel.Text = String.Format("{0} day{1} between dates",
		//										timeSpan.Days, timeSpan.Days == 1 ? "" : "s");
		//}
		// --------- DATE PICKER ---------


		// --------- TIME PICKER ---------

		DateTime _triggerTime;

		bool OnTimerTick()
		{
			if (_switch.IsToggled && DateTime.Now >= _triggerTime)
			{
				_switch.IsToggled = false;
				DisplayAlert("Timer Alert", "The '" + _entry.Text + "' timer has elapsed", "OK");
			}
			return true;
		}

		void OnTimePickerPropertyChanged(object sender, PropertyChangedEventArgs args)
		{
			if (args.PropertyName == "Time")
			{
				SetTriggerTime();
			}
		}

		void OnSwitchToggled(object sender, ToggledEventArgs args)
		{
			SetTriggerTime();
		}

		void SetTriggerTime()
		{
			if (_switch.IsToggled)
			{
				_triggerTime = DateTime.Today + _timePicker.Time;
				if (_triggerTime < DateTime.Now)
				{
					_triggerTime += TimeSpan.FromDays(1);
				}
			}
		}

		// --------- TIME PICKER ---------
	}
}