<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1777)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/HighlightMathcedSample/Form1.cs) (VB: [Form1.vb](./VB/HighlightMathcedSample/Form1.vb))
<!-- default file list end -->
# (Obsolete) How to highlight a text fragment in an editor


<p>This example demonstrates how to use the internal mechanism intended to support the Incremental Search functionality, to highlight a portion of text in the editor, when the TextEditStyle property is set to TextEditStyles.DisableTextEditor, and its MaskBox is unavailable. This approach will work properly with all ButtonEdit descendants, except for editors derived from the PopupBaseAutoSearchEdit.</p>


<h3>Description</h3>

<p>The highlighting feature can be enabled by applying some text to the BaseEditViewInfo.MatchedString property. If this string matches some portion of text in the editor, this portion will be highlighted. The BaseEdit.ViewInfo property is protected. To access it, you should use Reflection. However, it&#39;s possible to inherit from an appropriate editor, and implement this functionality in a descendant class. See the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument4716">Custom Editors</a> help topic to learn how to correctly create a custom editor.</p><p>Note: this sample uses our internal methods, which can be changed in the future. Please use this approach carefully.</p>

<br/>


