﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sfa.Eds.Das.Indexer.AzureWorkerRole.DedsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.imservices.org.uk/dcft/deds/1.0", ConfigurationName="DedsService.IDedsSearchService")]
    public interface IDedsSearchService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSet", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSetResponse")]
        Sfa.DedsService.DedsService.DataSetDescriptor GetDataSet(System.Guid dataSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSet", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSetResponse")]
        System.Threading.Tasks.Task<Sfa.DedsService.DedsService.DataSetDescriptor> GetDataSetAsync(System.Guid dataSetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSetByCode", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSetByCodeResp" +
            "onse")]
        Sfa.DedsService.DedsService.DataSetDescriptor GetDataSetByCode(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSetByCode", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetDataSetByCodeResp" +
            "onse")]
        System.Threading.Tasks.Task<Sfa.DedsService.DedsService.DataSetDescriptor> GetDataSetByCodeAsync(string code);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverDataSetVersi" +
            "ons", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverDataSetVersi" +
            "onsResponse")]
        Sfa.DedsService.DedsService.DataSetVersionDescriptor[] DiscoverDataSetVersions(Sfa.DedsService.DedsService.DiscoverDataSetVersionsCriteria discoverDataSetVersionsCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverDataSetVersi" +
            "ons", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverDataSetVersi" +
            "onsResponse")]
        System.Threading.Tasks.Task<Sfa.DedsService.DedsService.DataSetVersionDescriptor[]> DiscoverDataSetVersionsAsync(Sfa.DedsService.DedsService.DiscoverDataSetVersionsCriteria discoverDataSetVersionsCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverQueries", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverQueriesRespo" +
            "nse")]
        Sfa.DedsService.DedsService.QueryDescriptor[] DiscoverQueries(Sfa.DedsService.DedsService.DiscoverQueriesCriteria discoverQueriesCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverQueries", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverQueriesRespo" +
            "nse")]
        System.Threading.Tasks.Task<Sfa.DedsService.DedsService.QueryDescriptor[]> DiscoverQueriesAsync(Sfa.DedsService.DedsService.DiscoverQueriesCriteria discoverQueriesCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFiles", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFilesRespons" +
            "e")]
        Sfa.DedsService.DedsService.FileDescriptor[] DiscoverFiles(Sfa.DedsService.DedsService.DiscoverFilesCriteria discoverFilesCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFiles", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFilesRespons" +
            "e")]
        System.Threading.Tasks.Task<Sfa.DedsService.DedsService.FileDescriptor[]> DiscoverFilesAsync(Sfa.DedsService.DedsService.DiscoverFilesCriteria discoverFilesCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFilesCount", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFilesCountRe" +
            "sponse")]
        long DiscoverFilesCount(Sfa.DedsService.DedsService.DiscoverFilesCriteria discoverFilesCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFilesCount", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/DiscoverFilesCountRe" +
            "sponse")]
        System.Threading.Tasks.Task<long> DiscoverFilesCountAsync(Sfa.DedsService.DedsService.DiscoverFilesCriteria discoverFilesCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQuery", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQueryResponse" +
            "")]
        Sfa.DedsService.DedsService.QueryResults[] ExecuteQuery(System.Guid queryId, Sfa.DedsService.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQuery", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQueryResponse" +
            "")]
        System.Threading.Tasks.Task<Sfa.DedsService.DedsService.QueryResults[]> ExecuteQueryAsync(System.Guid queryId, Sfa.DedsService.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCount", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCountRespons" +
            "e")]
        long GetTotalCount(System.Guid queryId, Sfa.DedsService.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCount", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCountRespons" +
            "e")]
        System.Threading.Tasks.Task<long> GetTotalCountAsync(System.Guid queryId, Sfa.DedsService.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQueryByCode", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQueryByCodeRe" +
            "sponse")]
        Sfa.DedsService.DedsService.QueryResults[] ExecuteQueryByCode(System.Guid dataSetVersionId, string queryCode, Sfa.DedsService.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQueryByCode", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/ExecuteQueryByCodeRe" +
            "sponse")]
        System.Threading.Tasks.Task<Sfa.DedsService.DedsService.QueryResults[]> ExecuteQueryByCodeAsync(System.Guid dataSetVersionId, string queryCode, Sfa.DedsService.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCountByCode", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCountByCodeR" +
            "esponse")]
        long GetTotalCountByCode(System.Guid dataSetVersionId, string queryCode, Sfa.DedsService.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCountByCode", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetTotalCountByCodeR" +
            "esponse")]
        System.Threading.Tasks.Task<long> GetTotalCountByCodeAsync(System.Guid dataSetVersionId, string queryCode, Sfa.DedsService.DedsService.QueryExecution queryExecution);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetFile", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetFileResponse")]
        Sfa.DedsService.DedsService.FileData GetFile(System.Guid fileId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetFile", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetFileResponse")]
        System.Threading.Tasks.Task<Sfa.DedsService.DedsService.FileData> GetFileAsync(System.Guid fileId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetLatestPublishedDa" +
            "taSetVersion", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetLatestPublishedDa" +
            "taSetVersionResponse")]
        Sfa.DedsService.DedsService.DataSetVersionDescriptor GetLatestPublishedDataSetVersion(string dataSetCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetLatestPublishedDa" +
            "taSetVersion", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetLatestPublishedDa" +
            "taSetVersionResponse")]
        System.Threading.Tasks.Task<Sfa.DedsService.DedsService.DataSetVersionDescriptor> GetLatestPublishedDataSetVersionAsync(string dataSetCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetPublishedDataSetV" +
            "ersions", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetPublishedDataSetV" +
            "ersionsResponse")]
        Sfa.DedsService.DedsService.DataSetVersionDescriptor[] GetPublishedDataSetVersions(string dataSetCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetPublishedDataSetV" +
            "ersions", ReplyAction="http://ws.imservices.org.uk/dcft/deds/1.0/IDedsSearchService/GetPublishedDataSetV" +
            "ersionsResponse")]
        System.Threading.Tasks.Task<Sfa.DedsService.DedsService.DataSetVersionDescriptor[]> GetPublishedDataSetVersionsAsync(string dataSetCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDedsSearchServiceChannel : Sfa.Eds.Das.Indexer.AzureWorkerRole.DedsService.IDedsSearchService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DedsSearchServiceClient : System.ServiceModel.ClientBase<Sfa.Eds.Das.Indexer.AzureWorkerRole.DedsService.IDedsSearchService>, Sfa.Eds.Das.Indexer.AzureWorkerRole.DedsService.IDedsSearchService {
        
        public DedsSearchServiceClient() {
        }
        
        public DedsSearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DedsSearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DedsSearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DedsSearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Sfa.DedsService.DedsService.DataSetDescriptor GetDataSet(System.Guid dataSetId) {
            return base.Channel.GetDataSet(dataSetId);
        }
        
        public System.Threading.Tasks.Task<Sfa.DedsService.DedsService.DataSetDescriptor> GetDataSetAsync(System.Guid dataSetId) {
            return base.Channel.GetDataSetAsync(dataSetId);
        }
        
        public Sfa.DedsService.DedsService.DataSetDescriptor GetDataSetByCode(string code) {
            return base.Channel.GetDataSetByCode(code);
        }
        
        public System.Threading.Tasks.Task<Sfa.DedsService.DedsService.DataSetDescriptor> GetDataSetByCodeAsync(string code) {
            return base.Channel.GetDataSetByCodeAsync(code);
        }
        
        public Sfa.DedsService.DedsService.DataSetVersionDescriptor[] DiscoverDataSetVersions(Sfa.DedsService.DedsService.DiscoverDataSetVersionsCriteria discoverDataSetVersionsCriteria) {
            return base.Channel.DiscoverDataSetVersions(discoverDataSetVersionsCriteria);
        }
        
        public System.Threading.Tasks.Task<Sfa.DedsService.DedsService.DataSetVersionDescriptor[]> DiscoverDataSetVersionsAsync(Sfa.DedsService.DedsService.DiscoverDataSetVersionsCriteria discoverDataSetVersionsCriteria) {
            return base.Channel.DiscoverDataSetVersionsAsync(discoverDataSetVersionsCriteria);
        }
        
        public Sfa.DedsService.DedsService.QueryDescriptor[] DiscoverQueries(Sfa.DedsService.DedsService.DiscoverQueriesCriteria discoverQueriesCriteria) {
            return base.Channel.DiscoverQueries(discoverQueriesCriteria);
        }
        
        public System.Threading.Tasks.Task<Sfa.DedsService.DedsService.QueryDescriptor[]> DiscoverQueriesAsync(Sfa.DedsService.DedsService.DiscoverQueriesCriteria discoverQueriesCriteria) {
            return base.Channel.DiscoverQueriesAsync(discoverQueriesCriteria);
        }
        
        public Sfa.DedsService.DedsService.FileDescriptor[] DiscoverFiles(Sfa.DedsService.DedsService.DiscoverFilesCriteria discoverFilesCriteria) {
            return base.Channel.DiscoverFiles(discoverFilesCriteria);
        }
        
        public System.Threading.Tasks.Task<Sfa.DedsService.DedsService.FileDescriptor[]> DiscoverFilesAsync(Sfa.DedsService.DedsService.DiscoverFilesCriteria discoverFilesCriteria) {
            return base.Channel.DiscoverFilesAsync(discoverFilesCriteria);
        }
        
        public long DiscoverFilesCount(Sfa.DedsService.DedsService.DiscoverFilesCriteria discoverFilesCriteria) {
            return base.Channel.DiscoverFilesCount(discoverFilesCriteria);
        }
        
        public System.Threading.Tasks.Task<long> DiscoverFilesCountAsync(Sfa.DedsService.DedsService.DiscoverFilesCriteria discoverFilesCriteria) {
            return base.Channel.DiscoverFilesCountAsync(discoverFilesCriteria);
        }
        
        public Sfa.DedsService.DedsService.QueryResults[] ExecuteQuery(System.Guid queryId, Sfa.DedsService.DedsService.QueryExecution queryExecution) {
            return base.Channel.ExecuteQuery(queryId, queryExecution);
        }
        
        public System.Threading.Tasks.Task<Sfa.DedsService.DedsService.QueryResults[]> ExecuteQueryAsync(System.Guid queryId, Sfa.DedsService.DedsService.QueryExecution queryExecution) {
            return base.Channel.ExecuteQueryAsync(queryId, queryExecution);
        }
        
        public long GetTotalCount(System.Guid queryId, Sfa.DedsService.DedsService.QueryExecution queryExecution) {
            return base.Channel.GetTotalCount(queryId, queryExecution);
        }
        
        public System.Threading.Tasks.Task<long> GetTotalCountAsync(System.Guid queryId, Sfa.DedsService.DedsService.QueryExecution queryExecution) {
            return base.Channel.GetTotalCountAsync(queryId, queryExecution);
        }
        
        public Sfa.DedsService.DedsService.QueryResults[] ExecuteQueryByCode(System.Guid dataSetVersionId, string queryCode, Sfa.DedsService.DedsService.QueryExecution queryExecution) {
            return base.Channel.ExecuteQueryByCode(dataSetVersionId, queryCode, queryExecution);
        }
        
        public System.Threading.Tasks.Task<Sfa.DedsService.DedsService.QueryResults[]> ExecuteQueryByCodeAsync(System.Guid dataSetVersionId, string queryCode, Sfa.DedsService.DedsService.QueryExecution queryExecution) {
            return base.Channel.ExecuteQueryByCodeAsync(dataSetVersionId, queryCode, queryExecution);
        }
        
        public long GetTotalCountByCode(System.Guid dataSetVersionId, string queryCode, Sfa.DedsService.DedsService.QueryExecution queryExecution) {
            return base.Channel.GetTotalCountByCode(dataSetVersionId, queryCode, queryExecution);
        }
        
        public System.Threading.Tasks.Task<long> GetTotalCountByCodeAsync(System.Guid dataSetVersionId, string queryCode, Sfa.DedsService.DedsService.QueryExecution queryExecution) {
            return base.Channel.GetTotalCountByCodeAsync(dataSetVersionId, queryCode, queryExecution);
        }
        
        public Sfa.DedsService.DedsService.FileData GetFile(System.Guid fileId) {
            return base.Channel.GetFile(fileId);
        }
        
        public System.Threading.Tasks.Task<Sfa.DedsService.DedsService.FileData> GetFileAsync(System.Guid fileId) {
            return base.Channel.GetFileAsync(fileId);
        }
        
        public Sfa.DedsService.DedsService.DataSetVersionDescriptor GetLatestPublishedDataSetVersion(string dataSetCode) {
            return base.Channel.GetLatestPublishedDataSetVersion(dataSetCode);
        }
        
        public System.Threading.Tasks.Task<Sfa.DedsService.DedsService.DataSetVersionDescriptor> GetLatestPublishedDataSetVersionAsync(string dataSetCode) {
            return base.Channel.GetLatestPublishedDataSetVersionAsync(dataSetCode);
        }
        
        public Sfa.DedsService.DedsService.DataSetVersionDescriptor[] GetPublishedDataSetVersions(string dataSetCode) {
            return base.Channel.GetPublishedDataSetVersions(dataSetCode);
        }
        
        public System.Threading.Tasks.Task<Sfa.DedsService.DedsService.DataSetVersionDescriptor[]> GetPublishedDataSetVersionsAsync(string dataSetCode) {
            return base.Channel.GetPublishedDataSetVersionsAsync(dataSetCode);
        }
    }
}
