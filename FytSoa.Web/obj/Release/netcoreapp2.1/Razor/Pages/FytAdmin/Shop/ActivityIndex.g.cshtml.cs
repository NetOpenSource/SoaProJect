#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "322672cd79f7d09f6d885b3d8f61e700748b6e74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_ActivityIndex), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Shop/ActivityIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Shop/ActivityIndex.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_ActivityIndex), null)]
namespace FytSoa.Web.Pages.FytAdmin.Shop
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"322672cd79f7d09f6d885b3d8f61e700748b6e74", @"/Pages/FytAdmin/Shop/ActivityIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Shop_ActivityIndex : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\ActivityIndex.cshtml"
  
    ViewData["Title"] = "活动管理";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(150, 6200, true);
            WriteLiteral(@"<div id=""container"">
    <div class=""list-wall"">
        <div class=""layui-form list-search"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolAdd""><i class=""layui-icon""></i> 新增</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolDel""><i class=""layui-icon""></i> 删除</button>
        </div>
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <div class=""list-wall"">
        <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
    </div>
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common', 'laydate','form'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common
                    , laydate = layui.laydate
                    ,form = layui.form;
                laydate.re");
            WriteLiteral(@"nder({
                    elem: '#times'
                    , theme: '#393D49'
                    , range: true
                });
                var urls = '/api/shops/actlist';
                table.render({
                    elem: '#tablist',
                    url: urls,
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'typeName', title: '活动方式', sort: true, fixed: 'left' },
                            { field: 'methodName', title: '活动类型' },
                            { field: 'countNum', title: '折扣' },
                            { field: 'beginDate', title: '开始时间', sort: true },
                            { field: 'endDate', title: '结束时间' },
                            { field: 'status', title: '活动状态' },
                            { field: 'enable', width: 150, title: '状态', templet: '#switchTpl' },
                            { width: 100, title: '操作', templet: '#tool' ");
            WriteLiteral(@"}
                        ]
                    ],
                    page: true,
                    limit: 15,
                    id: 'tables'
                });
                var guid = '', active = {
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    key: $(""#key"").val(),
                                    time: $(""#times"").val()
                                }
                            });
                    },
                    toolAdd: function () {
                        os.Open('添加活动', '/fytadmin/shop/activitymodify?shop=all', '850px', '450px', function () {
                            active.reload();
                        });
                    },
                    toolDel: function () {
       ");
            WriteLiteral(@"                 var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.error(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/shops/deleteact/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    active.reload();
                    ");
            WriteLiteral(@"                os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });
                    },
                    toolSearch: function () {
                        active.reload();
                    }
                };
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                });
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('编辑活动', '/fytadmin/shop/activitymodify?shop=all&guid=' + data.guid, '850px', '450px', function () {
                            active.reload();
                        });
                    }
              ");
            WriteLiteral(@"  });
                //监听状态操作
                form.on('switch(enableedit)', function (obj) {
                    var index = layer.load(1, {
                        shade: [0.1, '#000']
                    });
                    os.ajax('api/shops/modifyactstatus', { Guid: this.value, Enable: obj.elem.checked }, function (res) {
                        if (res.statusCode === 200) {
                            os.success('状态更改成功~');
                            layer.close(index);
                        } else {
                            os.error(res.message);
                        }
                    });
                });
            });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-primary layui-btn-xs"" lay-event=""edit""><i class=""layui-icon""></i> 修改</a>
    </script>
    <script type=""text/html"" id=""switchTpl"">
        <input type=""checkbox"" name=""enable"" value=""{{d.guid}}"" lay-skin=""switch"" lay-text=""ON|OFF"" lay-filter=""enableedit");
            WriteLiteral("\" {{ d.enable?\'checked\':\'\'}}>\r\n    </script>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Shop.ActivityIndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.ActivityIndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.ActivityIndexModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Shop.ActivityIndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
