﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports CS.Models
Namespace CS.Controllers


	Public Class HomeController
		Inherits Controller

		<AcceptVerbs(HttpVerbs.Get)>
		Public Function Index() As ActionResult
			Return View(New Customer With {.ID = 0, .Name = "John", .Country = 2, .City = 2})
		End Function
		Public Function CountryPartial() As ActionResult
			Return PartialView(New Customer())
		End Function
		Public Function CityPartial() As ActionResult
			Dim countryParam As Integer = If(Request.Params("Country") IsNot Nothing, Integer.Parse(Request.Params("Country")), -1)
			Return PartialView(New Customer With {.Country = countryParam})
		End Function
		<AcceptVerbs(HttpVerbs.Post)>
		Public Function Index(<ModelBinder(GetType(DevExpressEditorsBinder))> ByVal customer As Customer) As ActionResult
			If ModelState.IsValid Then
				'post customer to database
				Return RedirectToAction("Success")
			Else
				Return View(customer)
			End If
		End Function
		Public Function Success() As ActionResult
			Return View()
		End Function
	End Class
End Namespace