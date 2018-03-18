using Richard.Tutorial.DAL;
using Richard.Tutorial.DTL;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace Richard.Tutorial.BLL
{
    public class UserBLO : IUserBLO
    {
        #region Private variables
        IMessageBuilder MessageBuilder;
        IMessageDTO Message;
        IUserDAO UserDAO;
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
        public UserBLO(IMessageBuilder _messageBuilder, IMessageDTO _message, IUserDAO _userDAO)
        {
            MessageBuilder = _messageBuilder;
            Message = _message;
            UserDAO = _userDAO;
        }
        #endregion

        #region Public Methods
        public async Task GetAll()
        {
            try
            {
                IList lstResult = await UserDAO.GetAll();
                MessageBuilder.BuildMessage(Resources.LanguageResources.ListAllItems,
                    Resources.LanguageResources.Success, ref Message, null, lstResult);
            }
            catch (Exception Ex)
            {

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                    Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task GetAll(int UserId)
        {
            try
            {
                IList lstResult = await UserDAO.GetAll(UserId);
                MessageBuilder.BuildMessage(Resources.LanguageResources.ListAllItems,
                    Resources.LanguageResources.Success, ref Message, null, lstResult);


            }
            catch (Exception Ex)
            {

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                    Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task Create(UserDTO eUser)
        {
            try
            {
                await UserDAO.Create(eUser);

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericCreationSuccess,
                      Resources.LanguageResources.Success, ref Message);
            }
            catch (Exception Ex)
            {
                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                    Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task Update(UserDTO eUser)
        {
            try
            {
                await UserDAO.Update(eUser);

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericUpdateSuccess,
                      Resources.LanguageResources.Success, ref Message);
            }
            catch (Exception Ex)
            {
                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                    Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task Delete(int UserId)
        {
            try
            {
                await UserDAO.Delete(UserId);

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
