using MyavanaAdminModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyavanaAdminApiClient
{
    public partial class ApiClient
    {
        public async Task<List<QuestionAnswerModel>> GetQuestionnaireList()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Questionnaire/GetQuestionnaireAdmin"));
            var response = await GetAsyncData<QuestionAnswerModel>(requestUrl);
            List<QuestionAnswerModel> questionaire = JsonConvert.DeserializeObject<List<QuestionAnswerModel>>(Convert.ToString(response.data));
            return questionaire;
        }

        public async Task<List<QuestionAnswerModel>> GetQuestionnaireAbsenceUserList()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Questionnaire/GetQuestionnaireAbsenceUserList"));
            var response = await GetAsyncData<QuestionAnswerModel>(requestUrl);
            List<QuestionAnswerModel> questionaire = JsonConvert.DeserializeObject<List<QuestionAnswerModel>>(Convert.ToString(response.data));
            return questionaire;
        }

        public async Task<Message<HairProfileAdminModel>> GetHairProfileAdmin(HairProfileAdminModel hairProfileModel)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "HairProfile/GetHairProfileAdmin"));
            var result = await PostAsync<HairProfileAdminModel>(requestUrl, hairProfileModel);
            return result;
        }

        public async Task<Message<QuestionaireSelectedAnswer>> GetQuestionaireAnswer(QuestionaireSelectedAnswer hairProfileModel)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "HairProfile/GetQuestionaireAnswer"));
            var result = await PostAsync<QuestionaireSelectedAnswer>(requestUrl, hairProfileModel);
            return result;
        }

        public async Task<List<QuestionnaireCustomerList>> QuestionnaireCustomerList()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Questionnaire/GetQuestionnaireCustomerList"));
            var response = await GetAsyncData<QuestionnaireCustomerList>(requestUrl);
            List<QuestionnaireCustomerList> blogPosts = JsonConvert.DeserializeObject<List<QuestionnaireCustomerList>>(Convert.ToString(response.value));
            return blogPosts;

        }

        public async Task<List<CustomerMessageViewModel>> CustomerMessagesList(string userId)
        {
            QuestionaireModel questionaireModel = new QuestionaireModel { Userid = userId };
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Questionnaire/GetCustomerMessagesList/"+userId));
            var response = await GetAsyncData<CustomerMessageViewModel>(requestUrl);
            List<CustomerMessageViewModel> custMsgs = JsonConvert.DeserializeObject<List<CustomerMessageViewModel>>(Convert.ToString(response.value));
            return custMsgs;

        }

        public async Task<Message<IEnumerable<Questionaire>>> SaveQuestionnaireSurvey(IEnumerable<Questionaire> questionaire)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Questionnaire/SaveSurveyAdmin"));
            var result = await PostAsync<IEnumerable<Questionaire>>(requestUrl, questionaire);
            return result;
        }

        public async Task<Message<QuestModel>> DeleteQuest(QuestModel questModel)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Questionnaire/DeleteQuest"));
            var result = await PostAsync<QuestModel>(requestUrl, questModel);
            return result;
        }

        public async Task<List<QuestionGraph>> GetQuestionsForGraph()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Questionnaire/GetQuestionsForGraph"));
            var response = await GetAsyncData<QuestionGraph>(requestUrl);
            List<QuestionGraph> questionaire = JsonConvert.DeserializeObject<List<QuestionGraph>>(Convert.ToString(response.data));
            return questionaire;
        }

        public async Task<Message<CustomerMessageModel>> SaveCustomerMessage(CustomerMessageModel customerMessageModel)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
            "Questionnaire/SaveCustomerMessage"));
            var result = await PostAsync<CustomerMessageModel>(requestUrl, customerMessageModel);
            return result;
        }

        public async Task<EmailTemplate> GetCustomerEmailTemplate()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Questionnaire/GetCustomerEmailTemplate"));
            var result = await GetAsyncData<EmailTemplate>(requestUrl);
            EmailTemplate emailTemplate = JsonConvert.DeserializeObject<EmailTemplate>(Convert.ToString(result.data));
            return emailTemplate;
        }
    }
}
