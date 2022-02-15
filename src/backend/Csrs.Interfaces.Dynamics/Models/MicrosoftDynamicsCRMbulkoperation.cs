// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Csrs.Interfaces.Dynamics.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.bulkoperation
    /// </summary>
    public partial class MicrosoftDynamicsCRMbulkoperation : MicrosoftDynamicsCRMactivitypointer
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMbulkoperation
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMbulkoperation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMbulkoperation
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMbulkoperation(System.DateTimeOffset? lastonholdtime = default(System.DateTimeOffset?), string _owningteamValue = default(string), string exchangeitemid = default(string), bool? ismapiprivate = default(bool?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string seriesid = default(string), string _regardingobjectidValue = default(string), System.DateTimeOffset? deliverylastattemptedon = default(System.DateTimeOffset?), bool? isbilled = default(bool?), bool? isworkflowcreated = default(bool?), string _sendermailboxidValue = default(string), System.DateTimeOffset? scheduledend = default(System.DateTimeOffset?), string description = default(string), int? onholdtime = default(int?), string _modifiedbyValue = default(string), int? community = default(int?), System.DateTimeOffset? sortdate = default(System.DateTimeOffset?), int? instancetypecode = default(int?), int? timezoneruleversionnumber = default(int?), string _createdonbehalfbyValue = default(string), string _createdbyValue = default(string), string _transactioncurrencyidValue = default(string), string versionnumber = default(string), string processid = default(string), int? prioritycode = default(int?), string _serviceidValue = default(string), string _slaidValue = default(string), string stageid = default(string), System.DateTimeOffset? actualstart = default(System.DateTimeOffset?), string _owningbusinessunitValue = default(string), string _owninguserValue = default(string), int? utcconversiontimezonecode = default(int?), string exchangeweblink = default(string), int? scheduleddurationminutes = default(int?), System.DateTimeOffset? senton = default(System.DateTimeOffset?), System.DateTimeOffset? scheduledstart = default(System.DateTimeOffset?), string _slainvokedidValue = default(string), int? statecode = default(int?), string subject = default(string), System.DateTimeOffset? postponeactivityprocessinguntil = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), decimal? exchangerate = default(decimal?), bool? isregularactivity = default(bool?), int? deliveryprioritycode = default(int?), int? actualdurationminutes = default(int?), string traversedpath = default(string), string activityid = default(string), string activitytypecode = default(string), string activityadditionalparams = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owneridValue = default(string), bool? leftvoicemail = default(bool?), int? statuscode = default(int?), System.DateTimeOffset? actualend = default(System.DateTimeOffset?), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemail = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecord = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMlead regardingobjectidLead = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebooking = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheader = default(MicrosoftDynamicsCRMbookableresourcebookingheader), IList<MicrosoftDynamicsCRMbulkoperation> activityPointerBulkOperation = default(IList<MicrosoftDynamicsCRMbulkoperation>), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperation = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMcampaign regardingobjectidCampaign = default(MicrosoftDynamicsCRMcampaign), IList<MicrosoftDynamicsCRMcampaignactivity> activityPointerCampaignactivity = default(IList<MicrosoftDynamicsCRMcampaignactivity>), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivity = default(MicrosoftDynamicsCRMcampaignactivity), IList<MicrosoftDynamicsCRMcampaignresponse> activityPointerCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMbulkoperationlog> activityPointerBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), IList<MicrosoftDynamicsCRMbulkoperationlog> createdActivityBulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), IList<MicrosoftDynamicsCRMcampaignactivityitem> activityPointerCampaignActivityItems = default(IList<MicrosoftDynamicsCRMcampaignactivityitem>), IList<MicrosoftDynamicsCRMcampaignresponse> activityCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMcontract regardingobjectidContract = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlement = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplate = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMincident regardingobjectidIncident = default(MicrosoftDynamicsCRMincident), IList<MicrosoftDynamicsCRMincidentresolution> activityPointerIncidentResolution = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMserviceappointment> activityPointerServiceAppointment = default(IList<MicrosoftDynamicsCRMserviceappointment>), MicrosoftDynamicsCRMsite regardingobjectidSite = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMservice serviceid = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMinvoice regardingobjectidInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunity = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMopportunityclose> activityPointerOpportunityClose = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> activityPointerOrderClose = default(IList<MicrosoftDynamicsCRMorderclose>), MicrosoftDynamicsCRMquote regardingobjectidQuote = default(MicrosoftDynamicsCRMquote), IList<MicrosoftDynamicsCRMquoteclose> activityPointerQuoteClose = default(IList<MicrosoftDynamicsCRMquoteclose>), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorder = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMmsdynPostalbum regardingobjectidMsdynPostalbum = default(MicrosoftDynamicsCRMmsdynPostalbum), MicrosoftDynamicsCRMssgSearchrequest regardingobjectidSsgSearchrequest = default(MicrosoftDynamicsCRMssgSearchrequest), MicrosoftDynamicsCRMssgIjssservicerequest regardingobjectidSsgIjssservicerequest = default(MicrosoftDynamicsCRMssgIjssservicerequest), MicrosoftDynamicsCRMssgIjsscase regardingobjectidSsgIjsscase = default(MicrosoftDynamicsCRMssgIjsscase), MicrosoftDynamicsCRMssgCsrsfile regardingobjectidSsgCsrsfile = default(MicrosoftDynamicsCRMssgCsrsfile), MicrosoftDynamicsCRMssgCsrsrecalculation regardingobjectidSsgCsrsrecalculation = default(MicrosoftDynamicsCRMssgCsrsrecalculation), MicrosoftDynamicsCRMafkWorkflowelementoption regardingobjectidAfkWorkflowelementoption = default(MicrosoftDynamicsCRMafkWorkflowelementoption), IList<MicrosoftDynamicsCRMafkWorkflowtask> activityPointerAfkWorkflowtask = default(IList<MicrosoftDynamicsCRMafkWorkflowtask>), MicrosoftDynamicsCRMssgRequestforinformationletter regardingobjectidSsgRequestforinformationletter = default(MicrosoftDynamicsCRMssgRequestforinformationletter), MicrosoftDynamicsCRMssgMspgroup regardingobjectidSsgMspgroup = default(MicrosoftDynamicsCRMssgMspgroup), MicrosoftDynamicsCRMaccount regardingobjectidAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontact regardingobjectidContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMsocialactivity> activityPointerSocialactivity = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> activityPointerRecurringappointmentmaster = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMemail> activityPointerEmail = default(IList<MicrosoftDynamicsCRMemail>), MicrosoftDynamicsCRMmailbox sendermailboxid = default(MicrosoftDynamicsCRMmailbox), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMqueueitem> activityPointerQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaActivitypointerSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticle = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMactivitymimeattachment> activityPointerActivityMimeAttachment = default(IList<MicrosoftDynamicsCRMactivitymimeattachment>), IList<MicrosoftDynamicsCRMfax> activityPointerFax = default(IList<MicrosoftDynamicsCRMfax>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMtask> activityPointerTask = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMphonecall> activityPointerPhonecall = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMappointment> activityPointerAppointment = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMletter> activityPointerLetter = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceActivitypointer = default(IList<MicrosoftDynamicsCRMslakpiinstance>), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMbulkdeletefailure> activityPointerBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMconnection> activitypointerConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMasyncoperation> activityPointerAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMrecurrencerule> activityPointerRecurrencerule = default(IList<MicrosoftDynamicsCRMrecurrencerule>), IList<MicrosoftDynamicsCRMactivityparty> activitypointerActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), string bulkoperationnumber = default(string), int? operationtypecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? targetedrecordtypecode = default(int?), string workflowinfo = default(string), int? failurecount = default(int?), string parameters = default(string), int? importsequencenumber = default(int?), int? successcount = default(int?), int? targetmemberscount = default(int?), int? createdrecordtypecode = default(int?), int? errornumber = default(int?), MicrosoftDynamicsCRMinteractionforemail regardingobjectidNewInteractionforemailBulkoperation = default(MicrosoftDynamicsCRMinteractionforemail), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordBulkoperation = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMlead regardingobjectidLeadBulkoperation = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingBulkoperation = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderBulkoperation = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMaccount regardingobjectidAccountBulkoperation = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMsystemuser createdbyBulkoperation = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontact regardingobjectidContactBulkoperation = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMmailbox sendermailboxidBulkoperation = default(MicrosoftDynamicsCRMmailbox), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidBulkoperation = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMprincipal owneridBulkoperation = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMsystemuser owninguserBulkoperation = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsla slaActivitypointerSlaBulkoperation = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMbusinessunit owningbusinessunitBulkoperation = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleBulkoperation = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyBulkoperation = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyBulkoperation = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyBulkoperation = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteamBulkoperation = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsla slainvokedidActivitypointerSlaBulkoperation = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMactivitypointer> bulkOperationActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> bulkOperationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMactivityparty> bulkoperationActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMasyncoperation> bulkOperationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> bulkOperationMailboxTrackingFolder = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bulkOperationBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> bulkoperationPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMappointment> bulkOperationAppointment = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> bulkOperationEmail = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> bulkOperationFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> bulkOperationLetter = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> bulkOperationPhonecall = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> bulkoperationTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> bulkOperationRecurringAppointmentMaster = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> bulkOperationSocialActivity = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMannotation> bulkoperationAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMcampaignresponse> bulkOperationCampaignResponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMbulkoperationlog> bulkOperationLogs = default(IList<MicrosoftDynamicsCRMbulkoperationlog>), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityBulkoperation = default(MicrosoftDynamicsCRMcampaignactivity), MicrosoftDynamicsCRMlist regardingobjectidList = default(MicrosoftDynamicsCRMlist), IList<MicrosoftDynamicsCRMqueueitem> bulkOperationQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMincidentresolution> bulkoperationIncidentResolutions = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMserviceappointment> bulkoperationServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMopportunityclose> bulkoperationOpportunityCloses = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> bulkoperationOrderCloses = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMquoteclose> bulkoperationQuoteCloses = default(IList<MicrosoftDynamicsCRMquoteclose>), IList<MicrosoftDynamicsCRMafkWorkflowtask> bulkoperationAfkWorkflowtasks = default(IList<MicrosoftDynamicsCRMafkWorkflowtask>))
            : base(lastonholdtime, _owningteamValue, exchangeitemid, ismapiprivate, createdon, seriesid, _regardingobjectidValue, deliverylastattemptedon, isbilled, isworkflowcreated, _sendermailboxidValue, scheduledend, description, onholdtime, _modifiedbyValue, community, sortdate, instancetypecode, timezoneruleversionnumber, _createdonbehalfbyValue, _createdbyValue, _transactioncurrencyidValue, versionnumber, processid, prioritycode, _serviceidValue, _slaidValue, stageid, actualstart, _owningbusinessunitValue, _owninguserValue, utcconversiontimezonecode, exchangeweblink, scheduleddurationminutes, senton, scheduledstart, _slainvokedidValue, statecode, subject, postponeactivityprocessinguntil, _modifiedonbehalfbyValue, exchangerate, isregularactivity, deliveryprioritycode, actualdurationminutes, traversedpath, activityid, activitytypecode, activityadditionalparams, modifiedon, _owneridValue, leftvoicemail, statuscode, actualend, regardingobjectidNewInteractionforemail, regardingobjectidKnowledgebaserecord, regardingobjectidLead, regardingobjectidBookableresourcebooking, regardingobjectidBookableresourcebookingheader, activityPointerBulkOperation, regardingobjectidBulkoperation, regardingobjectidCampaign, activityPointerCampaignactivity, regardingobjectidCampaignactivity, activityPointerCampaignresponse, activityPointerBulkOperationLogs, createdActivityBulkOperationLogs, activityPointerCampaignActivityItems, activityCampaignresponse, regardingobjectidContract, regardingobjectidEntitlement, regardingobjectidEntitlementtemplate, regardingobjectidIncident, activityPointerIncidentResolution, activityPointerServiceAppointment, regardingobjectidSite, serviceid, regardingobjectidInvoice, regardingobjectidOpportunity, activityPointerOpportunityClose, activityPointerOrderClose, regardingobjectidQuote, activityPointerQuoteClose, regardingobjectidSalesorder, regardingobjectidMsdynPostalbum, regardingobjectidSsgSearchrequest, regardingobjectidSsgIjssservicerequest, regardingobjectidSsgIjsscase, regardingobjectidSsgCsrsfile, regardingobjectidSsgCsrsrecalculation, regardingobjectidAfkWorkflowelementoption, activityPointerAfkWorkflowtask, regardingobjectidSsgRequestforinformationletter, regardingobjectidSsgMspgroup, regardingobjectidAccount, createdby, regardingobjectidContact, activityPointerSocialactivity, activityPointerRecurringappointmentmaster, activityPointerEmail, sendermailboxid, transactioncurrencyid, activityPointerQueueItem, ownerid, owninguser, slaActivitypointerSla, owningbusinessunit, regardingobjectidKnowledgearticle, modifiedonbehalfby, activityPointerActivityMimeAttachment, activityPointerFax, createdonbehalfby, modifiedby, activityPointerTask, activityPointerPhonecall, activityPointerAppointment, activityPointerLetter, activitypointerConnections2, slakpiinstanceActivitypointer, owningteam, activityPointerBulkDeleteFailures, slainvokedidActivitypointerSla, activitypointerConnections1, activityPointerAsyncOperations, activityPointerRecurrencerule, activitypointerActivityParties)
        {
            Bulkoperationnumber = bulkoperationnumber;
            Operationtypecode = operationtypecode;
            Overriddencreatedon = overriddencreatedon;
            Targetedrecordtypecode = targetedrecordtypecode;
            Workflowinfo = workflowinfo;
            Failurecount = failurecount;
            Parameters = parameters;
            Importsequencenumber = importsequencenumber;
            Successcount = successcount;
            Targetmemberscount = targetmemberscount;
            Createdrecordtypecode = createdrecordtypecode;
            Errornumber = errornumber;
            RegardingobjectidNewInteractionforemailBulkoperation = regardingobjectidNewInteractionforemailBulkoperation;
            RegardingobjectidKnowledgebaserecordBulkoperation = regardingobjectidKnowledgebaserecordBulkoperation;
            RegardingobjectidLeadBulkoperation = regardingobjectidLeadBulkoperation;
            RegardingobjectidBookableresourcebookingBulkoperation = regardingobjectidBookableresourcebookingBulkoperation;
            RegardingobjectidBookableresourcebookingheaderBulkoperation = regardingobjectidBookableresourcebookingheaderBulkoperation;
            RegardingobjectidAccountBulkoperation = regardingobjectidAccountBulkoperation;
            CreatedbyBulkoperation = createdbyBulkoperation;
            RegardingobjectidContactBulkoperation = regardingobjectidContactBulkoperation;
            SendermailboxidBulkoperation = sendermailboxidBulkoperation;
            TransactioncurrencyidBulkoperation = transactioncurrencyidBulkoperation;
            OwneridBulkoperation = owneridBulkoperation;
            OwninguserBulkoperation = owninguserBulkoperation;
            SlaActivitypointerSlaBulkoperation = slaActivitypointerSlaBulkoperation;
            OwningbusinessunitBulkoperation = owningbusinessunitBulkoperation;
            RegardingobjectidKnowledgearticleBulkoperation = regardingobjectidKnowledgearticleBulkoperation;
            ModifiedonbehalfbyBulkoperation = modifiedonbehalfbyBulkoperation;
            CreatedonbehalfbyBulkoperation = createdonbehalfbyBulkoperation;
            ModifiedbyBulkoperation = modifiedbyBulkoperation;
            OwningteamBulkoperation = owningteamBulkoperation;
            SlainvokedidActivitypointerSlaBulkoperation = slainvokedidActivitypointerSlaBulkoperation;
            ActivityidActivitypointer = activityidActivitypointer;
            BulkOperationActivityPointers = bulkOperationActivityPointers;
            BulkOperationSyncErrors = bulkOperationSyncErrors;
            BulkoperationActivityParties = bulkoperationActivityParties;
            BulkOperationAsyncOperations = bulkOperationAsyncOperations;
            BulkOperationMailboxTrackingFolder = bulkOperationMailboxTrackingFolder;
            BulkOperationBulkDeleteFailures = bulkOperationBulkDeleteFailures;
            BulkoperationPrincipalObjectAttributeAccesses = bulkoperationPrincipalObjectAttributeAccesses;
            BulkOperationAppointment = bulkOperationAppointment;
            BulkOperationEmail = bulkOperationEmail;
            BulkOperationFaxes = bulkOperationFaxes;
            BulkOperationLetter = bulkOperationLetter;
            BulkOperationPhonecall = bulkOperationPhonecall;
            BulkoperationTasks = bulkoperationTasks;
            BulkOperationRecurringAppointmentMaster = bulkOperationRecurringAppointmentMaster;
            BulkOperationSocialActivity = bulkOperationSocialActivity;
            BulkoperationAnnotations = bulkoperationAnnotations;
            BulkOperationCampaignResponse = bulkOperationCampaignResponse;
            BulkOperationLogs = bulkOperationLogs;
            RegardingobjectidCampaignactivityBulkoperation = regardingobjectidCampaignactivityBulkoperation;
            RegardingobjectidList = regardingobjectidList;
            BulkOperationQueueItem = bulkOperationQueueItem;
            BulkoperationIncidentResolutions = bulkoperationIncidentResolutions;
            BulkoperationServiceAppointments = bulkoperationServiceAppointments;
            BulkoperationOpportunityCloses = bulkoperationOpportunityCloses;
            BulkoperationOrderCloses = bulkoperationOrderCloses;
            BulkoperationQuoteCloses = bulkoperationQuoteCloses;
            BulkoperationAfkWorkflowtasks = bulkoperationAfkWorkflowtasks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperationnumber")]
        public string Bulkoperationnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operationtypecode")]
        public int? Operationtypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetedrecordtypecode")]
        public int? Targetedrecordtypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowinfo")]
        public string Workflowinfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "failurecount")]
        public int? Failurecount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public string Parameters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "successcount")]
        public int? Successcount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetmemberscount")]
        public int? Targetmemberscount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdrecordtypecode")]
        public int? Createdrecordtypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errornumber")]
        public int? Errornumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_new_interactionforemail_bulkoperation")]
        public MicrosoftDynamicsCRMinteractionforemail RegardingobjectidNewInteractionforemailBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_bulkoperation")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_bulkoperation")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_bulkoperation")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_bulkoperation")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_bulkoperation")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_bulkoperation")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_bulkoperation")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sendermailboxid_bulkoperation")]
        public MicrosoftDynamicsCRMmailbox SendermailboxidBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_bulkoperation")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid_bulkoperation")]
        public MicrosoftDynamicsCRMprincipal OwneridBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_bulkoperation")]
        public MicrosoftDynamicsCRMsystemuser OwninguserBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_activitypointer_sla_bulkoperation")]
        public MicrosoftDynamicsCRMsla SlaActivitypointerSlaBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_bulkoperation")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_bulkoperation")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_bulkoperation")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_bulkoperation")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_bulkoperation")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_bulkoperation")]
        public MicrosoftDynamicsCRMteam OwningteamBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_activitypointer_sla_bulkoperation")]
        public MicrosoftDynamicsCRMsla SlainvokedidActivitypointerSlaBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> BulkOperationActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BulkOperationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> BulkoperationActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BulkOperationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_MailboxTrackingFolder")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> BulkOperationMailboxTrackingFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BulkOperationBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> BulkoperationPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_Appointment")]
        public IList<MicrosoftDynamicsCRMappointment> BulkOperationAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_Email")]
        public IList<MicrosoftDynamicsCRMemail> BulkOperationEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> BulkOperationFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_Letter")]
        public IList<MicrosoftDynamicsCRMletter> BulkOperationLetter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_Phonecall")]
        public IList<MicrosoftDynamicsCRMphonecall> BulkOperationPhonecall { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> BulkoperationTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_RecurringAppointmentMaster")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> BulkOperationRecurringAppointmentMaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_SocialActivity")]
        public IList<MicrosoftDynamicsCRMsocialactivity> BulkOperationSocialActivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> BulkoperationAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_CampaignResponse")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> BulkOperationCampaignResponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_logs")]
        public IList<MicrosoftDynamicsCRMbulkoperationlog> BulkOperationLogs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_bulkoperation")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityBulkoperation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_list")]
        public MicrosoftDynamicsCRMlist RegardingobjectidList { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BulkOperation_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> BulkOperationQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_IncidentResolutions")]
        public IList<MicrosoftDynamicsCRMincidentresolution> BulkoperationIncidentResolutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> BulkoperationServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_OpportunityCloses")]
        public IList<MicrosoftDynamicsCRMopportunityclose> BulkoperationOpportunityCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_OrderCloses")]
        public IList<MicrosoftDynamicsCRMorderclose> BulkoperationOrderCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_QuoteCloses")]
        public IList<MicrosoftDynamicsCRMquoteclose> BulkoperationQuoteCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bulkoperation_afk_workflowtasks")]
        public IList<MicrosoftDynamicsCRMafkWorkflowtask> BulkoperationAfkWorkflowtasks { get; set; }

    }
}
