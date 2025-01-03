using HouseRental.Modules;

namespace HouseRental.Interfaces
{
    
        public interface IStaffRepository
        {
            Staff AuthenticateStaff(string staffName, string staffPassword); // New method
        }

    
}
