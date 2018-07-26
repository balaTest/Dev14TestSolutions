using System;
using System.Reflection;

namespace WebApiApp_net452_cs_IndAuth_1.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}