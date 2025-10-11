using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Hospital hospital = new Hospital();
            Doctor doctor1 = new Doctor(1, "Іван", "Терапевт");
            Doctor doctor2 = new Doctor(2, "Сергій", "Хірург");
            Doctor doctor3 = new Doctor(3, "Андрій", "Офтальмолог");
            Patient patient1 = new Patient(1, "Юрій", 21);
            Patient patient2 = new Patient(2, "Борис", 49);
            Patient patient3 = new Patient(3, "Олег", 32);
            Patient patient4 = new Patient(4, "Артем", 40);
            HospitalRoom room1 = new HospitalRoom(101, 1);
            HospitalRoom room2 = new HospitalRoom(107, 2);
            MedicalRecord record1 = new MedicalRecord(patient1, doctor2, new DateTime(2025, 10, 21), "На операцію");
            MedicalRecord record2 = new MedicalRecord(patient3, doctor3, new DateTime(2025, 11, 02), "Планове обстеження");
            MedicalRecord record3 = new MedicalRecord(patient1, doctor1, new DateTime(2025, 10, 30), "Післяопераційний огляд");

            hospital.AddDoctor(doctor1);
            hospital.AddDoctor(doctor2);
            hospital.AddDoctor(doctor3);

            hospital.RegisterPatient(patient1);
            hospital.RegisterPatient(patient2);
            hospital.RegisterPatient(patient3);
            hospital.RegisterPatient(patient4);

            hospital.CreateRoom(room1);
            hospital.CreateRoom(room2);

            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 102);
            hospital.HospitalizePatient(5, 101);
            hospital.HospitalizePatient(2, 107);
            hospital.HospitalizePatient(3, 101);
            hospital.HospitalizePatient(4, 107);

            hospital.AddMedicalRecord(record1);
            hospital.AddMedicalRecord(record2);
            hospital.AddMedicalRecord(record3);

            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            Console.WriteLine(hospital.GetStatistics());
        }
    }
}
