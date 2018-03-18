using Richard.Tutorial.DAL;
using Richard.Tutorial.DTL;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace Richard.Tutorial.BLL
{
    public class CountryBLO : ICountryBLO
    {
        #region Private variables
        IMessageBuilder MessageBuilder;
        IMessageDTO Message;
        ICountryDAO CountryDAO;
        #endregion

        #region Properties
        public IMessageDTO MessageResult
        {
            get
            {
                return Message;
            }
            private set
            {
                Message = value;
            }
        }
        #endregion

        #region Constructor
        public CountryBLO(IMessageBuilder _messageBuilder, IMessageDTO _message, ICountryDAO _countryDAO)
        {
            MessageBuilder = _messageBuilder;
            Message = _message;
            CountryDAO = _countryDAO;
        }
        #endregion

        #region Public Methods
        public async Task GetAll()
        {
            try
            {
                IList lstResult = await CountryDAO.GetAll();
                MessageBuilder.BuildMessage(Resources.LanguageResources.ListAllItems,
                    Resources.LanguageResources.Success, ref Message, null, lstResult);
            }
            catch (Exception Ex)
            {
                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                     Resources.LanguageResources.Error, ref Message, Ex);
            }
        }


        public async Task GetAll(int CountryId)
        {
            try
            {
                IList lstResult = await CountryDAO.GetAll(CountryId);
                MessageBuilder.BuildMessage(Resources.LanguageResources.ListAllItems,
                    Resources.LanguageResources.Success, ref Message, null, lstResult);
            }
            catch (Exception Ex)
            {
                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                     Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task Create(CountryDTO eCountry)
        {
            try
            {
                await CountryDAO.Create(eCountry);

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericCreationSuccess,
                    Resources.LanguageResources.Success, ref Message);
            }
            catch (Exception Ex)
            {
                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                     Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task Update(CountryDTO eCountry)
        {
            try
            {
                await CountryDAO.Update(eCountry);
                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericUpdateSuccess,
                    Resources.LanguageResources.Success, ref Message);
            }
            catch (Exception Ex)
            {
                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                     Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task Delete(int CountryId)
        {
            try
            {
                await CountryDAO.Delete(CountryId);
                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericUpdateSuccess,
                    Resources.LanguageResources.Success, ref Message);
            }
            catch (Exception Ex)
            {
                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                     Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        #endregion

    }
}
