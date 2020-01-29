using Clinic.Models;
using Clinic.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Clinic.Persistence.Repos
{
    public class DoctorRepo : IDoctorRepo
    {
        private readonly ApplicationDbContext _context;
        public DoctorRepo(ApplicationDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Doctor> GetDectors()
        {
            return _context.Doctors
                .Include(s => s.Specialization)
                .Include(u => u.Physician)
                .ToList();
        }

        /// <summary>
        /// Get the available doctors
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Doctor> GetAvailableDoctors()
        {
            return _context.Doctors
                .Where(a => a.IsAvailable == true)
                .Include(s => s.Specialization)
                .Include(u => u.Physician)
                .ToList();
        }
        /// <summary>
        /// Get single Doctor - Admin
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Doctor GetDoctor(int id)
        {
            return _context.Doctors
                .Include(s => s.Specialization)
                .Include(u => u.Physician)
                .SingleOrDefault(d => d.Id == id);
        }

        public Doctor GetProfile(string userId)
        {
            return _context.Doctors
                .Include(s => s.Specialization)
                .Include(u => u.Physician)
                .SingleOrDefault(d => d.PhysicianId == userId);
        }
        public void Add(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
        }
    }
}