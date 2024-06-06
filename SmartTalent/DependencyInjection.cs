using SmartTalent.Interfaces;
using SmartTalent.Services;

namespace SmartTalent
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomizedServicesProject(this IServiceCollection services)
        {
            services.AddScoped<IHotelServices, HotelServices>();
            services.AddScoped<IBookingServices, BookingServices>();
            services.AddScoped<IRoomServices, RoomServices>();

            return services;
        }
    }
}
