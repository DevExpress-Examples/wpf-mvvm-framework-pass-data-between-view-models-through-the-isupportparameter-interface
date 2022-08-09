Imports DevExpress.Mvvm

Namespace Example.ViewModel

    Public Class ChildViewModelBase
        Inherits ViewModelBase

        Private ReadOnly Property MessageBoxService As IMessageBoxService
            Get
                Return GetService(Of IMessageBoxService)(ServiceSearchMode.PreferParents)
            End Get
        End Property

        Protected Overrides Sub OnParameterChanged(ByVal parameter As Object)
            MyBase.OnParameterChanged(parameter)
            If TypeOf parameter Is String Then MessageBoxService.Show("ChildViewModelBase: Parameter = " & CStr(parameter))
        End Sub
    End Class
End Namespace
