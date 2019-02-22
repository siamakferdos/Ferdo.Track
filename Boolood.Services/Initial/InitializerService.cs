using System.Linq;
using Common.ApplicationIdentity;
using Ferdo.Track.Framework.Core.Repository;
using Ferdo.Track.Framework.Core.Services;

namespace Ferdo.Track.Services.Initial
{
    public class InitializerService: IInitialService
    {
        
        private readonly IUnderTrackRepository _underTrackRepository;
        private readonly IIdentityRepository _identityRepository;
        private readonly ITrackSettingRepository _trackSettingRepository;

        public InitializerService(
            IIdentityRepository identityRepository, 
            IUnderTrackRepository underTrackRepository,
            ITrackSettingRepository trackSettingRepository)
        {
            _underTrackRepository = underTrackRepository;
            _identityRepository = identityRepository;
            _trackSettingRepository= trackSettingRepository;
        }

        public void Init()
        {
            SeedRoles();
            SeedUsers();
            SeedUnderTrackData();
            SeedSettingData();
        }

        private void SeedUnderTrackData()
        {
            var underTrackTypes = InitializationConstants.UnderTrackTypes;
            var dbTypes = _underTrackRepository.GetTypes().ToList();
            for (int i = underTrackTypes.Count - 1; i >= 0; i--)
            {
                if(dbTypes.Any(t => t.Name == underTrackTypes[i].Name))
                    underTrackTypes.RemoveAt(i);
            }
            if(underTrackTypes.Any())
                _underTrackRepository.AddTypes(underTrackTypes);
        }

        private void SeedSettingData()
        {
            var settingUnitLevels = InitializationConstants.SettingUnitLevels;
            var dbSettings = _trackSettingRepository.GetSettingUnitLevels().ToList();
            for (int i = settingUnitLevels.Count - 1; i >= 0; i--)
            {
                if (dbSettings.Any(t => t.Name == settingUnitLevels[i].Name))
                    settingUnitLevels.RemoveAt(i);
            }
            if (settingUnitLevels.Any())
                _trackSettingRepository.AddSettingUnitLevels(settingUnitLevels);
        }

        private void SeedRoles()
        {
            if (!_identityRepository.IsRoleExist("NormalUser"))
            {
                _identityRepository.AddRole(new ApplicationRole("NormalUser"));
            }

            if (!_identityRepository.IsRoleExist("AppAdmin"))
            {
                _identityRepository.AddRole(new ApplicationRole("AppAdmin"));
            }

            if (!_identityRepository.IsRoleExist("Administrator"))
            {
                _identityRepository.AddRole(new ApplicationRole("Administrator"));
            }
        }

        private void SeedUsers()
        {
            if (!_identityRepository.IsUserExist("siamak.ferdos@gmail.com"))
            {
                var result = _identityRepository.AddUser(
                    InitializationConstants.AdminUser, InitializationConstants.AdminPassword);
                if (result.Succeeded)
                {
                    _identityRepository.AddToRole(
                        InitializationConstants.AdminUser, "Administrator");
                }
            }
        }
    }
}
