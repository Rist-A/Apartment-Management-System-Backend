using HouseRental.Data;
using HouseRental.Interfaces;
using HouseRental.Modules;

namespace HouseRental.Repository
{
    public class StaffRepository: IStaffRepository
    {
        private readonly DataContext _context;

        public StaffRepository(DataContext context)
        {
            _context = context;
        }

        public Staff AuthenticateStaff(string staffName, string staffPassword)
        {
            // Check if staff name and password match
            return _context.Staffs.FirstOrDefault(s => s.StaffName == staffName && s.StaffPassword == staffPassword);
        }
    }

}
