using Richard.Tutorial.DAL;
using Richard.Tutorial.DTL;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace Richard.Tutorial.BLL
{
    public class CityBLO : ICityBLO
    {

        #region Private variables
        IMessageBuilder MessageBuilder;
        IMessageDTO Message;
        ICityDAO CityDAO;
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

        #region Constructors
        public CityBLO(IMessageBuilder _messageBuilder, IMessageDTO _message, ICityDAO _cityDAO)
        {
            MessageBuilder = _messageBuilder;
            Message = _message;
            CityDAO = _cityDAO;
        }
        #endregion

        #region Public Methods
        public async Task GetAll()
        {
            try
            {
                IList lstResult = await CityDAO.GetAll();
                MessageBuilder.BuildMessage(Resources.LanguageResources.ListAllItems,
                    Resources.LanguageResources.Success, ref Message, null, lstResult);
            }
            catch (Exception Ex)
            {

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                    Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task GetAll(int CityId)
        {
            try
            {
                IList lstResult = await CityDAO.GetAll(CityId);
                MessageBuilder.BuildMessage(Resources.LanguageResources.ListAllItems,
                    Resources.LanguageResources.Success, ref Message, null, lstResult);


            }
            catch (Exception Ex)
            {

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                    Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task Create(CityDTO eCity)
        {

            /*  if (string.IsNullOrEmpty(eCity.Name))
              {
                  // TO DO, 
                  MessageBuilder.BuildMessage(Resources.LanguageResources.ElCampoNombreEsObligatorio,
                           Resources.LanguageResources.Warning, ref Message);

              }*/


            try
            {
                await CityDAO.Create(eCity);

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericCreationSuccess,
                      Resources.LanguageResources.Success, ref Message);
            }
            catch (Exception Ex)
            {
                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                    Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task Update(CityDTO eCity)
        {
            try
            {
                await CityDAO.Update(eCity);

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericUpdateSuccess,
                      Resources.LanguageResources.Success, ref Message);
            }
            catch (Exception Ex)
            {
                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                    Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task Delete(int CityId)
        {
            try
            {
                await CityDAO.Delete(CityId);

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericDeleteSuccess,
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
