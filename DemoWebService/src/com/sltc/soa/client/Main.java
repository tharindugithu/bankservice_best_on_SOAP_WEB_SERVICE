package com.sltc.soa.client;
//INCLUDING DEPOSIT AND WITHDRAW
import com.sltc.soa.client.stub.BankService;
import com.sltc.soa.client.stub.BankServiceSoap;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {
        double amount;
        double current_amount;
        double withdraw_amount;
        double deposit_amount;

        BankService bankService = new BankService();//create bank service object
        BankServiceSoap bankServiceSoap = bankService.getBankServiceSoap();//access the bank service through the BankServiceSoap interface
        Main m = new Main();//create object of client class

        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter Your Choice");//get user choice
        System.out.println("press 1 for deposit money");
        System.out.println("press 2 for withdraw money");

        int choice = scanner.nextInt();//assign value in choice variable

        switch (choice){
            case 1:
                System.out.println("Enter Your Bank Amount :");//get user account balance
                amount = scanner.nextDouble();//assign value amount variable

                System.out.println("Enter Your Deposit Amount :");//get user deposit amount
                deposit_amount = scanner.nextDouble();//assign to variable
                m.deposit_money(amount,deposit_amount);//call deposit method
                break;
            case 2:
                System.out.println("Enter Your Bank Amount :");//get user account balance
                amount = scanner.nextDouble();//assign value amount variable

                System.out.println("Enter Your Withdraw Amount :");//get user withdraw amount
                withdraw_amount= scanner.nextDouble();//assign to variable
                m.withdraw_money(amount,withdraw_amount);//call the withdraw method
                break;
            default:
                System.out.println("Something went wrong!!!!");//if user enter invalid input then show this msg

        }
    }

    public void deposit_money(double amount,double d_amount){// deposit method
        double current_amount;
        BankService bankService = new BankService();
        BankServiceSoap bankServiceSoap = bankService.getBankServiceSoap();
        current_amount = bankServiceSoap.depositMoney(amount,d_amount);//call the deposit web method
        System.out.println("Your Current amount is "+current_amount);
    }

    public void withdraw_money(double amount,double w_amount){//withdraw method
        double current_amount;
        BankService bankService = new BankService();
        BankServiceSoap bankServiceSoap = bankService.getBankServiceSoap();
        current_amount = bankServiceSoap.withdrawMoney(amount,w_amount);//call the withdraw web method
        System.out.println("Your Current amount is "+current_amount);
    }

}
