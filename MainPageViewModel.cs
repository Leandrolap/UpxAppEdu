using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XCalendar.Core.Extensions;
using XCalendar.Core.Models;

namespace UpxAppEdu
{
    internal class MainPageViewModel
    {
        public Calendar<CalendarDay> MyCalendar { get; set; } = new Calendar<CalendarDay>();

        //Below code is for making the calendar navigatable.
        public ICommand NavigateCalendarCommand { get; set; }
        public MainPageViewModel()
        {
            NavigateCalendarCommand = new Command<int>(NavigateCalendar);
        }
        public void NavigateCalendar(int amount)
        {
            //Months are variable length, calculate the timespan needed to get to the result.
            DateTime targetDateTime = MyCalendar.NavigatedDate.AddMonths(amount);

            MyCalendar.Navigate(targetDateTime - MyCalendar.NavigatedDate);
           

            //The below code additionally handles the case that adding months leads to an unrepresentable date.

           
        }
    }
}
