using Autofac;
using Autofac.Integration.WebApi;
using Richard.Tutorial.BLL;
using Richard.Tutorial.DAL;
using Richard.Tutorial.DTL;
using Richard.Tutorial.Model;
using System.Reflection;

namespace Richard.Tutorial.Middleware
{
    public static class AutoFacSetup
    {
        public static ContainerBuilder SetupAutoFac(Assembly WebApiAssembly)
        {
            ContainerBuilder builder = new ContainerBuilder();

            #region Inyección IoC Model
            builder.RegisterType<RichardTutorialEntities>().As<RichardTutorialEntities>();
            #endregion

            #region Inyección IoC WebApi
            builder.RegisterApiControllers(WebApiAssembly);
            #endregion

            #region Inyección IoC DAL
            builder.RegisterType<CityDAO>().As<ICityDAO>();
            builder.RegisterType<CountryDAO>().As<ICountryDAO>();
            builder.RegisterType<UserDAO>().As<IUserDAO>();
            builder.RegisterType<OrderDAO>().As<IOrderDAO>();
            #endregion

            #region Inyección IoC BLL
            builder.RegisterType<MessageBuilder>().As<IMessageBuilder>();
            builder.RegisterType<CityBLO>().As<ICityBLO>();
            builder.RegisterType<CountryBLO>().As<ICountryBLO>();
            builder.RegisterType<UserBLO>().As<IUserBLO>();
            builder.RegisterType<OrderBLO>().As<IOrderBLO>();
            #endregion

            #region Inyección IoC DTL
            builder.RegisterType<MessageDTO>().As<IMessageDTO>();
            #endregion

            return builder;
        } 
    }
}
