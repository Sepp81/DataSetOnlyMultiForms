'Verweis Microsoft.VisualBasic entfernt
Option Strict On
Option Explicit On

Imports DateSetBsp.DataSet1
Imports System.IO

Public Class frmKundenBearbeiten

    Private Sub frmKundenBearbeiten_Load(sender As Object, e As EventArgs) _
      Handles MyBase.Load
        Me.AlignOnTop()
        DataSet1.Register(Me, True)
    End Sub

    '### MenuStrip ###
    Private Sub KundeTelToolStripMenuItem_Click(sender As Object, e As  _
      EventArgs) Handles KundeTelToolStripMenuItem.Click
        Dim s = Microsoft.VisualBasic.InputBox("Kundennr eingeben")
        If s = "" Then Return
        Dim ID = Integer.Parse(s)
        KundeBindingSource.MoveTo(ID)
        Dim gefundenerKunde = DataSet1.Kunde.FindByKundennummer(ID)
        MessageBox.Show(gefundenerKunde.Telefon)
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As  _
      EventArgs) Handles SpeichernToolStripMenuItem.Click
        DataSet1.Save(Me)
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        DataSet1.Save(Me)
        Me.Close()
    End Sub

    '### Funktion um den Kunden Datensatz zu finden ###
    Public Function KundenFinden(ByRef Kundennummer As Integer) As DetailsBestellungRow
        Dim gefundenerKunde = DataSet1.Kunde.FindByKundennummer(Kundennummer)
        Dim gefundenerKundenDatensatz = GetKundenChildRow(gefundenerKunde)
        Return gefundenerKundenDatensatz
    End Function

    Private Function GetKundenChildRow(ByVal rwKunde As KundeRow) As DetailsBestellungRow
        Return (From rwDetails In DataSet1.Kunde.GetDetailsBestellungRows)
    End Function
End Class