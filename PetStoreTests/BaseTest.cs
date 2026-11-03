using PetStoreTests;
using RestSharp;

namespace PetStoreTests;

public class BaseTest
{
    protected RestClient client;

    [SetUp]
    public void Initialise()
    {
        client = new RestClient("http://localhost/v2");
    }
    public Inventory GetInventory()                                                 
    {
        var request = new RestRequest("/store/inventory");
        return client.GetAsync<Inventory>((request)).GetAwaiter().GetResult();      
    }
  
}

