Namespace Example.ViewModel

    Public Class MainViewModel

        Public Overridable Property Parameter1 As String

        Public Overridable Property Parameter2 As String

        Public Sub ChangeParameter1()
            counter1 += 1
            Parameter1 = "Parameter #" & counter1.ToString()
        End Sub

        Public Sub ChangeParameter2()
            counter2 += 1
            Parameter2 = "Parameter #" & counter2.ToString()
        End Sub

        Private counter1 As Integer = 0

        Private counter2 As Integer = 0
    End Class
End Namespace
