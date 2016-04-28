using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace pizzashop
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //[OperationContract]
        //void DoWork();

        [WebGet(UriTemplate = "/Create?FoodName={FoodN}&Price={FoodPrice}&Quantity={FoodQ}",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        string CreateFood(string FoodN, string FoodPrice, string FoodQ, string email);

        //[WebGet(UriTemplate = "/Update?FoodName={FoodN}&Price={FoodPrice}&Quantity={FoodQ}",
        //    ResponseFormat =WebMessageFormat.Json)]
        //[OperationContract]
        //string UpdateFood(string FoodN, string FoodPrice, string FoodQ);

        //[WebGet(UriTemplate = "/Read?FoodName={FoodN}&Price={FoodPrice}&Quantity={FoodQ}",
        //    ResponseFormat =WebMessageFormat.Json)]
        //[OperationContract]
        //string ReadFood(string FoodN, string FoodPrice, string FoodQ);

        //[WebGet(UriTemplate = "/Delete?FoodName={FoodN}&Price={FoodPrice}&Quantity={FoodQ}",
        //    ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //string DeleteFood(string FoodN, string FoodPrice, string FoodQ);



        //[WebGet(UriTemplate = "/Create?CusFirstName={CusFN}&CusLastName={CusLN}&CusPhoneNum={CusPN}&CusAddress={CusAdd}&CusOrder={CusO}",
        //    ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //string CreateCustomer(string CusFN, string CusLN, string CusPN, string CusAdd, string CusO);

        //[WebGet(UriTemplate = "/Read?CusFirstName={CusFN}&CusLastName={CusLN}&CusPhoneNum={CusPN}&CusAddress={CusAdd}&CusOrder={CusO}",
        //    ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //string ReadCustomer(string CusFN, string CusLN, string CusPN, string CusAdd, string CusO);

        //[WebGet(UriTemplate = "/Update?CusFirstName={CusFN}&CusLastName={CusLN}&CusPhoneNum={CusPN}&CusAddress={CusAdd}&CusOrder={CusO}",
        //    ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //string UpdateCustomer(string CusFN, string CusLN, string CusPN, string CusAdd, string CusO);

        //[WebGet(UriTemplate = "/Delete?CusFirstName={CusFN}&CusLastName={CusLN}&CusPhoneNum={CusPN}&CusAddress={CusAdd}&CusOrder={CusO}",
        //    ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //string DeleteCustomer(string CusFN, string CusLN, string CusPN, string CusAdd, string CusO);


        //[WebGet(UriTemplate = "/Create?ID={WID}&FirstName={WFN}&LastName={WLN}&Address={WADD}&PhoneNum={WNUM}&UserName={WUSER}&PassWord{WPW}",
        //    ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //string CreateWorker(string WFN, string WLN, string WADD, string WNUM, string WUSER, string WPW);

        //[WebGet(UriTemplate = "/Read?ID={WID}&FirstName={WFN}&LastName={WLN}&Address={WADD}&PhoneNum={WNUM}&UserName={WUSER}&PassWord{WPW}",
        //    ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //string ReadWorker(string WFN, string WLN, string WADD, string WNUM, string WUSER, string WPW);

        //[WebGet(UriTemplate = "/Update?ID={WID}&FirstName={WFN}&LastName={WLN}&Address={WADD}&PhoneNum={WNUM}&UserName={WUSER}&PassWord{WPW}",
        //    ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //string UpdateWorker(string WFN, string WLN, string WADD, string WNUM, string WUSER, string WPW);

        //[WebGet(UriTemplate = "/Delete?ID={WID}&FirstName={WFN}&LastName={WLN}&Address={WADD}&PhoneNum={WNUM}&UserName={WUSER}&PassWord{WPW}",
        //    ResponseFormat = WebMessageFormat.Json)]
        //[OperationContract]
        //string DeleteWorker(string WFN, string WLN, string WADD, string WNUM, string WUSER, string WPW);




    }
}
