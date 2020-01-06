// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zapappi.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CalloutModel
    {
        /// <summary>
        /// Initializes a new instance of the CalloutModel class.
        /// </summary>
        public CalloutModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CalloutModel class.
        /// </summary>
        public CalloutModel(string callerID, string destination, string provider, int timeout, string webHook = default(string), string messageGroup = default(string))
        {
            CallerID = callerID;
            Destination = destination;
            Provider = provider;
            Timeout = timeout;
            WebHook = webHook;
            MessageGroup = messageGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CallerID")]
        public string CallerID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Destination")]
        public string Destination { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Provider")]
        public string Provider { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Timeout")]
        public int Timeout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "WebHook")]
        public string WebHook { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MessageGroup")]
        public string MessageGroup { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CallerID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CallerID");
            }
            if (Destination == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Destination");
            }
            if (Provider == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Provider");
            }
        }
    }
}