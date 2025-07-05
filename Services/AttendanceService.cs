using System;
using test1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace test1.Services
{
  public class AttendanceService
    {
        private List<AttendanceRecord> _attendanceRecords = new();

        public void Mark(string username)
        {
            _attendanceRecords.Add(new AttendanceRecord
            {
                Username = username,
                Timestamp = DateTime.Now
            });
        }

        public List<AttendanceRecord> GetAll()
        {
            return _attendanceRecords;
        }
    }
    }
