using Ferdo.Track.Framework.Core;
using Ferdo.Track.Framework.Core.Query;
using Ferdo.Track.Framework.Core.Services;
using Ferdo.Track.Framework.DI;
using Ferdo.Track.Framework.Repository;
using Ferdo.Track.Infrastructure;
using Ferdo.Track.Persistence.DbContext;
using Ferdo.Track.Read;
using Ferdo.Track.Services.Initial;
using Common.ApplicationIdentity;
using Ferdo.Track.Framework.Core.Repository;
using Ferdo.Track.Services.ConfigurationContext;
using Ferdo.Track.Services.LocationContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Ferdo.Track.Configuration
{
    public class Registrar
    {

        public void Register(IServiceCollection services)
        {
            services.AddScoped<UserManager<ApplicationUser>>();
            services.AddScoped<RoleManager<ApplicationRole>>();
            services.AddScoped<IDiContainer>(sp => new DiContainer(sp));
            services.AddScoped<ServiceLocator>();

            services.AddScoped<IIdentityRepository, IdentityRepository>();
            
            services.AddScoped<IUnderTrackRepository, UnderTrackRepository>();
            services.AddScoped<IUnderTrackQuery, UnderTrackQuery>();

            services.AddScoped<ITrackSettingRepository, TrackSettingRepository>();

            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<ILocationQuery, LocationQuery>();
            services.AddScoped<ILocationService, LocationService>();
            
            services.AddScoped<ICenterService, CenterService>();
            services.AddScoped<ICenterRepository, CenterRepository>();
            services.AddScoped<IUnderTrackService, UnderTrackService>();


            services.AddScoped<IInitialService, InitializerService>();

            



            services.AddScoped<InitializerService>();
        }
    }
}
