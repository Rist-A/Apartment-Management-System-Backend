using HouseRental.Modules;

namespace HouseRental.Interfaces
{
    public interface IPropertyRepository
    {
        // Retrieve all properties
        IEnumerable<Property> GetAllProperties();

        // Retrieve properties by location
        IEnumerable<Property> GetPropertiesByLocation(string location);

        // Retrieve properties by price range
        IEnumerable<Property> GetPropertiesByPrice(decimal minPrice, decimal maxPrice);

        // Retrieve properties by title and status
        IEnumerable<Property> GetPropertiesByTitle(string title);

        // Update the status of a property
        void UpdatePropertyStatus(int propertyId, string newStatus);

        // Add a new property
        void AddProperty(Property property);

        // Delete a property by ID
        void DeleteProperty(int propertyId);
    }
}
