using Microsoft.Win32.SafeHandles;
using Microsoft.EntityFrameworkCore;
using FMA.Application.Entities;

namespace FMA.Application.Data;

public static class ModelBuilderExtensions
{
    public static void SeedDomains(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain>().HasData(
            new Domain { Id = 1, DomainName = "Manual Labor", PhotoPath = "https://freelanceme.blob.core.windows.net/container1/manual_labor", BorderColor = "#fdf1d3" },
            new Domain { Id = 2, DomainName = "Domestic Services", PhotoPath = "https://freelanceme.blob.core.windows.net/container1/domestic_services", BorderColor = "#f3fee7" },
            new Domain { Id = 3, DomainName = "Health & Welness ", PhotoPath = "https://freelanceme.blob.core.windows.net/container1/health_and_wellness", BorderColor = "#fee7e7" },
            new Domain { Id = 4, DomainName = "Business Services", PhotoPath = "https://freelanceme.blob.core.windows.net/container1/business_services", BorderColor ="#e7edfe" },
            new Domain { Id = 5, DomainName = "Home Technology", PhotoPath = "https://freelanceme.blob.core.windows.net/container1/home_technology", BorderColor = "#ffeab5" },
            new Domain { Id = 6, DomainName = "Pet Care", PhotoPath = "https://freelanceme.blob.core.windows.net/container1/pets", BorderColor="#dcffb5" },
            new Domain { Id = 7, DomainName = "Performing Arts", PhotoPath = "https://freelanceme.blob.core.windows.net/container1/performing_arts", BorderColor = "#fdf1d3" }
        );
    }

    public static void SeedExpertises(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Expertise>().HasData(
            new Expertise {PhotoPath="/", Id = 1, ExpertiseName = "Furniture assembler", DomainId = 1 },
            new Expertise {PhotoPath="/", Id = 2, ExpertiseName = "Chauffeur", DomainId = 1 },
            new Expertise {PhotoPath="/", Id = 3, ExpertiseName = "Painter", DomainId = 1 },
            new Expertise {PhotoPath="/", Id = 4, ExpertiseName = "Carpenter", DomainId = 1 },
            new Expertise {PhotoPath="/", Id = 5, ExpertiseName = "Roof repairer", DomainId = 1 },

            new Expertise {PhotoPath="/", Id = 6, ExpertiseName = "Housekeeper", DomainId = 2 },
            new Expertise {PhotoPath="/", Id = 7, ExpertiseName = "Housesitter", DomainId = 2 },
            new Expertise {PhotoPath="/", Id = 8, ExpertiseName = "Babysitter", DomainId = 2 },
            new Expertise {PhotoPath="/", Id = 9, ExpertiseName = "Nanny", DomainId = 2 },
            new Expertise {PhotoPath="/", Id = 10, ExpertiseName = "Caregiver", DomainId = 2 },
            new Expertise {PhotoPath="/", Id = 11, ExpertiseName = "Cook", DomainId = 2 },
            new Expertise {PhotoPath="/", Id = 12, ExpertiseName = "Kitchen cleaner", DomainId = 2 },
            new Expertise {PhotoPath="/", Id = 13, ExpertiseName = "Gardener", DomainId = 2 },
            new Expertise {PhotoPath="/", Id = 14, ExpertiseName = "Grocery shopper", DomainId = 2 },
            
            // new Expertise(Id = 15, ExpertiseName = "Chiropractor", DomainId = 3 },
            // new Expertise(Id = 16, ExpertiseName = "Health aide", DomainId = 3 },
            // new Expertise(Id = 17, ExpertiseName ="Personal trainer", DomainId = 3 },
            // new Expertise(Id = 18, ExpertiseName ="Elderly companion", DomainId = 3 },
            
            // new Expertise(Id = 19, ExpertiseName ="Tutor", DomainId = 4 },
            // new Expertise(Id = 20, ExpertiseName ="Personal assistant", DomainId = 4 },
            // new Expertise(Id = 21, ExpertiseName ="Interior designer", DomainId = 4 },
            // new Expertise(Id = 22, ExpertiseName ="Stylist", DomainId = 4 },

            // new Expertise(Id = 23, ExpertiseName ="WiFi/Router technician", 23 },
            // new Expertise(Id = 24, ExpertiseName ="Computer repair technician", 24 },
            // new Expertise(Id = 25, ExpertiseName ="Plumber", 25),
            // new Expertise(Id = 26, ExpertiseName ="Electrical appliance installer", 26),
            // new Expertise(Id = 27, ExpertiseName ="Pet sitter", 27),
            // new Expertise(Id = 28, ExpertiseName ="Dog walker", 28),
            // new Expertise(Id = 29, ExpertiseName ="Pet groomer", 29),
            // new Expertise(Id = 30, ExpertiseName ="Music teacher", 30),
            new Expertise {PhotoPath="/", Id = 31, ExpertiseName ="Dance teacher", DomainId = 3 }
    );
    }

