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
            new Expertise { Id = 1, ExpertiseName = "Furniture assembler", DomainId = 1,  PhotoPath = "https://freelanceme.blob.core.windows.net/container1/furniture_assembler", BorderColor = "#fdf1d3" },
            new Expertise { Id = 2, ExpertiseName = "Chauffeur", DomainId = 1, PhotoPath = "https://freelanceme.blob.core.windows.net/container1/chauffeur", BorderColor = "#f3fee7" },
            new Expertise { Id = 3, ExpertiseName = "Painter", DomainId = 1, PhotoPath = "https://freelanceme.blob.core.windows.net/container1/painter", BorderColor = "#fee7e7" },
            new Expertise { Id = 4, ExpertiseName = "Carpenter", DomainId = 1, PhotoPath = "https://freelanceme.blob.core.windows.net/container1/carpenter", BorderColor ="#e7edfe" },
            new Expertise { Id = 5, ExpertiseName = "Roof repairer", DomainId = 1,PhotoPath = "https://freelanceme.blob.core.windows.net/container1/roof_repairer", BorderColor = "#ffeab5" },
            new Expertise { Id = 6, ExpertiseName = "Packer", DomainId = 1, PhotoPath = "https://freelanceme.blob.core.windows.net/container1/packing_service", BorderColor = "#dcffb5" },
            new Expertise { Id = 7, ExpertiseName = "Window cleaner", DomainId = 1, PhotoPath = "https://freelanceme.blob.core.windows.net/container1/window_cleaner", BorderColor = "#fdf1d3" },
            new Expertise { Id = 8, ExpertiseName = "Yard worker", DomainId = 1, PhotoPath = "https://freelanceme.blob.core.windows.net/container1/yard_worker", BorderColor = "#f3fee7" }

            // new Expertise {PhotoPath="/", Id = 6, ExpertiseName = "Housekeeper", DomainId = 2 },
            // new Expertise {PhotoPath="/", Id = 7, ExpertiseName = "Housesitter", DomainId = 2 },
            // new Expertise {PhotoPath="/", Id = 8, ExpertiseName = "Babysitter", DomainId = 2 },
            // new Expertise {PhotoPath="/", Id = 9, ExpertiseName = "Nanny", DomainId = 2 },
            // new Expertise {PhotoPath="/", Id = 10, ExpertiseName = "Caregiver", DomainId = 2 },
            // new Expertise {PhotoPath="/", Id = 11, ExpertiseName = "Cook", DomainId = 2 },
            // new Expertise {PhotoPath="/", Id = 12, ExpertiseName = "Kitchen cleaner", DomainId = 2 },
            // new Expertise {PhotoPath="/", Id = 13, ExpertiseName = "Gardener", DomainId = 2 },
            // new Expertise {PhotoPath="/", Id = 14, ExpertiseName = "Grocery shopper", DomainId = 2 },
            
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
            //new Expertise {PhotoPath="/", Id = 31, ExpertiseName ="Dance teacher", DomainId = 3 }
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
                PhotoPath = "https://freelanceme.blob.core.windows.net/container1/m1",
                Email = "nadia@example.com",
                PhoneNumber = "+966504567890",
                HourlyRate = 55,
                Rating = 4.7,
                FulfilledContracts = 15,
                HoursBilled = 300,
                Latitude = 26.4207,
                Longitude = 50.0888,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 1
            },
            new Freelancer
            {
                Id = 2,
                FirstName = "Khalid",
                LastName = "Al-Farsi",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-90),
                PhotoPath = "https://freelanceme.blob.core.windows.net/container1/m2",
                Email = "khalid@example.com",
                PhoneNumber = "+966509876543",
                HourlyRate = 45,
                Rating = 4.6,
                FulfilledContracts = 18,
                HoursBilled = 350,
                Latitude = 23.8859,
                Longitude = 45.0792,
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
                PhotoPath = "https://freelanceme.blob.core.windows.net/container1/m3",
                Email = "sara@example.com",
                PhoneNumber = "+966501234567",
                HourlyRate = 65,
                Rating = 4.9,
                FulfilledContracts = 30,
                HoursBilled = 600,
                Latitude = 24.7743,
                Longitude = 46.7384,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 3
            },
            new Freelancer
            {
                Id = 4,
                FirstName = "Yousef",
                LastName = "Al-Ghamdi",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-75),
                PhotoPath = "https://freelanceme.blob.core.windows.net/container1/m4",
                Email = "yousef@example.com",
                PhoneNumber = "+966504321098",
                HourlyRate = 70,
                Rating = 4.5,
                FulfilledContracts = 22,
                HoursBilled = 450,
                Latitude = 21.4858,
                Longitude = 39.1925,
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
                PhotoPath = "https://freelanceme.blob.core.windows.net/container1/m5",
                Email = "layla@example.com",
                PhoneNumber = "+966509876543",
                HourlyRate = 55,
                Rating = 4.8,
                FulfilledContracts = 28,
                HoursBilled = 550,
                Latitude = 26.4207,
                Longitude = 50.0888,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 5
            },
            new Freelancer
            {
                Id = 6,
                FirstName = "Omar",
                LastName = "Al-Zahrani",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-55),
                PhotoPath = "https://freelanceme.blob.core.windows.net/container1/m6",
                Email = "omar@example.com",
                PhoneNumber = "+966501234567",
                HourlyRate = 60,
                Rating = 4.7,
                FulfilledContracts = 19,
                HoursBilled = 380,
                Latitude = 23.8859,
                Longitude = 45.0792,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 6
            },
            new Freelancer
            {
                Id = 7,
                FirstName = "Huda",
                LastName = "Al-Muhanna",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-85),
                PhotoPath = "https://freelanceme.blob.core.windows.net/container1/m7",
                Email = "huda@example.com",
                PhoneNumber = "+966504567890",
                HourlyRate = 65,
                Rating = 4.6,
                FulfilledContracts = 24,
                HoursBilled = 500,
                Latitude = 24.7743,
                Longitude = 46.7384,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 7
            },
            new Freelancer
            {
                Id = 8,
                FirstName = "Fahad",
                LastName = "Al-Rashidi",
                DateRegistered = DateTime.UtcNow.Date.AddDays(-70),
                PhotoPath = "https://freelanceme.blob.core.windows.net/container1/m8",
                Email = "fahad@example.com",
                PhoneNumber = "+966501234567",
                HourlyRate = 50,
                Rating = 4.9,
                FulfilledContracts = 32,
                HoursBilled = 640,
                Latitude = 24.7136,
                Longitude = 46.6753,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 8
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
                Rating = 4.8,
                FulfilledContracts = 26,
                HoursBilled = 520,
                Latitude = 21.4858,
                Longitude = 39.1925,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 8
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
                Rating = 4.7,
                FulfilledContracts = 21,
                HoursBilled = 420,
                Latitude = 26.4207,
                Longitude = 50.0888,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 8
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
                Rating = 4.9,
                FulfilledContracts = 29,
                HoursBilled = 580,
                Latitude = 23.8859,
                Longitude = 45.0792,
                IsActive = true,
                DomainId = 1,
                MainExpertiseId = 8
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
                            new { FreelancerId = 1, ExpertiseId = 4 },
                            new { FreelancerId = 2, ExpertiseId = 2 },
                            new { FreelancerId = 3, ExpertiseId = 3 },
                            new { FreelancerId = 4, ExpertiseId = 4 },
                            new { FreelancerId = 4, ExpertiseId = 1 },
                            new { FreelancerId = 5, ExpertiseId = 5 },
                            new { FreelancerId = 6, ExpertiseId = 6 },
                            new { FreelancerId = 7, ExpertiseId = 7 },
                            new { FreelancerId = 7, ExpertiseId = 3 },
                            new { FreelancerId = 8, ExpertiseId = 8 }
                        );
                    });
        });
    }
}