'Verweis Microsoft.VisualBasic entfernt
Option Strict On
Option Explicit On

Imports DateSetBsp.DataSet1
Imports System.IO

Public Class frmKundenBearbeiten

    Private _kundendaten As New FileInfo("Kundendaten.xml")

    Private Sub frmKundenBearbeiten_Load(sender As Object, e As EventArgs) _
      Handles MyBase.Load
        Me.AlignOnTop()
        DataSet1.Register(Me, True).Fill()
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As  _
      EventArgs) Handles SpeichernToolStripMenuItem.Click
        DataSet1.Save(Me)
    End Sub

    Private Sub KundeTelToolStripMenuItem_Click(sender As Object, e As  _
      EventArgs) Handles KundeTelToolStripMenuItem.Click
        Dim s = Microsoft.VisualBasic.InputBox("Kundennr eingeben")
        If s = "" Then Return
        Dim ID = Integer.Parse(s)
        KundeBindingSource.MoveTo(ID)
        Dim gefundenerKunde = DataSet1.Kunde.FindByKundennummer(ID)
        MessageBox.Show(gefundenerKunde.Telefon)
    End Sub

    Public Function KundenFinden(ByRef Kundennummer As Integer) As KundeRow
        Dim gefundenerKunde = DataSet1.Kunde.FindByKundennummer(Kundennummer)
        Return gefundenerKunde
    End Function

End Class

'Imports System.IO
'Imports System.Reflection
'Imports DateSetBsp.DataSet1

'Public Class frmKundenBearbeiten

'    Private _kundendaten As New FileInfo("Kundendaten.xml")

'    Private Sub frmKundenBearbeiten_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Dim Bildschirm As Screen = Screen.PrimaryScreen
'        Location = New Point(Bildschirm.Bounds.Left + (Bildschirm.Bounds.Width - Width) \ 2, Bildschirm.Bounds.Top)
'        KundendatenLaden()
'    End Sub

'    '##### MenuStrip #####
'    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
'        Speichern()
'        Me.Close()
'    End Sub

'    Private Sub frmKundenBearbeiten_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
'        Speichern()
'    End Sub

'    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernToolStripMenuItem.Click
'        Speichern()
'    End Sub
'    '##### MenuStrip #####

'    Private Sub Speichern()
'        Me.Validate()
'        Me.DataSet1.AcceptChanges()
'        If _kundendaten.Exists Then
'            _kundendaten.Delete()
'        End If
'        Me.DataSet1.WriteXml(_kundendaten.FullName)
'    End Sub

'    Private Sub KundendatenLaden()
'        If _kundendaten.Exists Then
'            Me.DataSet1.ReadXml(_kundendaten.FullName)
'        Else
'            MessageBox.Show("Ich finde dein XML File nicht")
'        End If
'    End Sub

'    '### Testweise Methoden in der Form ###
'    'Im zweiten Schritt Funktionen in die Class1 auslagern
'    Public Function KundenFinden(ByRef Kundennummer As Integer) As KundeRow
'        Dim gefundenerKunde = DataSet1.Kunde.FindByKundennummer(Kundennummer)
'        Return gefundenerKunde
'    End Function

'    'Überprüfung der Funktionalität (in dieser Form wird die Telefonnummer ausgegeben)
'    Public Sub Prüfung()
'        Dim ausgabe = KundenFinden(1)
'        Dim teKundenName = ausgabe.Telefon
'    End Sub
'End Class