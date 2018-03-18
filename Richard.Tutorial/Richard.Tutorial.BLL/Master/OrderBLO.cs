using Richard.Tutorial.DAL;
using Richard.Tutorial.DTL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richard.Tutorial.BLL
{
    public class OrderBLO : IOrderBLO
    {
        #region Private variables
        IMessageBuilder MessageBuilder;
        IMessageDTO Message;
        IOrderDAO OrderDAO;
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
        public OrderBLO(IMessageBuilder _messageBuilder, IMessageDTO _message, IOrderDAO _orderDAO)
        {
            MessageBuilder = _messageBuilder;
            Message = _message;
            OrderDAO = _orderDAO;
        }
        #endregion

        #region Public Methods
        public async Task GetAll()
        {
            try
            {
                IList lstResult = await OrderDAO.GetAll();
                MessageBuilder.BuildMessage(Resources.LanguageResources.ListAllItems,
                    Resources.LanguageResources.Success, ref Message, null, lstResult);
            }
            catch (Exception Ex)
            {

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                    Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task GetAll(int OrderId)
        {
            try
            {
                IList lstResult = await OrderDAO.GetAll(OrderId);
                MessageBuilder.BuildMessage(Resources.LanguageResources.ListAllItems,
                    Resources.LanguageResources.Success, ref Message, null, lstResult);


            }
            catch (Exception Ex)
            {

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                    Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task Create(OrdersDTO eOrder)
        {
            try
            {
                await OrderDAO.Create(eOrder);

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericCreationSuccess,
                      Resources.LanguageResources.Success, ref Message);
            }
            catch (Exception Ex)
            {
                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                    Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task Update(OrdersDTO eOrder)
        {
            try
            {
                await OrderDAO.Update(eOrder);

                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericUpdateSuccess,
                      Resources.LanguageResources.Success, ref Message);
            }
            catch (Exception Ex)
            {
                MessageBuilder.BuildMessage(Resources.LanguageResources.GenericErrorMessage,
                    Resources.LanguageResources.Error, ref Message, Ex);
            }
        }

        public async Task Delete(int OrderId)
        {
            try
            {
                await OrderDAO.Delete(OrderId);

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
