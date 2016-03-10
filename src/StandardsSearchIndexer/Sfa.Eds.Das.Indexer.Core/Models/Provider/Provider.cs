﻿using System.Collections.Generic;
using Sfa.Eds.Das.Indexer.Common.Models;

namespace Sfa.Eds.Das.Indexer.Core.Models.Provider
{
    public sealed class Provider : IIndexEntry // TODO: LWA Should this interface be on here?
    {
        public int Id { get; set; }

        public int Ukprn { get; set; }

        public string Name { get; set; }

        public ContactInformation ContactDetails { get; set; }

        public string MarketingInfo { get; set; }

        public double? EmployerSatisfaction { get; set; }

        public double? LearnerSatisfaction { get; set; }

        public IEnumerable<FrameworkInformation> Frameworks { get; set; }

        public IEnumerable<Location> Locations { get; set; }

        public IEnumerable<StandardInformation> Standards { get; set; }
    }

    public sealed class StandardInformation
    {
        public int StandardCode { get; set; }

        public ContactInformation StandardContact { get; set; }

        public string MarketingInfo { get; set; }

        public string StandardInfoUrl { get; set; }

        public IEnumerable<DeliveryInformation> DeliveryLocations { get; set; }

    }

    public sealed class FrameworkInformation
    {
        public int FrameworkCode { get; set; }

        public int Level { get; set; }

        public int PathwayCode { get; set; }

        public string FrameworkInfoUrl { get; set; }

        public ContactInformation FrameworkContact { get; set; }

        public string MarketingInfo { get; set; }

        public IEnumerable<DeliveryInformation> DeliveryLocations { get; set; }
    }

    public sealed class DeliveryInformation
    {

        public Location DeliveryLocation { get; set; }

        public IEnumerable<ModesOfDelivery> DeliveryModes { get; set; } // TODO: LWA - Use flags?

        public int Radius { get; set; }
    }

    public enum ModesOfDelivery
    {
        // TODO: LWA - Need to add description attribute to match
        OneHundredPercentEmployer,
        BlockRelease,
        DayRelease
    }

    public class Location
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public ContactInformation Contact { get; set; }
    }

    public sealed class Address
    {
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string County { get; set; }

        public string Town { get; set; }

        public string Postcode { get; set; }

        public Coordinate GeoPoint { get; set; }
    }

    public sealed class ContactInformation
    {
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }
    }
}
