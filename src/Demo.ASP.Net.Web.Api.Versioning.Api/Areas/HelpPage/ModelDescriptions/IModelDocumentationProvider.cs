using System;
using System.Reflection;

namespace Demo.ASP.Net.Web.Api.Versioning.Api.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}