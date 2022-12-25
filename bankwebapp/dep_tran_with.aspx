<%@ Page Title="Bank Work For Client" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="dep_tran_with.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4 style="height: 859px; width: 1807px">
        <br />
      <asp:Label style="color:red" ID="MainErrors" runat="server" Text=""></asp:Label> 
      <asp:Label style="color:forestgreen" ID="Succsess" runat="server" Text=""></asp:Label>
        <br />
         <table class="nav-justified">
         <tr>
             <td>Your Name <asp:Label ID="Label3" runat="server" Text="_ _ _ _ _ _ _ _ _ "></asp:Label> </td>
             <td> &nbsp;</td>
         </tr>    
         </table>
        <br />
        <br />
        <table class="nav-justified">
        <tr>
            <td style="width: 315px">Your account number</td>
            <td>
                <asp:Label ID="Name" runat="server" ></asp:Label>
            </td>
        </tr>
       
        <tr>
            <td style="width: 315px">Your amount</td>  
            <td>
                <asp:Label ID="Balance" runat="server" Width="219px" style="margin-left: 0"></asp:Label>
            </td>
        </tr>
       </table>
       <br />
       <hr />
        Transfer Money 

        <table class="nav-justified">
    
        <br />
        <tr>
            <td style="width: 315px">Transfer account number</td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server" Width="219px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td style="width: 315px">Entert Transfer amount</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server" Width="219px"></asp:TextBox>
             </td>
        </tr>
      
            <br />
        </table>
         <asp:Button ID="Button4" runat="server" Height="41px" Text="Transfer" Width="145px" OnClick="Button4_Click" />
         <br />
        <asp:Label style="color:red" ID="Error1" runat="server" Text=""></asp:Label> 
       
        <br />
       <br />
        <br />
          <hr />
        Deposit
        
        <br />
        <br />
       
        <table class="nav-justified">
         <tr>
            <td style="width: 315px">Entert Deposit amount</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="219px"></asp:TextBox>
             </td>
        </tr>
        </table>
        
        <asp:Button ID="Button1" runat="server" Height="41px" Text="Deposit" Width="125px" OnClick="Button1_Click" />
        
        
        <br />
        <br />
        <hr />
        Withdraw

        <br />

        <table class="nav-justified">
         <tr>
            <td style="width: 315px">Entert Withdraw amount</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Width="219px"></asp:TextBox>
             </td>
        </tr>
            <br />
        </table>

        <asp:Button ID="Button3" runat="server" Height="41px" Text="Withdraw" Width="145px" OnClick="Button3_Click" />
       
        <br />
        <br />
        
        <tr>
            <td>Upadate amount</td>:
            <td>
            </td>
        </tr>
           <asp:Label ID="Amount" runat="server" Text="_ _ _ _ _ _ _ _ _ "></asp:Label>
        
    </h4>
    
</asp:Content>
