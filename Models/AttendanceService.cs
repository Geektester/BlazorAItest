public class AttendanceService
{
    private readonly List<AttendanceRecord> _records = new();

    public void MarkAttendance(string username)
    {
        _records.Add(new AttendanceRecord
        {
            Username = username,
            Timestamp = DateTime.Now
        });
    }

    public List<AttendanceRecord> GetRecords() => _records;
}
