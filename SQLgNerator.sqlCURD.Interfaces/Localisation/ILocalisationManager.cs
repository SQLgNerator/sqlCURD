using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLgNerator.sqlCURD.Interfaces.Localisation
{
    /// <summary>
    /// The interface that defines the methods for fetching the culrture specific values for the resources
    /// </summary>
    public interface ILocalisationManager
    {
        /// <summary>
        /// Gets the resource key value with the specified resource key from the resource file.
        /// </summary>
        /// <param name="resourceKey">The resource key to be fetched.</param>
        /// <returns>The corresponding value of the specified resource key.</returns>
        string this[string resourceKey] { get; }

        /// <summary>
        /// Gets the string value corresponding to the resource key specfied from the resource file.
        /// </summary>
        /// <param name="resourceKey">The resource key whose value need to be fetched.</param>
        /// <returns>The string value corresponding to the key specified.</returns>
        string GetString(string resourceKey);

        /// <summary>
        /// Gets the object value corresponding to the resource key specfied from the resource file.
        /// </summary>
        /// <param name="resourceKey">The resource key whose value need to be fetched.</param>
        /// <returns>The string value corresponding to the key specified.</returns>
        object GetObject(string resourceKey);
    }
}
