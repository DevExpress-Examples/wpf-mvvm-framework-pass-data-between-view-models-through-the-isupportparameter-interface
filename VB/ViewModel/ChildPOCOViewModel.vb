Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace Example.ViewModel
    Public Class ChildPOCOViewModel
        Implements ISupportParameter

        <ServiceProperty(SearchMode:=ServiceSearchMode.PreferParents)> _
        Protected Overridable ReadOnly Property MessageBoxService() As IMessageBoxService
            Get
                Return Nothing
            End Get
        End Property
        Public Overridable Property Parameter() As Object Implements ISupportParameter.Parameter

        Protected Overridable Sub OnParameterChanged()
            If TypeOf Parameter Is String Then
                MessageBoxService.Show("ChildPOCOViewModel: Parameter = " & DirectCast(Parameter, String))
            End If
        End Sub
    End Class
End Namespace
