#pragma checksum "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a51174c5808a7e64b67c99888e3e18e4066612f1"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication2.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\_Imports.razor"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"bg-info text-white text-center p-1\">Detaylar</h3>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-bordered table-striped");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<th>ID</th>");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 5 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\Details.razor"
                            Product.ProductID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "<th>Ürün</th>");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 6 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\Details.razor"
                              Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "<th>Açıklama</th>");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 7 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\Details.razor"
                                  Product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "<th>Kategori</th>");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 8 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\Details.razor"
                                  Product.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "<th>Fiyat</th>");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 9 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\Details.razor"
                               Product.Price.ToString("C")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "<th>Ana Kategori</th>");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 10 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\Details.razor"
                                      Product.MainCategory

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "<th>Görsel</th>");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 11 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\Details.razor"
                                Product.ImgPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
            __builder.AddAttribute(44, "class", "btn btn-warning");
            __builder.AddAttribute(45, "href", 
#nullable restore
#line 14 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\Details.razor"
                                        EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "<i class=\"fa fa-edit\"></i>&nbsp;Düzenle");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(49);
            __builder.AddAttribute(50, "class", "btn btn-secondary");
            __builder.AddAttribute(51, "href", "/admin/products");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(53, "<i class=\"fas fa-arrow-left\"></i>&nbsp;Geri");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n<div style=\"margin-bottom: 500px;\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\serkan\Desktop\Web Programlama  Final Ödevi - 172119010 - 172119015\Web Programalama Proje\WebApplication2\Pages\Admin\Details.razor"
       
    [Inject]
    public IStoreRepository Repository { get; set; }
    [Parameter]
    public long Id { get; set; }
    public Product Product { get; set; }
    protected override void OnParametersSet()
    {
        Product = Repository.Products.FirstOrDefault(p => p.ProductID == Id);
    }
    public string EditUrl => $"/admin/products/edit/{Product.ProductID}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
