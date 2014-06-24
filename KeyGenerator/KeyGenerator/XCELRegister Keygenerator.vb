Imports System.Management

Public Class Form1

    Private Sub cmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        Try
            Dim keyGenerator As New KeyGenerator
            If txtSerial.Text <> "" Then
                lblActivationKey.Text = keyGenerator.GenerateKey(txtSerial.Text)
            End If
        Catch ex As Exception
            lblActivationKey.Text = "Serial Contains Numbers Only"
        End Try
        

    End Sub

    Private Sub cmdGetSerial_Click(sender As Object, e As EventArgs) Handles cmdGetSerial.Click
        txtSerial.Text = GetSerial()
    End Sub

    Public Function GetSerial() As Long
        Try
            Dim mc As New ManagementClass("Win32_NetworkAdapterConfiguration")
            Dim mac As String = ""
            'Getting network adapters collection
            Dim moc As ManagementObjectCollection = mc.GetInstances

            'Here we iterate over available network adapters, 
            'picking the first possible one
            For Each mo As ManagementObject In moc
                If mo.Item("IPEnabled") Then
                    mac = mo.Item("MacAddress").ToString
                    Exit For
                End If
            Next

            mc.Dispose()

            'This is a simple function that we use to get a serial out
            'of our MAC address. Say that x is the MAC and y is the serial,
            'the function would be y += x[i] + (i * 2) where i is the index
            'of MAC address element.
            Dim sum As Long = 0
            Dim index As Integer = 1
            For Each ch As Char In mac
                If Char.IsDigit(ch) Then
                    sum += sum + Integer.Parse(ch) * (index * 2)
                ElseIf Char.IsLetter(ch) Then
                    Select Case ch.ToString.ToUpper
                        Case "A"
                            sum += sum + 10 * (index * 2)
                        Case "B"
                            sum += sum + 11 * (index * 2)
                        Case "C"
                            sum += sum + 12 * (index * 2)
                        Case "D"
                            sum += sum + 13 * (index * 2)
                        Case "E"
                            sum += sum + 14 * (index * 2)
                        Case "F"
                            sum += sum + 15 * (index * 2)
                    End Select
                End If

                index += 1
            Next

            Return sum
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return 0
        End Try
        
    End Function

    Public Class KeyGenerator
        Public Function GenerateKey(ByVal serial As Long) As Long
            Try
                Dim x As Long = serial
                Return x * x + 53 / x + 113 * (x / 4)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return 0
            End Try
        End Function
    End Class

   
End Class
