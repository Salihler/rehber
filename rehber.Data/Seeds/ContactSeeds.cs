using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rehber.Core.Models;

namespace rehber.Data.Seeds
{
    public class ContactSeeds : IEntityTypeConfiguration<Contact>
    {
        private readonly int[] _ids;

        public ContactSeeds(int [] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasData(
                new Contact{Id = _ids[0], Name = "Eren", Surname = "Salihler", Company = "Meydan Bilişim"},
                new Contact{Id = _ids[1], Name = "İlker", Surname = "Ayrık", Company = "Kısmet Bilişim"},
                new Contact{Id = _ids[2], Name = "Sude Naz", Surname = "Mert", Company = "Etik Teknoloji"},
                new Contact{Id = _ids[3], Name = "Ahmet", Surname = "Bulut", Company = "Hürtek Bilişim"},
                new Contact{Id = _ids[4], Name = "Hakan Vehbi", Surname = "Şenova", Company = "Yalova Danışmanlık"},
                new Contact{Id = _ids[5], Name = "Türkan", Surname = "Altıntaş", Company = "Sahra Telekomünikasyon"},
                new Contact{Id = _ids[6], Name = "Zehra", Surname = "Topçu", Company = "Bağlam Teknoloji"},
                new Contact{Id = _ids[7], Name = "Serdar", Surname = "Kuzuloğlu", Company = "Kuzuloğlu Bilişim"},
                new Contact{Id = _ids[8], Name = "Mert", Surname = "Karabacak", Company = "Turkuaz Bilişim"},
                new Contact{Id = _ids[9], Name = "Faruk", Surname = "Kakşi", Company = "Egirişim Bilişim"},
                new Contact{Id = _ids[10], Name = "Debor", Surname = "Landers", Company = "Goldner-O'Connell"},
                new Contact{Id = _ids[11], Name = "Emlynn", Surname = "Hammett", Company = "Parisian, Parker and O'Conner"},
                new Contact{Id = _ids[12], Name = "Rance", Surname = "Courtney", Company = "Lesch, Mayer and Morar"},
                new Contact{Id = _ids[13], Name = "Coretta", Surname = "Eskriett", Company = "Waelchi, Steuber and Weissnat"},
                new Contact{Id = _ids[14], Name = "Osgood", Surname = "Spellar", Company = "Mann Inc"},
                new Contact{Id = _ids[15], Name = "Lexy", Surname = "Chelam", Company = "Prosacco, Christiansen and Trantow"},
                new Contact{Id = _ids[16], Name = "Kyle", Surname = "Kupker", Company = "Larkin, Mueller and Koch"},
                new Contact{Id = _ids[17], Name = "Nancee", Surname = "Studdeard", Company = "Beer-Torp"},
                new Contact{Id = _ids[18], Name = "Kaye", Surname = "Wiggett", Company = "Stark Inc"},
                new Contact{Id = _ids[19], Name = "Florenza", Surname = "Loughhead", Company = "Lehner, McLaughlin and Conroy"},
                new Contact{Id = _ids[20], Name = "Denice", Surname = "Shilleto", Company = "Spinka-Hirthe"},
                new Contact{Id = _ids[21], Name = "Fanny", Surname = "Polland", Company = "Hermann LLC"},
                new Contact{Id = _ids[22], Name = "Lynne", Surname = "Bolles", Company = "Stracke, Hamill and Kulas"}
            );
        }
    }
}