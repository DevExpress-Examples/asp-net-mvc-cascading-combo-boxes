@ModelType CS.Models.Customer

@Html.DevExpress().ComboBox( _
    Sub(settings)
        settings.Name = "Country"
        settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "CountryPartial"}
        settings.Properties.ValueType = GetType(System.Int32)
        settings.Properties.TextField = "Name"
        settings.Properties.ValueField = "ID"
        settings.Properties.CallbackPageSize = 20
        settings.Properties.ClientSideEvents.SelectedIndexChanged = "function(s, e) { City.PerformCallback(); }"
    End Sub).BindList(CS.Models.Country.GetCountries()).Bind(Model.Country).GetHtml()  