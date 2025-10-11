using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class Hospital
    {
        public List<Doctor> Doctors;
        public List<Patient> Patients;
        public List<HospitalRoom> Rooms;
        public List<MedicalRecord> Records;

        public Hospital()
        {
            Doctors = new List<Doctor>();
            Patients = new List<Patient>();
            Rooms = new List<HospitalRoom>();
            Records = new List<MedicalRecord>();
        }

        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
            Console.WriteLine($"Лікар {doctor.Name} ({doctor.Specialization}) доданий до системи");
        }

        public void RegisterPatient(Patient patient)
        {
            Patients.Add(patient);
            Console.WriteLine($"Пацієнт {patient.Name}, {patient.Age} років, зареєстрований");
        }

        public void CreateRoom(HospitalRoom room) 
        {
            Rooms.Add(room);
            Console.WriteLine($"Палата №{room.RoomNumber} створена (місткість: {room.Capacity})");
        }

        public void HospitalizePatient(int patientId, int roomNumber)
        {
            Patient patient = Patients.Find(patient => patient.Id == patientId);
            HospitalRoom room = Rooms.Find(room => room.RoomNumber == roomNumber);

            if (patient == null) 
            {
                Console.WriteLine($"Пацієнт з ID {patientId} не знайдений!");
                return;
            }

            if (room == null) 
            {
                Console.WriteLine($"Палата №{roomNumber} не знайдена!");
                return;
            }

            room.AddPatient(patient);
        }

        public void AddMedicalRecord(MedicalRecord record) 
        {
            Records.Add(record);
            Console.WriteLine($"Медичний запис створено: {record.Patient.Name} -> {record.Doctor.Name}");
        }

        public List<MedicalRecord> GetPatientHistory(int patientId)
        {
            List<MedicalRecord> empty_records = null;
            List<MedicalRecord> records = Records.FindAll(record => record.Patient.Id == patientId);
            if(records == null) return empty_records;
            else return records;
        }

        public string GetStatistics()
        {
            int totalPatientsInRooms = 0;
            foreach(var room in Rooms)
            {
                totalPatientsInRooms += room.Patients.Count;
            }

            string statistic = $"\n=== СТАТИСТИКА ЛІКАРНІ ===\n" +
                               $"Кількість лікарів: {Doctors.Count}\n" +
                               $"Кількість зареєстрованих пацієнтів: {Patients.Count}\n" +
                               $"Кількість палат: {Rooms.Count}\n" +
                               $"Кількість пацієнтів у палатах: {totalPatientsInRooms}\n" +
                               $"Кількість медичних записів: {Records.Count}\n";
            return statistic;
        }
    }
}
