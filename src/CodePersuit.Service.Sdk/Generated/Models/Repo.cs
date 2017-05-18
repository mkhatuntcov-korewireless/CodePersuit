// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace CodePersuit.Service.Sdk.Models
{
    using CodePersuit.Service;
    using CodePersuit.Service.Sdk;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Repo
    {
        /// <summary>
        /// Initializes a new instance of the Repo class.
        /// </summary>
        public Repo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Repo class.
        /// </summary>
        public Repo(string name, int? repositoryId = default(int?), int? ownerId = default(int?))
        {
            Name = name;
            RepositoryId = repositoryId;
            OwnerId = ownerId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "repositoryId")]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerId")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Name != null)
            {
                if (Name.Length > 255)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 255);
                }
                if (Name.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 0);
                }
            }
        }
    }
}