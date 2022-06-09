namespace KUSYS.Domain
{
    public partial class BaseEntity
    {
        /// <summary>
        /// Gets or sets identity for all entity model
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets date of creation of entity
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}