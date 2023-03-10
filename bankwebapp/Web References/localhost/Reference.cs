//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebApplication1.localhost {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="bank_serviceSoap", Namespace="http://tempuri.org/")]
    public partial class bank_service : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DepositMoneyOperationCompleted;
        
        private System.Threading.SendOrPostCallback WithdrawMoneyOperationCompleted;
        
        private System.Threading.SendOrPostCallback TransferMoneyOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public bank_service() {
            this.Url = global::WebApplication1.Properties.Settings.Default.WebApplication1_localhost_bank_service;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event DepositMoneyCompletedEventHandler DepositMoneyCompleted;
        
        /// <remarks/>
        public event WithdrawMoneyCompletedEventHandler WithdrawMoneyCompleted;
        
        /// <remarks/>
        public event TransferMoneyCompletedEventHandler TransferMoneyCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DepositMoney", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double DepositMoney(double accout_balance, double deposit_money) {
            object[] results = this.Invoke("DepositMoney", new object[] {
                        accout_balance,
                        deposit_money});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void DepositMoneyAsync(double accout_balance, double deposit_money) {
            this.DepositMoneyAsync(accout_balance, deposit_money, null);
        }
        
        /// <remarks/>
        public void DepositMoneyAsync(double accout_balance, double deposit_money, object userState) {
            if ((this.DepositMoneyOperationCompleted == null)) {
                this.DepositMoneyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDepositMoneyOperationCompleted);
            }
            this.InvokeAsync("DepositMoney", new object[] {
                        accout_balance,
                        deposit_money}, this.DepositMoneyOperationCompleted, userState);
        }
        
        private void OnDepositMoneyOperationCompleted(object arg) {
            if ((this.DepositMoneyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DepositMoneyCompleted(this, new DepositMoneyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WithdrawMoney", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double WithdrawMoney(double accout_balance, double withdraw_money) {
            object[] results = this.Invoke("WithdrawMoney", new object[] {
                        accout_balance,
                        withdraw_money});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void WithdrawMoneyAsync(double accout_balance, double withdraw_money) {
            this.WithdrawMoneyAsync(accout_balance, withdraw_money, null);
        }
        
        /// <remarks/>
        public void WithdrawMoneyAsync(double accout_balance, double withdraw_money, object userState) {
            if ((this.WithdrawMoneyOperationCompleted == null)) {
                this.WithdrawMoneyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWithdrawMoneyOperationCompleted);
            }
            this.InvokeAsync("WithdrawMoney", new object[] {
                        accout_balance,
                        withdraw_money}, this.WithdrawMoneyOperationCompleted, userState);
        }
        
        private void OnWithdrawMoneyOperationCompleted(object arg) {
            if ((this.WithdrawMoneyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WithdrawMoneyCompleted(this, new WithdrawMoneyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/TransferMoney", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double TransferMoney(double accout_balance, double transfer_money) {
            object[] results = this.Invoke("TransferMoney", new object[] {
                        accout_balance,
                        transfer_money});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void TransferMoneyAsync(double accout_balance, double transfer_money) {
            this.TransferMoneyAsync(accout_balance, transfer_money, null);
        }
        
        /// <remarks/>
        public void TransferMoneyAsync(double accout_balance, double transfer_money, object userState) {
            if ((this.TransferMoneyOperationCompleted == null)) {
                this.TransferMoneyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTransferMoneyOperationCompleted);
            }
            this.InvokeAsync("TransferMoney", new object[] {
                        accout_balance,
                        transfer_money}, this.TransferMoneyOperationCompleted, userState);
        }
        
        private void OnTransferMoneyOperationCompleted(object arg) {
            if ((this.TransferMoneyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TransferMoneyCompleted(this, new TransferMoneyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    public delegate void DepositMoneyCompletedEventHandler(object sender, DepositMoneyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DepositMoneyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DepositMoneyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    public delegate void WithdrawMoneyCompletedEventHandler(object sender, WithdrawMoneyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WithdrawMoneyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WithdrawMoneyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    public delegate void TransferMoneyCompletedEventHandler(object sender, TransferMoneyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4161.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TransferMoneyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TransferMoneyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591