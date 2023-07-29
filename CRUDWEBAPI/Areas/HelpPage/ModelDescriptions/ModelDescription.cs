using System;

namespace CRUDWEBAPI.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// Describes a type model.
    /// </summary>
    public abstract class ModelDescription
    {
        public string Documentatione { get; set; }

        public Type ModelType { get; set; }

        public string Namewewe { get; set; }
    }
}