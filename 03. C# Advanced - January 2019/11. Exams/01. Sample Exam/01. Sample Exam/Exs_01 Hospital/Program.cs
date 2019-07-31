namespace Exs_01_Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {

            var database = new List<Patient>();
            var roomNumber = new Dictionary<string, int>();
            var currentCount = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Output") break;

                var inputParts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string department = inputParts[0];
                string doctor = $"{inputParts[1]} {inputParts[2]}";
                string patientName = inputParts[3];
                if(!roomNumber.ContainsKey(department))
                {
                    roomNumber[department] = 1;
                    currentCount[department] = 1;
                }
                else if(!(roomNumber[department] == 20 && currentCount[department] == 3))
                {
                    if(currentCount[department] == 3)
                    {
                        roomNumber[department]++;
                        currentCount[department] = 0;
                    }
                    currentCount[department]++;
                }
                database.Add(new Patient(department, doctor, patientName, roomNumber[department]));
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End") break;

                var parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 1)
                {
                    foreach (var patient in database
                                                .Where(x => x.Department == parts[0])
                                                .ToList())
                    {
                        Console.WriteLine(patient.Name);
                    }
                }
                else if (parts.Length == 2)
                {
                    string doctor = $"{parts[0]} {parts[1]}";
                    if (database.Where(x => x.Doctor == doctor).Count() != 0)
                    {
                        foreach (var patient in database
                                                    .Where(x => x.Doctor == doctor)
                                                    .OrderBy(x => x.Name)
                                                    .ToList())
                        {
                            Console.WriteLine(patient.Name);
                        }
                    }
                    else
                    {
                            string department = parts[0];
                            int room = int.Parse(parts[1]);
                        foreach (var patient in database
                                                    .Where(x => x.Department == department && x.Room == room)
                                                    .OrderBy(x => x.Name)
                                                    .ToList())
                        {
                            Console.WriteLine(patient.Name);
                        }
                    }
                }
            }

        }
    }

    public class Patient
    {

        public Patient(string depatment, string doctor, string name, int room)
        {
            this.Name = name;
            this.Doctor = doctor;
            this.Department = depatment;
            this.Room = room;
        }

        public string Name { get; set; }

        public string Doctor { get; set; }

        public string Department { get; set; }

        public int Room { get; set; }
    }
}
