using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;

internal sealed class GlobalBindingRequiredProvider : IBindingMetadataProvider
{
    public void CreateBindingMetadata(BindingMetadataProviderContext context)
    {
        context.BindingMetadata.IsBindingRequired = true;
    }
}
