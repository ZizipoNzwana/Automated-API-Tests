using RestSharp;

namespace PetstoreTests;

public class BaseTest
{
    protected RestClient client;

    [SetUp]
    public void Initialise()
    {
        client = new RestClient("http://localhost/v2");
    }
}