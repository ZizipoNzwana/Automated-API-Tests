using System.Net;
using RestSharp;

namespace PetStoreTests;

public class InventoryTests : BaseTest
{
    [Test]
    public void GetInventoryShouldBeOk()
{
    var request = new RestRequest("/store/inventory");

    var result = client.GetAsync((request)).GetAwaiter().GetResult();

    Assert.That(result.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    Assert.That(result.Content, Is.Not.Null);
}

    [Test]
    public void GetInventoryShouldReturnInventory()
    {
        // Arrange and Act
    var result = GetInventory();                                                
        
        // Assert
    Assert.That(result.Sold, Is.EqualTo(1));                                    
    Assert.That(result.Pending, Is.EqualTo(2));                                 
    Assert.That(result.Available, Is.EqualTo(7));                               
    }

}