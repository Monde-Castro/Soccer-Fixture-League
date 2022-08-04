Public Class FrmFirstLeague

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close and exit the program
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all controls
        txtBrazilMatch1.Clear()
        txtBrazilMatch2.Clear()
        txtItalyMatch1.Clear()
        txtItalyMatch2.Clear()
        txtEnglandMatch1.Clear()
        txtEnglandMatch2.Clear()

        lblBrazilTotal.Text = ""
        lblItalyTotal.Text = ""
        lblEnglandTotal.Text = ""
        lblWinner.Text = ""

        txtBrazilMatch1.Focus()


    End Sub

    Private Sub btnCalcWiinner_Click(sender As Object, e As EventArgs) Handles btnCalcWiinner.Click
        'Calculate totals and determine the winning team
        'Declare variables
        Dim intBazilMatch1 As Integer = 0
        Dim intBazilMatch2 As Integer = 0
        Dim intItalyMatch1 As Integer = 0
        Dim intItalyMatch2 As Integer = 0
        Dim intEnglandMatch1 As Integer = 0
        Dim intEnglandMatch2 As Integer = 0
        Dim intBazilTotal As Integer = 0
        Dim intItalyTotal As Integer = 0
        Dim intEnglandTotal As Integer = 0

        Dim strWinnner As String = ""

        'Input 
        intBazilMatch1 = CInt(txtBrazilMatch1.Text)
        intBazilMatch2 = CInt(txtBrazilMatch2.Text)
        intItalyMatch1 = CInt(txtItalyMatch1.Text)
        intItalyMatch2 = CInt(txtItalyMatch2.Text)
        intEnglandMatch1 = CInt(txtEnglandMatch1.Text)
        intEnglandMatch2 = CInt(txtEnglandMatch2.Text)

        'Processing data
        'Calculate total points for each team
        intBazilTotal = intBazilMatch1 + intBazilMatch2
        intItalyTotal = intItalyMatch1 + intItalyMatch2
        intEnglandTotal = intEnglandMatch1 + intEnglandMatch2

        'Determine the winning team
        If intBazilTotal > intItalyTotal Then
            If intBazilTotal > intEnglandTotal Then
                strWinnner = "Brazil"
            Else
                strWinnner = "England"
            End If
        Else
            If intItalyTotal > intEnglandTotal Then
                strWinnner = "Italy"
            Else
                strWinnner = "England"
            End If
        End If

        'Output
        'Display total points for each team
        lblBrazilTotal.Text = intBazilTotal.ToString
        lblItalyTotal.Text = intItalyTotal.ToString
        lblEnglandTotal.Text = intEnglandTotal.ToString

        'Display the winning team
        lblWinner.Text = "The winning team is " & strWinnner
    End Sub
End Class
