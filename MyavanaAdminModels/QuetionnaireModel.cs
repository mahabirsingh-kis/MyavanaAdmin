using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyavanaAdminModels
{
    public class QuetionnaireModel
    {
        public int QuestionaireId { get; set; }
        public string UserId { get; set; }
        public int? QuestionId { get; set; }
        public string Question { get; set; }
        public int? AnswerId { get; set; }
        public string Answer { get; set; }
        public string DescriptiveAnswer { get; set; }
    }

    public class QuestionAnswerModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public bool? IsDraft { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<QuestionModels> questionModel { get; set; }
        public bool? CustomerType { get; set; }
    }
    public class QuestionAnswersModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public ICollection<QuestionModels> questionModel { get; set; }
    }

    public class QuestionModels
    {
        public int? QuestionId { get; set; }
        public string Question { get; set; }
        public int SerialNo { get; set; }
        public ICollection<AnswerModel> AnswerList { get; set; }
    }

    public class AnswerModel
    {
        public int? AnswerId { get; set; }
        public string Answer { get; set; }
        public string Description { get; set; }
    }

    public class QuestionnaireCustomerList
    {
        [JsonProperty(PropertyName = "UserId")]
        public string UserId { get; set; }
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }
        [JsonProperty(PropertyName = "UserEmail")]
        public string UserEmail { get; set; }
        [JsonProperty(PropertyName = "CreatedAt")]
        public DateTimeOffset? CreatedAt { get; set; }
        [JsonProperty(PropertyName = "IsQuestionnaire")]
        public bool? IsQuestionnaire { get; set; }

        [JsonProperty(PropertyName = "CustomerType")]
        public bool? CustomerType { get; set; }
    }

    public class CustomerMessageList
    {
        [JsonProperty(PropertyName = "Email")]
        public string EmailAddress { get; set; }

        [JsonProperty(PropertyName = "Subject")] 
        public string Subject { get; set; }

        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "Sent On")]
        public DateTime CreatedOn { get; set; }

        [JsonProperty(PropertyName = "Attachment")]
        public string AttachmentFile { get; set; }
    }

    public class Questionaire
    {
        public int QuestionaireId { get; set; }
        public string UserId { get; set; }
        public int QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public string DescriptiveAnswer { get; set; }

        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
    }

    public class FileModel
    {
        public IFormFile FormFile { get; set; }
        public string FileName { get; set; }
        public string UniqueFileName { get; set; }

    }

    public class QuestionGraph
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public List<AnswerCount> AnswerCounts { get; set; }
    }

    public class AnswerCount
    {
        public int? AnswerId { get; set; }
        public string Answer { get; set; }
        public int Count { get; set; }
    }

    public class CustomerMessageModel
    {
        public int CustomerMessageId { get; set; }
        public Guid UserId { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime CreatedOn { get; set; }
        public string AttachmentFile { get; set; }
        public bool IsActive { get; set; }
        public IFormFile Attachment { get; set; }
        public string emailBody { get; set; }
        public string emailTemplate { get; set; } = "EMAILTEMPLATE";
    }

    public class EmailTemplate
    {
        public string TemplateCode { get; set; }
        public string TemplateType { get; set; }
        public string TemplateName { get; set; }
        public string SMTPUsername { get; set; }
        public string SenderEmail { get; set; }
        public string SenderName { get; set; }
        public string SMTPPassword { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public string HostName { get; set; }
        public int HostPort { get; set; }
        public bool EnableSSL { get; set; }
        public int TimeOut { get; set; }
    }
    public class Signup
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public int CountryCode { get; set; }
        public bool? CustomerType { get; set; }
    }
    public class Response
    {
        public string contentType { get; set; }
        public string serializerSettings { get; set; }
        public int statusCode { get; set; }
        public ResponseItem value { get; set; }
    }

    public class ResponseItem
    {
        public string item1 { get; set; }
        public string item2 { get; set; }
    }

    public class CustomerMessageViewModel
    {
        [JsonProperty(PropertyName = "EmailAddress")]
        public string EmailAddress { get; set; }
        [JsonProperty(PropertyName = "Subject")]
        public string Subject { get; set; }
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }
        [JsonProperty(PropertyName = "CreatedOn")]
        public DateTime CreatedOn { get; set; }
        [JsonProperty(PropertyName = "AttachmentFile")]
        public string AttachmentFile { get; set; }
    }
}
