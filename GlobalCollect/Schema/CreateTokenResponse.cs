using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CreateTokenResponse
    {
        /// <summary>
        /// Indicates if a new token was created true - A new token was created false - A token with the same card number already exists and is returned. Please note that the existing token has not been updated. When you want to update other data then the card number, you need to use the update API call, as data is never updated during the creation of a token.
        /// </summary>
        [JsonProperty("isNewToken")]
        public bool IsNewToken { get; set; }

        /// <summary>
        /// ID of the token
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}