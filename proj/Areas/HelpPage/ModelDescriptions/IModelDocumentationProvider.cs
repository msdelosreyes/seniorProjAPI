using System;
using System.Reflection;

namespace PaymentAuthorizationWebAPI_CIS4290.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}