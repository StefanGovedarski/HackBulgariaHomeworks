using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week2_Day2_Task4 : HackBgExecutable
    {
        public void Execute()
        {
           /* Console.WriteLine(@"Appointments intersection

You are given a list of appointments and your task is to find the intersecting appointments. Write a method which takes two equal-sized arrays as arguments and prints one line for each pair of intersecting appointments. The line should be in the format:
The appointment starting at dd/mm/yyyy hh:mm intersects the appointment starting at dd/mm/yyyy hh:mm with exactly mmmm minutes.
void FindIntersectingAppointments(DateTime[] startDates, TimeSpan[] durations)"); Console.WriteLine("\n\n\n\n");*/

            DateTime[] dates = new DateTime[5]
            {
                new DateTime(2015,12,20,9,30,00),
                new DateTime(2015,12,20,9,35,00),
                new DateTime(2015,1,21,10,00,00),
                new DateTime(2015,12,20,10,00,00),
                new DateTime(2015,1,21,13,00,00),
            };
            TimeSpan[] durs = new TimeSpan[5]
            {
                new TimeSpan(00,10,00),
                new TimeSpan(1,00,00),
                new TimeSpan(3,15,00),
                new TimeSpan(5,00,00),
                new TimeSpan(00,0,1)
            };
            FindIntersectiongAppointments(dates, durs);
            
        }
        void FindIntersectiongAppointments(DateTime[] startDates , TimeSpan[] durations)
        {
            TimeSpan oneDay = new TimeSpan(24, 00, 00);
            TimeSpan nothing = new TimeSpan(00,00,00);
            Dictionary<DateTime, TimeSpan> appointments = new Dictionary<DateTime, TimeSpan>();
            for (int i = 0; i < startDates.Length; i++)
            {
                appointments.Add(startDates[i], durations[i]);
            }
            Console.WriteLine("The time table with appointments looks like this :");
            foreach(KeyValuePair<DateTime,TimeSpan> el in appointments)
            {
                Console.WriteLine("{0}  :  {1}",el.Key , el.Value);
            }
            Console.WriteLine("Intersecting appointments: ");
            for (int i = 0; i < startDates.Length; i++)
            {
                for (int j = 1; j < startDates.Length; j++)
                {
                    if(startDates[i]==startDates[j])
                    {
                        continue;
                    }
                    if (startDates[i].Year - startDates[j].Year == 0 && startDates[i].Month - startDates[j].Month == 0)
                    {
                        TimeSpan app1 = new TimeSpan(startDates[i].Hour, startDates[i].Minute, startDates[i].Second);
                        TimeSpan app2 = new TimeSpan(startDates[j].Hour, startDates[j].Minute, startDates[j].Second);
                        if (durations[i] > oneDay)
                        {
                           if (startDates[i].Day - startDates[j].Day <= -1)
                            {
                                if (durations[i] > app1 - app2)
                                {
                                    Console.WriteLine("Appointment {0} intersects with appointment {1} by {2}", i, j,durations[i]-(app1 - app2));
                                }
                            }
                        }
                        if (durations[i] > app1 - app2)
                        {

                            if(durations[i] - (app2 - app1) < oneDay && durations[i] - (app2 - app1) > nothing)
                            {
                                Console.WriteLine("Appointment {0} intersects with appointment {1} by {2}", i, j, durations[i] - (app2 - app1));
                            }
                        }
                    }
                }
            }
        }
        bool Intersects()
        {

            return true;
        }
    }
}
