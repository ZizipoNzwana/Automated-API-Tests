using System.Net;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using RestSharp;

namespace PetstoreTests;

public class InventoryTests : BaseTest
{
    [Test]
    public void GetInventoryShouldBeOk(){
    var request = new RestRequest("/store/inventory");

    var result = client.GetAsync((request)).GetAwaiter().GetResult();

    Assert.That(result.StatusCode, Is.EqualTo(HttpStatusCode.OK));
    Assert.That(result.Content, Is.Not.Null);
}
}