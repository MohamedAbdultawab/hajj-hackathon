using System;
using System.Collections.Generic;
namespace Entity
{
    public class Person : EntityBase<int>
    {
        /// <summary>
        /// Gets or sets the first name of this instance.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the name of the middle of this instance.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the name of the third of this instance.
        /// </summary>
        public string ThirdName { get; set; }

        /// <summary>
        /// Gets or sets the last name of this instance.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets the full name for person.
        /// </summary>
        public string Name
        {
            get { return $"{FirstName} {MiddleName ?? null} {ThirdName ?? null} {LastName}"; }
        }

        /// <summary>
        /// Gets or sets the homeland identifier of this instance.
        /// </summary>
        public int HomelandId { get; set; }

        /// <summary>
        /// Gets or sets the homeland of this instance.
        /// </summary>
        public Country Homeland { get; set; }

        /// <summary>
        /// Gets or sets the national ID of this instance.
        /// </summary>
        public string NationalId { get; set; }

        /// <summary>
        /// Gets or sets the birth date of this instance.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the birthplace identifier of this instance.
        /// </summary>
        public long? BirthplaceId { get; set; }

        /// <summary>
        /// Gets or sets the birthplace of this instance.
        /// </summary>
        public Address Birthplace { get; set; }

        /// <summary>
        /// Gets or sets the death date of this instance.
        /// </summary>
        public DateTime? DeathDate { get; set; }

        /// <summary>
        /// Gets or sets the deathplace identifier of this instance.
        /// </summary>
        public long? DeathplaceId { get; set; }

        /// <summary>
        /// Gets or sets the deathplace of this instance.
        /// </summary>
        public Address Deathplace { get; set; }

        /// <summary>
        /// Gets or sets the death reason identifier of this instance.
        /// </summary>
        public int? DeathReasonId { get; set; }

        /// <summary>
        /// Gets or sets the death reason of this instance.
        /// </summary>
        public DeathReason DeathReason { get; set; }

        /// <summary>
        /// Gets or sets the death description of this instance.
        /// </summary>
        public string DeathDescription { get; set; }

        /// <summary>
        /// Gets or sets the blood type identifier for person.
        /// </summary>
        /// <value>The blood type identifier.</value>
        public int? BloodTypeId { get; set; }

        /// <summary>
        /// Gets or sets the type of the blood for person.
        /// </summary>
        /// <value>The blood type.</value>
        public BloodType BloodType { get; set; }

        /// <summary>
        /// Gets or sets the person category identifier.
        /// </summary>
        /// <value>The person category identifier.</value>
        public int? CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the category of person.
        /// </summary>
        /// <value>The person category.</value>
        public PersonCategory Category { get; set; }

        /// <summary>
        /// Gets or sets the person type identifier.
        /// </summary>
        /// <value>The person type identifier.</value>
        public int? TypeId { get; set; }

        /// <summary>
        /// Gets or sets the type of person.
        /// </summary>
        /// <value>The person type.</value>
        public PersonType Type { get; set; }

        /// <summary>
        /// Gets or sets the person status identifier.
        /// </summary>
        /// <value>The person status identifier.</value>
        public int? StatusId { get; set; }

        /// <summary>
        /// Gets or sets the status of this instance.
        /// </summary>
        public PersonStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the gender identifier of this instance.
        /// </summary>
        public int GenderId { get; set; }

        /// <summary>
        /// Gets or sets the gender of this instance.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Gets or sets the marital status identifier of this instance.
        /// </summary>
        public int? MaritalStatusId { get; set; }

        /// <summary>
        /// Gets or sets the historical marital statuses of this instance.
        /// </summary>
        public MaritalStatus MaritalStatus { get; set; }

        /// <summary>
        /// Gets or sets the doctrine identifier of this instance.
        /// </summary>
        public int? DoctrineId { get; set; }

        /// <summary>
        /// Gets or sets the doctrine of this instance.
        /// </summary>
        public Doctrine Doctrine { get; set; }

        /// <summary>
        /// Gets or sets the title identifier of this instance.
        /// </summary>
        public int? TitleId { get; set; }

        /// <summary>
        /// Gets or sets the title of this instance.
        /// </summary>
        public Title Title { get; set; }

        /// <summary>
        /// Gets or sets the photo of this instance.
        /// </summary>
        public byte[] Photo { get; set; }

        /// <summary>
        /// Gets or sets the email of this instance.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the mobile of this instance.
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Gets or sets the phone of this instance.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the spoken languages of this instance.
        /// </summary>
        public List<PersonLanguage> Languages { get; set; }

        /// <summary>
        /// Gets or sets the addresses of this instance.
        /// </summary>
        public List<PersonAddress> Addresses { get; set; }
    }
}