//-----------------------------------------------------------------------
// <copyright file="IDocumentProcessor.cs" company="NSwag">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/NSwag/NSwag/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

using System.Threading.Tasks;
using NSwag.SwaggerGeneration.Processors.Contexts;

namespace NSwag.SwaggerGeneration.Processors
{
    /// <summary>Post processes a generated <see cref="SwaggerDocument"/>.</summary>
    public interface IDocumentProcessor
    {
        /// <summary>Processes the specified Swagger document.</summary>
        /// <param name="context">The processor context.</param>
        Task ProcessAsync(DocumentProcessorContext context);
    }
}