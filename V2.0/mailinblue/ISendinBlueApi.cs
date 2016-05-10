using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace mailinblue
{
    public interface ISendinBlueApi
    {
        Task<JObject> AddRemoveChildCredits(object data);
        Task<JObject> AddUsersList(Dictionary<string, object> data);
        Task<JObject> CampaignRecipientsExport(Dictionary<string, object> data);
        Task<JObject> CampaignReportEmail(Dictionary<string, object> data);
        Task<JObject> CreateAttribute(object data);
        Task<JObject> CreateCampaign(object data);
        Task<JObject> CreateChildAccount(object data);
        Task<JObject> CreateFolder(object data);
        Task<JObject> CreateList(object data);
        Task<JObject> CreateSender(object data);
        Task<JObject> CreateSmsCampaign(object data);
        Task<JObject> CreateTemplate(object data);
        Task<JObject> CreateTriggerCampaign(object data);
        Task<JObject> CreateUpdateUser(object data);
        Task<JObject> CreateWebhook(object data);
        Task<JObject> DeleteAttribute(Dictionary<string, object> data);
        Task<JObject> DeleteBounces(object data);
        Task<JObject> DeleteCampaign(Dictionary<string, int> data);
        Task<JObject> DeleteChildAccount(Dictionary<string, string> data);
        Task<JObject> DeleteFolder(Dictionary<string, int> data);
        Task<JObject> DeleteList(Dictionary<string, int> data);
        Task<JObject> DeleteSender(Dictionary<string, int> data);
        Task<JObject> DeleteUser(Dictionary<string, string> data);
        Task<JObject> DeleteUsersList(Dictionary<string, object> data);
        Task<JObject> DeleteWebhook(Dictionary<string, int> data);
        Task<JObject> DisplayListUsers(object data);
        Task<JObject> ExportUsers(object data);
        Task<JObject> GetAccount();
        Task<JObject> GetAttribute(Dictionary<string, string> data);
        Task<JObject> GetAttributes();
        Task<JObject> GetCampaignsV2(Dictionary<string, object> data);
        Task<JObject> GetCampaignV2(Dictionary<string, int> data);
        Task<JObject> GetFolder(Dictionary<string, int> data);
        Task<JObject> GetFolders(Dictionary<string, int> data);
        Task<JObject> GetList(Dictionary<string, int> data);
        Task<JObject> GetLists(Dictionary<string, int> data);
        Task<JObject> GetProcess(Dictionary<string, int> data);
        Task<JObject> GetProcesses(Dictionary<string, int> data);
        Task<JObject> GetReport(object data);
        Task<JObject> GetResellerChild(object data);
        Task<JObject> GetSenders(Dictionary<string, string> data);
        Task<JObject> GetSmtpDetails();
        Task<JObject> GetStatistics(object data);
        Task<JObject> GetUser(Dictionary<string, string> data);
        Task<JObject> GetWebhook(Dictionary<string, int> data);
        Task<JObject> GetWebhooks(Dictionary<string, string> data);
        Task<JObject> ImportUsers(object data);
        Task<JObject> SendBatEmail(Dictionary<string, object> data);
        Task<JObject> SendBatSms(Dictionary<string, object> data);
        Task<JObject> SendEmail(object data);
        Task<JObject> SendSms(object data);
        Task<JObject> SendTransactionalTemplate(Dictionary<string, object> data);
        Task<JObject> ShareCampaign(object data);
        Task<JObject> UpdateCampaign(Dictionary<string, object> data);
        Task<JObject> UpdateCampaignStatus(Dictionary<string, object> data);
        Task<JObject> UpdateChildAccount(object data);
        Task<JObject> UpdateFolder(Dictionary<string, object> data);
        Task<JObject> UpdateList(Dictionary<string, object> data);
        Task<JObject> UpdateSender(Dictionary<string, object> data);
        Task<JObject> UpdateSmsCampaign(Dictionary<string, object> data);
        Task<JObject> UpdateTemplate(Dictionary<string, object> data);
        Task<JObject> UpdateTriggerCampaign(Dictionary<string, object> data);
        Task<JObject> UpdateWebhook(Dictionary<string, object> data);
    }
}