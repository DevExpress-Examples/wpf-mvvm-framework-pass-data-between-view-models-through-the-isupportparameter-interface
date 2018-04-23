Imports System.Windows

Namespace Example
    Partial Public Class App
        Inherits Application

        Public Sub New()
            AddHandler Startup, AddressOf OnStartup
#If SILVERLIGHT Then
            InitializeComponent()
#End If
        End Sub
        Private Overloads Sub OnStartup(ByVal sender As Object, ByVal e As StartupEventArgs)
#If SILVERLIGHT Then
            Me.RootVisual = New MainPage()
#Else
            MainWindow = New MainWindow()
            MainWindow.Show()
#End If
        End Sub
    End Class
End Namespace
