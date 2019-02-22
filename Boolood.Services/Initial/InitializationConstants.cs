using Common.ApplicationIdentity;
using System;
using System.Collections.Generic;
using Ferdo.Track.Model.DbModels;

namespace Ferdo.Track.Services.Initial
{
    internal class InitializationConstants
    {
        public static List<UnderTrackType> UnderTrackTypes =
            new List<string>{
                    "ماشین", "شخص", "تریلی", "کامیونت", "کامیونت یخچال دار"}.
                ConvertAll(t => new UnderTrackType
                {
                    Name = t
                });

        public static List<SettingUnitLevel> SettingUnitLevels =
            new List<string>{
                    "همه", "گروهی", "انفرادی"}.
                ConvertAll(t => new SettingUnitLevel
                {
                    Name = t
                });

        public static ApplicationUser AdminUser = new ApplicationUser
        {
            Email = "siamak.ferdos@gmail.com",
            NormalizedUserName = "siamak.ferdos@gmail.com",
            NormalizedEmail = "siamak.ferdos@gmail.com".ToUpper(),
            FirstName = "Siamak",
            LastName = "B.Ferdos",
            EmailConfirmed = true,
            CreationDate = DateTimeOffset.Now,
            AccessFailedCount = 5,
            PhoneNumber = "00989143058600",
            PhoneNumberConfirmed = true,
            TwoFactorEnabled = true,
            UserName = "siamak.ferdos@gmail.com"
        };
        
        public static string AdminPassword = "76F8%tfy_GH";
    }
}
