using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbVolunteer
{
    class ContextInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            Organization organization = new Organization();
            organization.Id = Guid.NewGuid();
            organization.Name = "Organization 1";
            organization.Address = new Address() {Id = Guid.NewGuid(), City = "Minsk", Street = "Tolstogo", House = "8", Ads = new List<Ads>()};
            organization.MyAds = new List<Ads>();
            organization.Contacts = new List<Contacts>();
            organization.Fotos = new List<Foto>();

            Description desc = new Description();
            desc.Id = Guid.NewGuid();
            desc.Info = "Info Description";
            desc.Name = "Description 1";

            HelpType h = new HelpType() {Id = Guid.NewGuid(), Name = "Физическая", Ads = new List<Ads>()};

            Address adsAddress = new Address() { Id = Guid.NewGuid(), City = "Minsk", Street = "Plehanova", House = "72", FlatNum = "16", Ads = new List<Ads>() };
            Ads ads = new Ads() {Id = Guid.NewGuid(),Organizer = organization, Description = desc, IsOpen = true, MaxValCount = 5, Address = adsAddress, TimeOfStart = DateTime.Now, Coments = "Comment 1",HelpType = h, SubsVal = new SubsVal() {Id = Guid.NewGuid()} };

            adsAddress.Ads.Add(ads);
            h.Ads.Add(ads);
            organization.MyAds.Add(ads);
            context.Organization.Add(organization);
            context.Ads.Add(ads);
            context.SaveChanges();

            organization = new Organization();
            organization.Id = Guid.NewGuid();
            organization.Name = "Organization 2";
            organization.Address = new Address() { Id = Guid.NewGuid(), City = "Moscow", Street = "Tolstogo", House = "38", Ads = new List<Ads>() };
            organization.MyAds = new List<Ads>();
            organization.Contacts = new List<Contacts>();
            organization.Fotos = new List<Foto>();

            desc = new Description();
            desc.Id = Guid.NewGuid();
            desc.Info = "Info Description";
            desc.Name = "Description 2";

            adsAddress = new Address() { Id = Guid.NewGuid(), City = "Moscow", Street = "Plehanova", House = "61", FlatNum = "152", Ads = new List<Ads>() };
            ads = new Ads() { Id = Guid.NewGuid(), Organizer = organization, Description = desc, IsOpen = true, MaxValCount = 15, Address = adsAddress, TimeOfStart = DateTime.Now, Coments = "Comment 2", HelpType = h, SubsVal = new SubsVal() { Id = Guid.NewGuid() } };

            adsAddress.Ads.Add(ads);
            h.Ads.Add(ads);
            organization.MyAds.Add(ads);
            context.Organization.Add(organization);
            context.Ads.Add(ads);

            context.SaveChanges();
        }
    }
}
