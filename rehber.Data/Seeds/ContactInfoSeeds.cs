using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rehber.Core.Models;

namespace rehber.Data.Seeds
{
    public class ContactInfoSeeds : IEntityTypeConfiguration<ContactInfo>
    {
        private readonly int[] _ids;

        public ContactInfoSeeds(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder.HasData(
                new ContactInfo { Email = "oscurrey0@youku.com", Location = "İstanbul", Phone = "2342400655" , ContactId = _ids[1]},
                new ContactInfo { Email = "gbernaciak1@acquirethisname.com", Location = "Ankara", Phone = "2342400655" , ContactId = _ids[2]},
                new ContactInfo { Email = "pwhitby2@toplist.cz", Location = "İzmir", Phone = "1118092120" , ContactId = _ids[3]},
                new ContactInfo { Email = "ecloutt3@mlb.com", Location = "Yalova", Phone = "" , ContactId = _ids[4]},
                new ContactInfo { Email = "kharrie4@ifeng.com", Location = "Sakarya", Phone = "7489507530" , ContactId = _ids[5]},
                new ContactInfo { Email = "brides5@abc.net.au", Location = "İstanbul", Phone = "7691947729" , ContactId = _ids[1]},
                new ContactInfo { Email = "cklaesson6@hp.com", Location = "Ankara", Phone = "" , ContactId = _ids[6]},
                new ContactInfo { Email = "hmaffeo7@ameblo.jp", Location = "Ankara", Phone = "3821284995" , ContactId = _ids[6]},
                new ContactInfo { Email = "lbetteson8@usatoday.com", Location = "Sakarya", Phone = "8667477585" , ContactId = _ids[7]},
                new ContactInfo { Email = "ptrobridge9@umn.edu", Location = "Ankara", Phone = "" , ContactId = _ids[8]},
                new ContactInfo { Email = "hnevina@latimes.com", Location = "İstanbul", Phone = "8021354277" , ContactId = _ids[9]},
                new ContactInfo { Email = "lfeldsteinb@prweb.com", Location = "İstanbul", Phone = "5536238200" , ContactId = _ids[9]},
                new ContactInfo { Email = "lfenimorec@gmpg.org", Location = "İstanbul", Phone = "7196522971" , ContactId = _ids[10]},
                new ContactInfo { Email = "rwhitneyd@businesswire.com", Location = "İzmir", Phone = "8824035023" , ContactId = _ids[3]},
                new ContactInfo { Email = "bthrustlee@google.co.jp", Location = "Ankara", Phone = "" , ContactId = _ids[11]},
                new ContactInfo { Email = "kmatschukf@bigcartel.com", Location = "Ankara", Phone = "3703137647" , ContactId = _ids[6]},
                new ContactInfo { Email = "ijakovijevicg@wunderground.com", Location = "İstanbul", Phone = "6363145389" , ContactId = _ids[12]},
                new ContactInfo { Email = "lwarsaph@google.nl", Location = "Yalova", Phone = "8446085161" , ContactId = _ids[13]},
                new ContactInfo { Email = "kshouleri@zimbio.com", Location = "İstanbul", Phone = "" , ContactId = _ids[14]},
                new ContactInfo { Email = "fmaciejakj@umn.edu", Location = "Yalova", Phone = "" , ContactId = _ids[15]},
                new ContactInfo { Email = "gskepperk@tinypic.com", Location = "İzmir", Phone = "5274035864" , ContactId = _ids[16]},
                new ContactInfo { Email = "tmazinl@deviantart.com", Location = "İzmir", Phone = "2329410163" , ContactId = _ids[17]},
                new ContactInfo { Email = "dclutramm@joomla.org", Location = "Yalova", Phone = "3302071878" , ContactId = _ids[18]},
                new ContactInfo { Email = "slongdonn@indiegogo.com", Location = "Ankara", Phone = "3951718677" , ContactId = _ids[19]},
                new ContactInfo { Email = "ohalwardo@behance.net", Location = "İstanbul", Phone = "5705175010" , ContactId = _ids[20]},
                new ContactInfo { Email = "gmcdonellp@upenn.edu", Location = "Sakarya", Phone = "9527109266" , ContactId = _ids[21]},
                new ContactInfo { Email = "wtolmieq@gravatar.com", Location = "İstanbul", Phone = "6134982328" , ContactId = _ids[20]},
                new ContactInfo { Email = "kroderr@odnoklassniki.ru", Location = "Ankara", Phone = "3882548153" , ContactId = _ids[22]}
            );
        }
    }
}