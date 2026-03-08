using System;
using System.Collections.Generic;

namespace model
{
    public class Race
    {
        public int? Id { get; set; }                  // nullable like Java Integer
        public string Destination { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public List<bool> AvaiableSeats { get; set; }

        // Constructor with Id
        public Race(int? id, string destination, string date, string time, List<bool> avaiableSeats)
        {
            Id = id;
            Destination = destination;
            Date = date;
            Time = time;
            AvaiableSeats = avaiableSeats;
        }

        // Constructor without Id
        public Race(string destination, string date, string time, List<bool> avaiableSeats)
        {
            Destination = destination;
            Date = date;
            Time = time;
            AvaiableSeats = avaiableSeats;
        }

        public override string ToString()
        {
            // convert List<bool> to string like Java's List.toString()
            string seatsStr = AvaiableSeats != null ? string.Join(", ", AvaiableSeats) : "null";
            return $"{Id} {Destination} {Date} {Time} [{seatsStr}]";
        }
    }
}