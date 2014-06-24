'Verweis Microsoft.VisualBasic entfernt
Option Strict On
Option Explicit On

Imports DateSetBsp.DataSet1
Imports System.IO

Public Class Class1

    Private Sub test()
        DataSet1.Register(Class1, True).Fill()
    End Sub


    'Private Sub cmdLstBstSenden_Click(sender As Object, e As EventArgs)
    '    'Dim KundenBestellung As New Class
    '    'Dim rueckgabe() = KundenBestellung.LetzteBestellungFinden()

    '    Dim rwKunde = DataSet1.Kunde.First
    '    Dim  rwBestellung = GetLastOrder(rwKunde)
    '    Dim kundenName As String = rwBestellung.KundeRow.Name

    '    'Test für HelpersDll
    '    StringX.HasValue("NRW")

    'End Sub
    'Public Function KundenFinden(ByRef Kundennamen As String) As DataRow

    'End Function
    'Private Function GetLastOrder(rwKunde As KundeRow) As DetailsBestellungRow
    '    Return (From rwBest In rwKunde.GetDetailsBestellungRows Order By _
    '      rwBest.Datum).Last
    'End Function
End Class
