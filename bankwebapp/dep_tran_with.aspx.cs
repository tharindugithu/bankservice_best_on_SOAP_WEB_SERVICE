using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BankAccount b = new BankAccount();
            try
            {
                String amount = b.ReadLogRecord();//read the current user log file and get his current amount
                String[] fields = b.ReadUserDetailRecord();//read the user deatails file and get the first user [we assume first user is current user and 2nd user is another user
                Label3.Text = fields[0];//username
                Balance.Text = amount;//amount of this user
                Name.Text = fields[1];//account number
                MainErrors.Text = "";//remove error msges

            }
            catch (Exception ex)
            {
                MainErrors.Text = ex.Message;//handle error
                Succsess.Text = "";
            }


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            BankAccount b = new BankAccount();//create reference user's bank account
            String[] fields = b.ReadUserDetailRecord();//get current user username

            localhost.bank_service wsBank = new localhost.bank_service();//setting up refference use bank_service
            try
            {
                double amount = Convert.ToDouble(Balance.Text);//get the Textbox value and convert to double
                double disposit_amount = Convert.ToDouble(TextBox2.Text);//get the user entered value and convert to double
                TextBox2.Text = String.Empty;//clear the text filed
                Amount.Text = wsBank.DepositMoney(amount, disposit_amount).ToString();//pass the value web method and response conver to string and assign to Amount text filed 

                b.AddRecord(disposit_amount, fields[0], "Deposit");//add record in user log file
                b.AddRecord(wsBank.DepositMoney(amount, disposit_amount), fields[0], "CurrentAmount");//add record in user log file

                Balance.Text = Amount.Text;
                MainErrors.Text = "";
                Succsess.Text = "Successfully Deposited";//show the msg
            }
            catch (Exception ex)
            {
                MainErrors.Text = ex.Message;//handle errors
                Succsess.Text = "";//clear successtext because we need to only show error
            }

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            BankAccount b = new BankAccount();//create reference user's bank account
            String[] fields = b.ReadUserDetailRecord();//get current user username
            try
            {
                double amount = 0.0;

                localhost.bank_service wsBank = new localhost.bank_service();

                amount = Convert.ToDouble(Balance.Text);//get the Textbox value and convert to double
                double withdraw_amount = Convert.ToDouble(TextBox5.Text);//get the user entered value and convert to double

                TextBox5.Text = String.Empty;//clear the text filed

                Amount.Text = wsBank.WithdrawMoney(amount, withdraw_amount).ToString();//pass the value web method and response conver to string and assign to Amount text filed 

                b.AddRecord(withdraw_amount, fields[0], "Withdraw");//add record in user log file
                b.AddRecord(wsBank.WithdrawMoney(amount, withdraw_amount), fields[0], "CurrentAmount");//add record in user log file

                Balance.Text = Amount.Text;
                MainErrors.Text = "";
                Succsess.Text = "Successfully Withdrawed";//show the msg
            }
            catch (Exception ex)
            {
                MainErrors.Text = ex.Message;//handle errors
                Succsess.Text = "";//clear successtext because we need to only show error
            }

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            BankAccount b = new BankAccount();//create reference user's bank account
            String[] fields = b.ReadUserDetailRecord();//get current user username

            double amount = Convert.ToDouble(Balance.Text);//get the current user account balance
            double transfer_amount = Convert.ToDouble(TextBox6.Text);//get the user entered transfer amount and conver to double
            String transfer_account = TextBox8.Text;//get the transfer account number [2nd user of userdetail txt]

            TextBox6.Text = String.Empty;//clear the text box
            TextBox8.Text = String.Empty;//clear the text box

            Amount.Text = Convert.ToString(b.MoneyTransfer(transfer_account, transfer_amount));//call the client method to transfer the money other user and the money transfer return double value
            //conver to string if any error return 1 otherwise return current user upadeted balance after moeny transfer
            if (Amount.Text == "1")//check the transfer account exist or not [1 = account not found]
            {
                Error1.Text = "Enter valid Account Number";//show the error in user interface
                Succsess.Text = "";//clear other messages
                Amount.Text = Convert.ToString(amount);
            }
            else
            {
                b.AddRecord(transfer_amount, fields[0], "Transfer");//if transfer account exist then add record in current user's log file 
                b.AddRecord(Convert.ToDouble(Amount.Text), fields[0], "CurrentAmount");//if transfer account exist then add record in current user's log file 
                Balance.Text = Amount.Text;
                Error1.Text = "";
                Succsess.Text = "Successfully Transfered";
            }

        }
    }
    class BankAccount
    {

        //client bank account 
        public void AddRecord(double amount, String name, String typeOfWork)//first user
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("C://bank_webappinfo//log.txt", true))//path of log file
            {
                file.WriteLine(amount + "," + name + "," + typeOfWork);//write the file using this format
            }
        }
        public void AddRecord2(double amount, String name, String typeOfWork)//2nd user 
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("C://bank_webappinfo//log2.txt", true))//path of log file
            {
                file.WriteLine(amount + "," + name + "," + typeOfWork);

            }
        }
        public String[] ReadUserDetailRecord()
        {
            String[] lines = System.IO.File.ReadAllLines("C://bank_webappinfo//userDetails.txt");
            String[] fields = lines[0].Split(',');
            return fields;
        }

        public String ReadLogRecord()// for this user
        {
            String[] lines = System.IO.File.ReadAllLines("C://bank_webappinfo//log.txt");
            int len = lines.Length;
            String[] fields = lines[len - 1].Split(',');
            return fields[0];//return user current balance
        }

        public String ReadLogRecord2()// this method for another one user because i am not using database for this
        {
            String[] lines = System.IO.File.ReadAllLines("C://bank_webappinfo//log2.txt");
            int len = lines.Length;
            String[] fields = lines[len - 1].Split(',');
            return fields[0];//return user current balance
        }

        public double MoneyTransfer(String trasfer_account_number, double tranfer_amount)
        {


            Boolean check = false;//for flag
            BankAccount b = new BankAccount();//first user
            BankAccount b2 = new BankAccount();//2nd user
            double user_current_amount = Convert.ToDouble(b.ReadLogRecord());//get user current amount
            localhost.bank_service wsBank = new localhost.bank_service();


            //checking usersDetailslist if there match acc number with trasfer acc number

            String[] lines = System.IO.File.ReadAllLines("C://bank_webappinfo//userDetails.txt");//get all line of userDetails.txt, there are 2 users in this file



            for (int i = 0; i < lines.Length; i++)//check line by line
            {
                String[] fields = lines[i].Split(',');//get one line and split data 
                if (trasfer_account_number == fields[1])//check the transfer account is exisit or not
                {
                    user_current_amount = wsBank.WithdrawMoney(user_current_amount, tranfer_amount);//if 2nd user exist then withdraw money from this user 
                    double amount = Convert.ToDouble(b2.ReadLogRecord2());//this will return relavant user current balance ,but i am not use database therefore only one user log file is exist, therefore i create 2nd log.txt for that user
                    amount = wsBank.DepositMoney(amount, tranfer_amount);//deposit that transfer ammount 2nd user

                    b2.AddRecord2(tranfer_amount, fields[0], "Trasfer");//add record 2nd user log file log2.txt his trasfer amount
                    b2.AddRecord2(amount, fields[0], "CurrentAmount");//add record 2nd user log file log2.txt his current amount
                    check = true;
                }

            }
            if (check == false)
            {
                return 1;
                // 1 ->account not fount
            }

            return user_current_amount;
        }


    }

}