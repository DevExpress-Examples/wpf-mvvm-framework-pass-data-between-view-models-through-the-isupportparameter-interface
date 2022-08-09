Imports System.Windows

Namespace Example

    Public Partial Class App
        Inherits Application

        Public Sub New()
            AddHandler Startup, AddressOf OnStartup
#If SILVERLIGHT
            InitializeComponent();
#End If
        End Sub

        Private Overloads Sub OnStartup(ByVal sender As Object, ByVal e As StartupEventArgs)
#If SILVERLIGHT
            this.RootVisual = new MainPage();
#Else
            MainWindow = New MainWindow()
            MainWindow.Show()
#End If
        End Sub
    End Class
End Namespace
