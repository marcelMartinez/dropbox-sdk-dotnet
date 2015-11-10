//-----------------------------------------------------------------------------
// <copyright file="IEncodable.cs" company="Dropbox Inc">
//  Copyright (c) Dropbox Inc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------

namespace Dropbox.Api.Babel
{
    /// <summary>
    /// Interface implemented by all objects generated by the babel API generator.
    /// This is used to support transport serialization of objects.
    /// </summary>
    public interface IEncodable
    {
        /// <summary>
        /// Encodes the object using the supplied writer.
        /// </summary>
        /// <param name="writer">The writer being used to serialize the object.</param>
        void Encode(IJsonWriter writer);
    }
}