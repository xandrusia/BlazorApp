// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\STUDIA\3.1\DNP\DNPA3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\STUDIA\3.1\DNP\DNPA3\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\STUDIA\3.1\DNP\DNPA3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\STUDIA\3.1\DNP\DNPA3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\STUDIA\3.1\DNP\DNPA3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\STUDIA\3.1\DNP\DNPA3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\STUDIA\3.1\DNP\DNPA3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\STUDIA\3.1\DNP\DNPA3\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\STUDIA\3.1\DNP\DNPA3\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\STUDIA\3.1\DNP\DNPA3\Client\_Imports.razor"
using Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\STUDIA\3.1\DNP\DNPA3\Client\Pages\AddAdult.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\STUDIA\3.1\DNP\DNPA3\Client\Pages\AddAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\STUDIA\3.1\DNP\DNPA3\Client\Pages\AddAdult.razor"
using Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\STUDIA\3.1\DNP\DNPA3\Client\Pages\AddAdult.razor"
 
    public Adult newAdultItem = new Adult();
    public Job newAdultJob = new Job();
    List<char> Sex = new List<char> {'F', 'M'};
    [Inject] public IAdultService AdultService { get; set; }
    [Inject] public IJobService JobService { get; set; }

    private void AddNewAdult()
    {
        newAdultItem.JobTitle = newAdultJob.JobTitle;
        AdultService.AddAdult(newAdultItem);
        JobService.AddJob(newAdultJob);
        NavigationManager.NavigateTo("/Adults");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
