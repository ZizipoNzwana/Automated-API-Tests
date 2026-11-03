using System;
using PetStoreTests;
using RestSharp;

namespace PetStoreTests;

public class Inventory {
    public int Sold { get; set; }
    public int Pending { get; set; }
    public int Available { get; set; }

}
