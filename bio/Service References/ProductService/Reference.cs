﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace bio.ProductService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://tempuri.org/")]
    public partial class Product : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string IdField;
        
        private string EnglishNameField;
        
        private string ChineseNameField;
        
        private string PriceField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string EnglishName {
            get {
                return this.EnglishNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EnglishNameField, value) != true)) {
                    this.EnglishNameField = value;
                    this.RaisePropertyChanged("EnglishName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ChineseName {
            get {
                return this.ChineseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ChineseNameField, value) != true)) {
                    this.ChineseNameField = value;
                    this.RaisePropertyChanged("ChineseName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Price {
            get {
                return this.PriceField;
            }
            set {
                if ((object.ReferenceEquals(this.PriceField, value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductService.ProductServiceSoap")]
    public interface ProductServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/GetAllProducts", ReplyAction="*")]
        System.IAsyncResult BeginGetAllProducts(bio.ProductService.GetAllProductsRequest request, System.AsyncCallback callback, object asyncState);
        
        bio.ProductService.GetAllProductsResponse EndGetAllProducts(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/GetProductsByPage", ReplyAction="*")]
        System.IAsyncResult BeginGetProductsByPage(bio.ProductService.GetProductsByPageRequest request, System.AsyncCallback callback, object asyncState);
        
        bio.ProductService.GetProductsByPageResponse EndGetProductsByPage(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/GetProductsCount", ReplyAction="*")]
        System.IAsyncResult BeginGetProductsCount(System.AsyncCallback callback, object asyncState);
        
        int EndGetProductsCount(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllProductsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllProducts", Namespace="http://tempuri.org/", Order=0)]
        public bio.ProductService.GetAllProductsRequestBody Body;
        
        public GetAllProductsRequest() {
        }
        
        public GetAllProductsRequest(bio.ProductService.GetAllProductsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllProductsRequestBody {
        
        public GetAllProductsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllProductsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllProductsResponse", Namespace="http://tempuri.org/", Order=0)]
        public bio.ProductService.GetAllProductsResponseBody Body;
        
        public GetAllProductsResponse() {
        }
        
        public GetAllProductsResponse(bio.ProductService.GetAllProductsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllProductsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Collections.ObjectModel.ObservableCollection<bio.ProductService.Product> GetAllProductsResult;
        
        public GetAllProductsResponseBody() {
        }
        
        public GetAllProductsResponseBody(System.Collections.ObjectModel.ObservableCollection<bio.ProductService.Product> GetAllProductsResult) {
            this.GetAllProductsResult = GetAllProductsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductsByPageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductsByPage", Namespace="http://tempuri.org/", Order=0)]
        public bio.ProductService.GetProductsByPageRequestBody Body;
        
        public GetProductsByPageRequest() {
        }
        
        public GetProductsByPageRequest(bio.ProductService.GetProductsByPageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductsByPageRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int pageIndex;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int pageSize;
        
        public GetProductsByPageRequestBody() {
        }
        
        public GetProductsByPageRequestBody(int pageIndex, int pageSize) {
            this.pageIndex = pageIndex;
            this.pageSize = pageSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductsByPageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductsByPageResponse", Namespace="http://tempuri.org/", Order=0)]
        public bio.ProductService.GetProductsByPageResponseBody Body;
        
        public GetProductsByPageResponse() {
        }
        
        public GetProductsByPageResponse(bio.ProductService.GetProductsByPageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetProductsByPageResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Collections.ObjectModel.ObservableCollection<bio.ProductService.Product> GetProductsByPageResult;
        
        public GetProductsByPageResponseBody() {
        }
        
        public GetProductsByPageResponseBody(System.Collections.ObjectModel.ObservableCollection<bio.ProductService.Product> GetProductsByPageResult) {
            this.GetProductsByPageResult = GetProductsByPageResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProductServiceSoapChannel : bio.ProductService.ProductServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllProductsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllProductsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<bio.ProductService.Product> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<bio.ProductService.Product>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetProductsByPageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetProductsByPageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<bio.ProductService.Product> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<bio.ProductService.Product>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetProductsCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetProductsCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceSoapClient : System.ServiceModel.ClientBase<bio.ProductService.ProductServiceSoap>, bio.ProductService.ProductServiceSoap {
        
        private BeginOperationDelegate onBeginGetAllProductsDelegate;
        
        private EndOperationDelegate onEndGetAllProductsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllProductsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetProductsByPageDelegate;
        
        private EndOperationDelegate onEndGetProductsByPageDelegate;
        
        private System.Threading.SendOrPostCallback onGetProductsByPageCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetProductsCountDelegate;
        
        private EndOperationDelegate onEndGetProductsCountDelegate;
        
        private System.Threading.SendOrPostCallback onGetProductsCountCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ProductServiceSoapClient() {
        }
        
        public ProductServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetAllProductsCompletedEventArgs> GetAllProductsCompleted;
        
        public event System.EventHandler<GetProductsByPageCompletedEventArgs> GetProductsByPageCompleted;
        
        public event System.EventHandler<GetProductsCountCompletedEventArgs> GetProductsCountCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult bio.ProductService.ProductServiceSoap.BeginGetAllProducts(bio.ProductService.GetAllProductsRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllProducts(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginGetAllProducts(System.AsyncCallback callback, object asyncState) {
            bio.ProductService.GetAllProductsRequest inValue = new bio.ProductService.GetAllProductsRequest();
            inValue.Body = new bio.ProductService.GetAllProductsRequestBody();
            return ((bio.ProductService.ProductServiceSoap)(this)).BeginGetAllProducts(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bio.ProductService.GetAllProductsResponse bio.ProductService.ProductServiceSoap.EndGetAllProducts(System.IAsyncResult result) {
            return base.Channel.EndGetAllProducts(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.Collections.ObjectModel.ObservableCollection<bio.ProductService.Product> EndGetAllProducts(System.IAsyncResult result) {
            bio.ProductService.GetAllProductsResponse retVal = ((bio.ProductService.ProductServiceSoap)(this)).EndGetAllProducts(result);
            return retVal.Body.GetAllProductsResult;
        }
        
        private System.IAsyncResult OnBeginGetAllProducts(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAllProducts(callback, asyncState);
        }
        
        private object[] OnEndGetAllProducts(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<bio.ProductService.Product> retVal = this.EndGetAllProducts(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllProductsCompleted(object state) {
            if ((this.GetAllProductsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllProductsCompleted(this, new GetAllProductsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllProductsAsync() {
            this.GetAllProductsAsync(null);
        }
        
        public void GetAllProductsAsync(object userState) {
            if ((this.onBeginGetAllProductsDelegate == null)) {
                this.onBeginGetAllProductsDelegate = new BeginOperationDelegate(this.OnBeginGetAllProducts);
            }
            if ((this.onEndGetAllProductsDelegate == null)) {
                this.onEndGetAllProductsDelegate = new EndOperationDelegate(this.OnEndGetAllProducts);
            }
            if ((this.onGetAllProductsCompletedDelegate == null)) {
                this.onGetAllProductsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllProductsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllProductsDelegate, null, this.onEndGetAllProductsDelegate, this.onGetAllProductsCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult bio.ProductService.ProductServiceSoap.BeginGetProductsByPage(bio.ProductService.GetProductsByPageRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetProductsByPage(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginGetProductsByPage(int pageIndex, int pageSize, System.AsyncCallback callback, object asyncState) {
            bio.ProductService.GetProductsByPageRequest inValue = new bio.ProductService.GetProductsByPageRequest();
            inValue.Body = new bio.ProductService.GetProductsByPageRequestBody();
            inValue.Body.pageIndex = pageIndex;
            inValue.Body.pageSize = pageSize;
            return ((bio.ProductService.ProductServiceSoap)(this)).BeginGetProductsByPage(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bio.ProductService.GetProductsByPageResponse bio.ProductService.ProductServiceSoap.EndGetProductsByPage(System.IAsyncResult result) {
            return base.Channel.EndGetProductsByPage(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.Collections.ObjectModel.ObservableCollection<bio.ProductService.Product> EndGetProductsByPage(System.IAsyncResult result) {
            bio.ProductService.GetProductsByPageResponse retVal = ((bio.ProductService.ProductServiceSoap)(this)).EndGetProductsByPage(result);
            return retVal.Body.GetProductsByPageResult;
        }
        
        private System.IAsyncResult OnBeginGetProductsByPage(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int pageIndex = ((int)(inValues[0]));
            int pageSize = ((int)(inValues[1]));
            return this.BeginGetProductsByPage(pageIndex, pageSize, callback, asyncState);
        }
        
        private object[] OnEndGetProductsByPage(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<bio.ProductService.Product> retVal = this.EndGetProductsByPage(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetProductsByPageCompleted(object state) {
            if ((this.GetProductsByPageCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetProductsByPageCompleted(this, new GetProductsByPageCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetProductsByPageAsync(int pageIndex, int pageSize) {
            this.GetProductsByPageAsync(pageIndex, pageSize, null);
        }
        
        public void GetProductsByPageAsync(int pageIndex, int pageSize, object userState) {
            if ((this.onBeginGetProductsByPageDelegate == null)) {
                this.onBeginGetProductsByPageDelegate = new BeginOperationDelegate(this.OnBeginGetProductsByPage);
            }
            if ((this.onEndGetProductsByPageDelegate == null)) {
                this.onEndGetProductsByPageDelegate = new EndOperationDelegate(this.OnEndGetProductsByPage);
            }
            if ((this.onGetProductsByPageCompletedDelegate == null)) {
                this.onGetProductsByPageCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetProductsByPageCompleted);
            }
            base.InvokeAsync(this.onBeginGetProductsByPageDelegate, new object[] {
                        pageIndex,
                        pageSize}, this.onEndGetProductsByPageDelegate, this.onGetProductsByPageCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult bio.ProductService.ProductServiceSoap.BeginGetProductsCount(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetProductsCount(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        int bio.ProductService.ProductServiceSoap.EndGetProductsCount(System.IAsyncResult result) {
            return base.Channel.EndGetProductsCount(result);
        }
        
        private System.IAsyncResult OnBeginGetProductsCount(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((bio.ProductService.ProductServiceSoap)(this)).BeginGetProductsCount(callback, asyncState);
        }
        
        private object[] OnEndGetProductsCount(System.IAsyncResult result) {
            int retVal = ((bio.ProductService.ProductServiceSoap)(this)).EndGetProductsCount(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetProductsCountCompleted(object state) {
            if ((this.GetProductsCountCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetProductsCountCompleted(this, new GetProductsCountCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetProductsCountAsync() {
            this.GetProductsCountAsync(null);
        }
        
        public void GetProductsCountAsync(object userState) {
            if ((this.onBeginGetProductsCountDelegate == null)) {
                this.onBeginGetProductsCountDelegate = new BeginOperationDelegate(this.OnBeginGetProductsCount);
            }
            if ((this.onEndGetProductsCountDelegate == null)) {
                this.onEndGetProductsCountDelegate = new EndOperationDelegate(this.OnEndGetProductsCount);
            }
            if ((this.onGetProductsCountCompletedDelegate == null)) {
                this.onGetProductsCountCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetProductsCountCompleted);
            }
            base.InvokeAsync(this.onBeginGetProductsCountDelegate, null, this.onEndGetProductsCountDelegate, this.onGetProductsCountCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override bio.ProductService.ProductServiceSoap CreateChannel() {
            return new ProductServiceSoapClientChannel(this);
        }
        
        private class ProductServiceSoapClientChannel : ChannelBase<bio.ProductService.ProductServiceSoap>, bio.ProductService.ProductServiceSoap {
            
            public ProductServiceSoapClientChannel(System.ServiceModel.ClientBase<bio.ProductService.ProductServiceSoap> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetAllProducts(bio.ProductService.GetAllProductsRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("GetAllProducts", _args, callback, asyncState);
                return _result;
            }
            
            public bio.ProductService.GetAllProductsResponse EndGetAllProducts(System.IAsyncResult result) {
                object[] _args = new object[0];
                bio.ProductService.GetAllProductsResponse _result = ((bio.ProductService.GetAllProductsResponse)(base.EndInvoke("GetAllProducts", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetProductsByPage(bio.ProductService.GetProductsByPageRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("GetProductsByPage", _args, callback, asyncState);
                return _result;
            }
            
            public bio.ProductService.GetProductsByPageResponse EndGetProductsByPage(System.IAsyncResult result) {
                object[] _args = new object[0];
                bio.ProductService.GetProductsByPageResponse _result = ((bio.ProductService.GetProductsByPageResponse)(base.EndInvoke("GetProductsByPage", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetProductsCount(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetProductsCount", _args, callback, asyncState);
                return _result;
            }
            
            public int EndGetProductsCount(System.IAsyncResult result) {
                object[] _args = new object[0];
                int _result = ((int)(base.EndInvoke("GetProductsCount", _args, result)));
                return _result;
            }
        }
    }
}
