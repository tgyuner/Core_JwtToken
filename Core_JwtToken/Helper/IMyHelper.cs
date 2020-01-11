using Core_JwtToken.Model;

namespace Core_JwtToken.Helper
{
    /// <summary>
    /// The i helper
    /// </summary>
    public interface IMyHelper
    {
        /// <summary>
        /// Logs the in.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        User LogIn(string username, string password);
    }
}