    public static void SeedFreelancers(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Freelancer>().HasData(
            new Freelancer
            {
                Id = 1,
                FirstName = "Nadia",
                LastName = "Al-Saud",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-60),
                PhotoPath = "/images/nadia.jpg",
                Email = "nadia@example.com",
                PhoneNumber = "+966504567890",
                HourlyRate = 55,
                Rating = 4.7m,
                FulfilledContracts = 15,
                HoursBilled = 300,
                Latitude = 26.4207m,
                Longitude = 50.0888m,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 3
            },
            new Freelancer
            {
                Id = 2,
                FirstName = "Khalid",
                LastName = "Al-Farsi",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-90),
                PhotoPath = "/images/khalid.jpg",
                Email = "khalid@example.com",
                PhoneNumber = "+966509876543",
                HourlyRate = 45,
                Rating = 4.6m,
                FulfilledContracts = 18,
                HoursBilled = 350,
                Latitude = 23.8859m,
                Longitude = 45.0792m,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 2
            },
            new Freelancer
            {
                Id = 3,
                FirstName = "Sara",
                LastName = "Al-Qahtani",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-45),
                PhotoPath = "/images/sara.jpg",
                Email = "sara@example.com",
                PhoneNumber = "+966501234567",
                HourlyRate = 65,
                Rating = 4.9m,
                FulfilledContracts = 30,
                HoursBilled = 600,
                Latitude = 24.7743m,
                Longitude = 46.7384m,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 2
            },
            new Freelancer
            {
                Id = 4,
                FirstName = "Yousef",
                LastName = "Al-Ghamdi",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-75),
                PhotoPath = "/images/yousef.jpg",
                Email = "yousef@example.com",
                PhoneNumber = "+966504321098",
                HourlyRate = 70,
                Rating = 4.5m,
                FulfilledContracts = 22,
                HoursBilled = 450,
                Latitude = 21.4858m,
                Longitude = 39.1925m,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 4
            },
            new Freelancer
            {
                Id = 5,
                FirstName = "Layla",
                LastName = "Al-Omari",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-100),
                PhotoPath = "/images/layla.jpg",
                Email = "layla@example.com",
                PhoneNumber = "+966509876543",
                HourlyRate = 55,
                Rating = 4.8m,
                FulfilledContracts = 28,
                HoursBilled = 550,
                Latitude = 26.4207m,
                Longitude = 50.0888m,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 1
            },
            new Freelancer
            {
                Id = 6,
                FirstName = "Omar",
                LastName = "Al-Zahrani",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-55),
                PhotoPath = "/images/omar.jpg",
                Email = "omar@example.com",
                PhoneNumber = "+966501234567",
                HourlyRate = 60,
                Rating = 4.7m,
                FulfilledContracts = 19,
                HoursBilled = 380,
                Latitude = 23.8859m,
                Longitude = 45.0792m,
                IsActive = true,
                DomainId = 2,
                MainExpertiseId = 3
            },
            new Freelancer
            {
                Id = 7,
                FirstName = "Huda",
                LastName = "Al-Muhanna",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-85),
                PhotoPath = "/images/huda.jpg",
                Email = "huda@example.com",
                PhoneNumber = "+966504567890",
                HourlyRate = 65,
                Rating = 4.6m,
                FulfilledContracts = 24,
                HoursBilled = 500,
                Latitude = 24.7743m,
                Longitude = 46.7384m,
                IsActive = true,
                DomainId = 2,
                MainExpertiseId = 3
            },
            new Freelancer
            {
                Id = 8,
                FirstName = "Fahad",
                LastName = "Al-Rashidi",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-70),
                PhotoPath = "/images/fahad.jpg",
                Email = "fahad@example.com",
                PhoneNumber = "+966501234567",
                HourlyRate = 50,
                Rating = 4.9m,
                FulfilledContracts = 32,
                HoursBilled = 640,
                Latitude = 24.7136m,
                Longitude = 46.6753m,
                IsActive = true,
                DomainId = 2,
                MainExpertiseId = 3
            },
            new Freelancer
            {
                Id = 9,
                FirstName = "Amal",
                LastName = "Al-Mutairi",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-110),
                PhotoPath = "/images/amal.jpg",
                Email = "amal@example.com",
                PhoneNumber = "+966501111222",
                HourlyRate = 55,
                Rating = 4.8m,
                FulfilledContracts = 26,
                HoursBilled = 520,
                Latitude = 21.4858m,
                Longitude = 39.1925m,
                IsActive = true,
                DomainId = 2,
                MainExpertiseId = 3
            },
            new Freelancer
            {
                Id = 10,
                FirstName = "Abdullah",
                LastName = "Al-Qassem",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-95),
                PhotoPath = "/images/abdullah.jpg",
                Email = "abdullah@example.com",
                PhoneNumber = "+966509876543",
                HourlyRate = 70,
                Rating = 4.7m,
                FulfilledContracts = 21,
                HoursBilled = 420,
                Latitude = 26.4207m,
                Longitude = 50.0888m,
                IsActive = true,
                DomainId = 2,
                MainExpertiseId = 3
            },
            new Freelancer
            {
                Id = 11,
                FirstName = "Noura",
                LastName = "Al-Sulaiman",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-80),
                PhotoPath = "/images/noura.jpg",
                Email = "noura@example.com",
                PhoneNumber = "+966504321098",
                HourlyRate = 60,
                Rating = 4.9m,
                FulfilledContracts = 29,
                HoursBilled = 580,
                Latitude = 23.8859m,
                Longitude = 45.0792m,
                IsActive = true,
                DomainId = 2,
                MainExpertiseId = 3
            }
        );
    }

    public static void SeedFreelancerExpertise(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Freelancer>(etb => 
        {
            etb
                .HasMany(f => f.Expertises)
                .WithMany(e => e.Freelancers)
                .UsingEntity(j =>
                    {
                        j.HasData(
                            new { FreelancerId = 1, ExpertiseId = 1 },
                            new { FreelancerId = 1, ExpertiseId = 2 },
                            new { FreelancerId = 2, ExpertiseId = 2 },
                            new { FreelancerId = 3, ExpertiseId = 2 },
                            new { FreelancerId = 3, ExpertiseId = 1 },
                            new { FreelancerId = 4, ExpertiseId = 3 },
                            new { FreelancerId = 4, ExpertiseId = 4 },
                            new { FreelancerId = 5, ExpertiseId = 3 },
                            new { FreelancerId = 5, ExpertiseId = 1 }
                        );
                    });
        });
    }
}