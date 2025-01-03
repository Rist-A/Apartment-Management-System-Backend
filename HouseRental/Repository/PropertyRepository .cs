using HouseRental.Data;
using HouseRental.Interfaces;
using HouseRental.Modules;

namespace HouseRental.Repository
{
    public class PropertyRepository: IPropertyRepository
    {
        private readonly DataContext _context;

        public PropertyRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Property> GetAllProperties()
        {
            return _context.Properties.ToList();
        }

        public IEnumerable<Property> GetPropertiesByLocation(string location)
        {
            return _context.Properties.Where(p => p.Location == location).ToList();
        }

        public IEnumerable<Property> GetPropertiesByPrice(decimal minPrice, decimal maxPrice)
        {
            return _context.Properties.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }

        public IEnumerable<Property> GetPropertiesByTitle(string title)
        {
            return _context.Properties.Where(p => p.Title.Contains(title)).ToList();
        }

        public void UpdatePropertyStatus(int propertyId, string newStatus)
        {
            var property = _context.Properties.FirstOrDefault(p => p.PropertyId == propertyId);
            if (property != null)
            {
                property.Status = newStatus;
                _context.SaveChanges();
            }
        }

        public void AddProperty(Property property)
        {
            _context.Properties.Add(property);
            _context.SaveChanges();
        }

        public void DeleteProperty(int propertyId)
        {
            var property = _context.Properties.FirstOrDefault(p => p.PropertyId == propertyId);
            if (property != null)
            {
                _context.Properties.Remove(property);
                _context.SaveChanges();
            }
        }
    }
}
