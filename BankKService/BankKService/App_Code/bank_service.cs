using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for bank_service
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class bank_service : System.Web.Services.WebService
{
    
    public bank_service()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }


    [WebMethod]
    public double DepositMoney(double accout_balance,double deposit_money)
    {
        //Console.WriteLine("return value is :" + (accout_balance + deposit_money));
        return accout_balance + deposit_money; 
    }

    [WebMethod]
    public double WithdrawMoney(double accout_balance, double withdraw_money)
    {
        //Console.WriteLine("return value is :" + (accout_balance - withdraw_money));
        return accout_balance - withdraw_money;
    }

    [WebMethod]
    public double TransferMoney(double accout_balance, double transfer_money)
    {
       // Console.WriteLine("return value is :"+(accout_balance - transfer_money));
        return accout_balance - transfer_money;
    }


}

