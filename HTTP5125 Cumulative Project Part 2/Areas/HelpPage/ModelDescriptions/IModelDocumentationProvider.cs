using System;
using System.Reflection;

namespace HTTP5125_Cumulative_Project_Part_2.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}