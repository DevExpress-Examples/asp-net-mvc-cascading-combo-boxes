<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128549360/11.2.10%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2844)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DevExpressMvc3CascadingCombo/Controllers/HomeController.cs)
* [Customer.cs](./CS/DevExpressMvc3CascadingCombo/Models/Customer.cs)
* [CityPartial.cshtml](./CS/DevExpressMvc3CascadingCombo/Views/Home/CityPartial.cshtml)
* [CountryPartial.cshtml](./CS/DevExpressMvc3CascadingCombo/Views/Home/CountryPartial.cshtml)
* [Index.cshtml](./CS/DevExpressMvc3CascadingCombo/Views/Home/Index.cshtml)
* [success.cshtml](./CS/DevExpressMvc3CascadingCombo/Views/Home/success.cshtml)
<!-- default file list end -->
# MVC ComboBox Extension - Cascading Combo Boxes


<p>This example illustrates how to implement cascading combo boxes scenario within the MVC ComboBox Extension.<br /> It is an illustration of the <a href="https://www.devexpress.com/Support/Center/p/KA18675">KA18675: MVC ComboBox Extension - How to implement cascaded combo boxes</a> KB Article. Refer to the Article for an explanation.<br /><br />The "Cascading Combo Boxes" scenario assumes the following steps:<br />- Perform a callback of the ComboBox to be reloaded via the client-side <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientComboBox_PerformCallbacktopic">ASPxClientComboBox.PerformCallback</a> method;<br />- Pass the required data for filtering (for example, another ComboBox's value) via the <a href="https://documentation.devexpress.com/#AspNet/CustomDocument9941">Passing Values to a Controller Action through Callbacks</a> technique;<br />- Handle the Action method (specified via the ComboBoxSettings.CallbackRouteValues.Action property) of the ComboBox to be reloaded, retrieve the related Model data based on the passed filters, and pass this Model to the rendered PartialView.<br /><br />The example contains the following solutions:</p>
<p>- The solution for v2011 vol 2.10+ builds - MVC3 / Razor View Engine<br />- The solution for v2010 vol 2 - v2011 vol 2 builds - MVC2 / ASPx View Engine (obsolete)</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-cascading-combo-boxes&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-cascading-combo-boxes&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
