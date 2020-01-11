namespace Core_JwtToken.Model
{
    /// <summary>
    /// The user
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        /// <value>
        /// The UserName.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Surname.
        /// </summary>
        /// <value>
        /// The Surname.
        /// </value>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the Email.
        /// </summary>
        /// <value>
        /// The Email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the PhoneNumber.
        /// </summary>
        /// <value>
        /// The PhoneNumber.
        /// </value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        /// <value>
        /// The Password.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        /// <value>
        /// The role.
        /// </value>
        public int Role { get; set; }
    }
}