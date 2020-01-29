using Clinic.Models;
using Clinic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.Repositories
{
    public interface IAppointmentRepo
    {
        IEnumerable<Appointment> GetAppointments();
        IEnumerable<Appointment> GetAppointmentWithPatient(int id);
        IEnumerable<Appointment> GetAppointmentByDoctor(int id);
        IEnumerable<Appointment> GetTodaysAppointments(int id);
        IEnumerable<Appointment> GetUpcommingAppointments(string userId);
        IEnumerable<Appointment> GetDaillyAppointments(DateTime getDate);
        IQueryable<Appointment> FilterAppointments(AppointmentSearchVM searchModel);
        bool ValidateAppointment(DateTime appntDate, int id);
        int CountAppointments(int id);
        Appointment GetAppointment(int id);
        void Add(Appointment appointment);
    }
}