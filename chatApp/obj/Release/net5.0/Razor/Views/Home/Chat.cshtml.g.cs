#pragma checksum "C:\Users\User\RiderProjects\chatApp\chatApp\Views\Home\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "974d20c6d257b7c3afe22ac22cb33536549ec344"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chat), @"mvc.1.0.view", @"/Views/Home/Chat.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\RiderProjects\chatApp\chatApp\Views\_ViewImports.cshtml"
using chatApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\chatApp\chatApp\Views\_ViewImports.cshtml"
using chatApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\chatApp\chatApp\Views\Home\Chat.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"974d20c6d257b7c3afe22ac22cb33536549ec344", @"/Views/Home/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"547fc39f7234b2d20a5c2cb6f8f71474e284b27a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SignalR/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SignalR/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("please-scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\User\RiderProjects\chatApp\chatApp\Views\Home\Chat.cshtml"
  
    Layout = null;
    string adsoyad = @HttpContextAccessor.HttpContext.Session.GetString("username");
    string userid = @HttpContextAccessor.HttpContext.Session.GetString("userid");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974d20c6d257b7c3afe22ac22cb33536549ec3446039", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    <title>title</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "974d20c6d257b7c3afe22ac22cb33536549ec3446364", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;1,100;1,300;1,400&display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-gtEjrD/SeCtmISkJkNUaaKMoLD0//ElJ19smozuHV6z3Iehds+3Ulb9Bn9Plx0x4"" crossorigin=""anonymous""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974d20c6d257b7c3afe22ac22cb33536549ec3448314", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974d20c6d257b7c3afe22ac22cb33536549ec3449413", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974d20c6d257b7c3afe22ac22cb33536549ec34410512", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        const connection = new signalR.HubConnectionBuilder().withUrl(""http://www.memin-chatapp.somee.com/myhub"").build();
        // const connection = new signalR.HubConnectionBuilder().withUrl(""https://localhost:5001/myhub"").build();
        connection.start();
        
        function chatlist() {
                    url = '/Home/ChatList/';
                    $.getJSON(url, function (data){
                        data.forEach(item => {
                            let getir = `<div class=""col-md-1 p-1 imlec"" id=""chatgetir"" data-id=""${item.chatid}"">#${item.chatismi}</div>`;
                            $(""#chatlist"").append(getir);
                        })
                    })
        }
        let geciciChatId;
        let ensonid; 
        let getiryorum;
        $(document).on(""click"", ""#chatgetir"", async function () {
              let id = $(this).data(""id"").toString();
              connection.invoke(""LeaveToGroup"", geciciChatId).catch(error => console.log(`HAT");
                WriteLiteral(@"A OLUŞTU ${error}`));
              geciciChatId = id;
              connection.invoke(""AddToGroup"", geciciChatId).catch(error => console.log(`HATA OLUŞTU ${error}`));
              $(""#myDiv"").html("""");
              url = '/Home/YorumList/' + id;
              ensonid = """";
              $.getJSON(url, function (data){
                  data.forEach(item => {
                      if (ensonid == item.userid)
                      {
                          getiryorum = `<div style=""margin-left: 48px;color: rgb(187, 187, 187);"">
                                              <span>${item.yorums}</span><br>
                                        </div>`; 
                          ensonid = item.userid;
                      }
                      else{
                          getiryorum = `<div class=""mt-3"">
                                            <img src=""https://www.freepnglogos.com/uploads/discord-logo-png/discord-logo-logodownload-download-logotipos-1.png""
                     ");
                WriteLiteral(@"                         alt=""..."" class=""rounded-circle"" style=""width: 40px;height: 40px;"">
                                            <span class=""p-1"">${item.adsoyad}</span><span style=""color: #6b6c6d;font-size: 12px;"">bugün saat xx</span>
                                            <div style=""margin-left: 48px;color: rgb(187, 187, 187);"">
                                                  <span>${item.yorums}</span><br>
                                            </div>
                                        </div>`; 
                          ensonid = item.userid;
                      }
                                  
                      $(""#myDiv"").append(getiryorum);
                      $(window).scrollTop($(document).height()); 
                  })
                 
              })
              console.log(""chatten gelen en son: "" + ensonid);
               
        });
        
        $(document).ready(() => {
            <!-- connection --> 
            
         ");
                WriteLiteral("   \r\n            chatlist();\r\n\r\n            <!-- tanimlar --> \r\n                    \r\n            const adisoyadi = \"");
#nullable restore
#line 89 "C:\Users\User\RiderProjects\chatApp\chatApp\Views\Home\Chat.cshtml"
                          Write(adsoyad);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n            const useridsi = \"");
#nullable restore
#line 90 "C:\Users\User\RiderProjects\chatApp\chatApp\Views\Home\Chat.cshtml"
                         Write(userid);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
            

            <!-- mesaj invoke --> 
            $(""#message"").keyup(function(e){
                if(e.keyCode == 13)
                {
                    let message = $(""#message"").val();
                    if ($(""#message"").val() != """"){
                        connection.invoke(""SendMessageAsync"", adisoyadi, useridsi, message, geciciChatId).catch(error => console.log(`HATA OLUŞTU ${error}`));
                        $(""#message"").val("""");                                                         
                                    $.ajax({
                                        url: '/Home/EkleJson/',
                                        type: 'Post',
                                        dataType: 'json',
                                        data: { yorums: message, chatid: geciciChatId, userid:useridsi, adsoyad:adisoyadi},
                                        success: function (data) {
                                            //console.log(data);
        ");
                WriteLiteral(@"                                },
                                        error: function (result) {
                                            alert(""Something wrong"");
                                        }
                                    })
                    }             
                }
            });

            <!-- mesaj --> 
            connection.on(""receiveMessage"",(adisoyadi, userid, message) => {    
                 var dt = new Date();
                 var time = dt.getHours() + "":"" + dt.getMinutes();
                 if(ensonid==userid){     
                     console.log(""Enson id "" + ensonid + ""User id "" + userid);
                     $(""#myDiv"").append(`<div style=""margin-left: 48px;color: rgb(187, 187, 187);"">
                                          <span>${message}</span><br>
                                         </div>`);
                     $(document).scrollTop($(document).height());  
                     ensonid = userid;
                 ");
                WriteLiteral(@"}
                 else{
                     console.log(""Enson id "" + ensonid + ""User id "" + userid);
                     $(""#myDiv"").append(`<div class=""mt-3"">
                                           <img src=""https://www.freepnglogos.com/uploads/discord-logo-png/discord-logo-logodownload-download-logotipos-1.png""
                                           alt=""..."" class=""rounded-circle"" style=""width: 40px;height: 40px;"">
                                           <span class=""p-1"">${adisoyadi}</span><span style=""color: #6b6c6d;font-size: 12px;"">bugün saat ${time}</span>
                                           <div style=""margin-left: 48px;color: rgb(187, 187, 187);"">
                                              <span>${message}</span><br>
                                           </div>
                                         </div>`);
                     $(document).scrollTop($(document).height());  
                     ensonid = userid;                
                 }
     ");
                WriteLiteral("       });\r\n            \r\n            \r\n        });\r\n        \r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974d20c6d257b7c3afe22ac22cb33536549ec34419479", async() => {
                WriteLiteral(@"

<div class=""container-fluid"" style=""background-color: #23272a;"">
    <div class=""row"">
        
        <div class=""col-md-2"" style=""color:rgb(192, 192, 192);height: 100vh;"">

            <div class=""container-fluid position-fixed p-4 mt-2"" id=""chatlist"">
            </div>

        </div>

        <div class=""col-md-10 d-flex"" style=""background-color:#2c2f33;"">

            <div class=""col-md-12 p-3"" style=""color: white;margin-bottom: 3.5rem;"" id=""myDiv"">
                <!-- mesajlar buraya gelecek -->
            </div>

            <div class=""col position-fixed"" style=""background-color:#2c2f33;bottom: 0;width: 78%;height: 50px;margin-left: 14px;"">
                <div class=""col"" style=""background-color:#45494e;border-radius: 10px;height: 40px;"">
                    <input type=""text"" class=""inputbox"" placeholder=""mesaj gönder"" id=""message"">
                </div>
            </div>

        </div>
    </div>

</div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<style>\r\n  \r\n</style>\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591