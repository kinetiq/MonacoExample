#pragma checksum "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e0ecd30c364c93985b65a9c5becf3c55ec43519"
// <auto-generated/>
#pragma warning disable 1591
namespace Monaco.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\_Imports.razor"
using Monaco.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\_Imports.razor"
using Monaco.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\_Imports.razor"
using BlazorMonaco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\_Imports.razor"
using BlazorMonaco.Bridge;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Code Editor</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "margin:10px 0;");
            __builder.AddMarkupContent(4, "\r\n        Theme:\r\n        ");
            __builder.OpenElement(5, "select");
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\Pages\Index.razor"
                           ChangeTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", "vs");
            __builder.AddContent(9, "Visual Studio");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", "vs-dark");
            __builder.AddContent(13, "Visual Studio Dark");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", "hc-black");
            __builder.AddContent(17, "High Contrast Black");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "margin:10px 0;");
            __builder.AddMarkupContent(21, "\r\n        New Value: ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "style", "width: 400px;");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\Pages\Index.razor"
                                             ValueToSet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ValueToSet = __value, ValueToSet));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(27, " ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\Pages\Index.razor"
                                                                                                    SetValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Set Value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "style", "margin:10px 0;");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\Pages\Index.razor"
                          GetValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Get Value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "style", "margin:10px 0;");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\Pages\Index.razor"
                          AddCommand

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Add Command (Ctrl+Enter)");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "style", "margin:10px 0;");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\Pages\Index.razor"
                          AddAction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(48, "Add Action (Ctrl+D)");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.AddMarkupContent(50, "<div style=\"margin:10px 0;\">\r\n        See the console for results.\r\n    </div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n");
            __builder.OpenComponent<BlazorMonaco.MonacoEditor>(52);
            __builder.AddAttribute(53, "Id", "sample-code-editor-123");
            __builder.AddAttribute(54, "ConstructionOptions", new System.Func<BlazorMonaco.MonacoEditor, BlazorMonaco.Bridge.StandaloneEditorConstructionOptions>(
#nullable restore
#line 31 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\Pages\Index.razor"
                                                                              EditorConstructionOptions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "OnDidInit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorMonaco.MonacoEditorBase>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorMonaco.MonacoEditorBase>(this, 
#nullable restore
#line 31 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\Pages\Index.razor"
                                                                                                                    EditorOnDidInit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(56, "OnContextMenu", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorMonaco.Bridge.EditorMouseEvent>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorMonaco.Bridge.EditorMouseEvent>(this, 
#nullable restore
#line 31 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\Pages\Index.razor"
                                                                                                                                                    OnContextMenu

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(57, (__value) => {
#nullable restore
#line 31 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\Pages\Index.razor"
                    _editor = (BlazorMonaco.MonacoEditor)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\Dev\MonacoExample\Monaco.Blazor\Monaco.Blazor\Pages\Index.razor"
       
    private MonacoEditor _editor { get; set; }
    private string ValueToSet { get; set; }

    private StandaloneEditorConstructionOptions EditorConstructionOptions(MonacoEditor editor)
    {
        return new StandaloneEditorConstructionOptions
        {
            Language = "javascript",
            GlyphMargin = true,
            Value = "\"use strict\";\n" +
                    "function Person(age) {\n" +
                    "	if (age) {\n" +
                    "		this.age = age;\n" +
                    "	}\n" +
                    "}\n" +
                    "Person.prototype.getAge = function () {\n" +
                    "	return this.age;\n" +
                    "};\n"
        };
    }

    private async Task EditorOnDidInit(MonacoEditorBase editor)
    {
        await _editor.AddCommand((int)KeyMode.CtrlCmd | (int)KeyCode.KEY_H, (editor, keyCode) =>
        {
            Console.WriteLine("Ctrl+H : Initial editor command is triggered.");
        });

        var newDecorations = new ModelDeltaDecoration[]
        {
            new ModelDeltaDecoration
            {
                Range = new BlazorMonaco.Bridge.Range(3,1,3,1),
                Options = new ModelDecorationOptions
                {
                    IsWholeLine = true,
                    ClassName = "decorationContentClass",
                    GlyphMarginClassName = "decorationGlyphMarginClass"
                }
            }
            };

        decorationIds = await _editor.DeltaDecorations(null, newDecorations);
        // You can now use 'decorationIds' to change or remove the decorations
    }

    private string[] decorationIds;

    private void OnContextMenu(EditorMouseEvent eventArg)
    {
        Console.WriteLine("OnContextMenu : " + System.Text.Json.JsonSerializer.Serialize(eventArg));
    }

    private async Task ChangeTheme(ChangeEventArgs e)
    {
        Console.WriteLine($"setting theme to: {e.Value.ToString()}");
        await MonacoEditor.SetTheme(e.Value.ToString());
    }

    private async Task SetValue()
    {
        Console.WriteLine($"setting value to: {ValueToSet}");
        await _editor.SetValue(ValueToSet);
    }

    private async Task GetValue()
    {
        var val = await _editor.GetValue();
        Console.WriteLine($"value is: {val}");
    }

    private async Task AddCommand()
    {
        await _editor.AddCommand((int)KeyMode.CtrlCmd | (int)KeyCode.Enter, (editor, keyCode) =>
        {
            Console.WriteLine("Ctrl+Enter : Editor command is triggered.");
        });
    }

    private async Task AddAction()
    {
        await _editor.AddAction("testAction", "Test Action", new int[] { (int)KeyMode.CtrlCmd | (int)KeyCode.KEY_D, (int)KeyMode.CtrlCmd | (int)KeyCode.KEY_B }, null, null, "navigation", 1.5, (editor, keyCodes) =>
        {
            Console.WriteLine("Ctrl+D : Editor action is triggered.");
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
