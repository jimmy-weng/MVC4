#pragma checksum "D:\小專案\WebApplication1\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc9ef1588df128727908b7d43728f6a13ee7cc03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "D:\小專案\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\小專案\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc9ef1588df128727908b7d43728f6a13ee7cc03", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\小專案\WebApplication1\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "D:\小專案\WebApplication1\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<input  id=""search-input"">

<div id='test'></div>
<div id=""div1"">
    <table>
        <tr>
            <td>遊戲編號</td>
            <td>遊戲名稱</td>
            <td>遊戲種類</td>
            <td>單價</td>

        </tr>
        <tbody id=""row"">
        </tbody>

    </table>
</div>
<div id='test'></div>
");
            WriteLiteral(@"
<script>



   
    //if (input!= null) {
    //    $('#search-input').keyup(function () {
    //        data1 = {'search': input }
    //        req(data1)
    //    });

    //}
    /*else {*/

        $returntrue = req();

        if ($returntrue) {

            setInterval(function () { req(); }, 1000);  //預設10000毫秒自動重複執行cartnumber()函數
        }
        function req() {
            var input = $(""#search-input"").val();
          
                if (input=="""") {
                    $.ajax({
                        type: 'get',
                        url: 'http://localhost:38261/Api/api/index',
                        success: function (info) {
                           

                            total_len = info.length;
                            $(""#row"").empty();

                            for (i = 0; i < total_len; i++) {
                                $(""#row"").append(

                                    ""<tr>"" +
                                    ""<td");
            WriteLiteral(@">"" + info[i].game_number + ""</td>"" +
                                    ""<td >"" + info[i].game_name + ""</td>"" +
                                    ""<td>"" + info[i].game_category + ""</td>"" +
                                    ""<td>"" + info[i].unit_price + ""</td>"" +
                                    ""</tr>""
                                );
                            }


                        },
                        error: function () {
                            console.log('请求失败~');
                        }

                    });
                }
                else {
                    $('#search-input').keyup(function () {
                        if (input!="""") {
                            var obj = { ""name"": $(""#search-input"").val() }
                            console.log(obj)
                            $.ajax({
                                type: 'POST',
                                datatype: ""JSON"",
                                traditional: true,
  ");
            WriteLiteral(@"                              url: ""http://localhost:38261/Api/api/index"",
                                contentType: 'application/json',
                                data: JSON.stringify(obj),
                                success: function (info) {
                                  

                                    total_len = info.length;
                                    $(""#row"").empty();

                                    for (i = 0; i < total_len; i++) {
                                        $(""#row"").append(

                                            ""<tr>"" +
                                            ""<td>"" + info[i].game_number + ""</td>"" +
                                            ""<td >"" + info[i].game_name + ""</td>"" +
                                            ""<td>"" + info[i].game_category + ""</td>"" +
                                            ""<td>"" + info[i].unit_price + ""</td>"" +
                                            ""</tr>""
                     ");
            WriteLiteral(@"                   );
                                    }


                                },
                            })
                        }
                    })
                }
                return true
            
        }
    /*}*/
    //$('#search-input').keyup(function () {
    //    var input = $(""#search-input"").val();
    //    if (input!='') {

    //        $('#row').css(""display"", ""none"");
    //        $('#row').find(""td:contains('"" + input + ""')"").parent().css(""display"", ""block"");

    //    }
    //    else {

    //        $('#row').css(""display"", ""block"");
    //    }

    //})
    //$('#search').keyup(function () {
    //    var searchword = $('#search').val();
    //    if (searchword !== '') {
    //        $('.info').css(""display"", ""none"");
    //        $('.info').find("":contains('"" + searchword + ""')"").parent().css(""display"", ""block"");
    //    } else {
    //        $('.info').css(""display"", ""block"");
    //    }
    //});
  

");
            WriteLiteral("\r\n\r\n</script>");
        }
        #pragma warning restore 1998
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
