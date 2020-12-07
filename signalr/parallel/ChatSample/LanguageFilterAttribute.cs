using System;

public class LanguageFilterAttribute : Attribute
{
    public LanguageFilterAttribute(int filterArgument)
    {
        this.FilterArgument = filterArgument;
    }
    public int FilterArgument { get; set; }
}