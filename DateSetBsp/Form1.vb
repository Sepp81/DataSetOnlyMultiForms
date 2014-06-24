'Verweis Microsoft.VisualBasic entfernt
'Helpers Projekt bereitgestellt von ErfinderDesRades
'Projekt zeigt wie die BindingSurce des DataSet auf verschiede Forms umgehängt werden kann
Option Strict On
Option Explicit On

Imports System.IO
Imports System.Reflection
Imports System.Math

Public Class Form1

    Private _kundendaten As New FileInfo("Kundendaten.xml")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Bildschirm As Screen = Screen.PrimaryScreen
        Location = New Point(Bildschirm.Bounds.Left + (Bildschirm.Bounds.Width - Width) \ 2, Bildschirm.Bounds.Top)

        DataSet1.DataFile(_kundendaten.FullName).Register(Me, True).Fill()

    End Sub

    '### MenuStrip ###
    Private Sub KundenEingebenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KundenEingebenToolStripMenuItem.Click
        Dim KundenBearbeiten As New frmKundenBearbeiten
        If KundenBearbeiten Is Nothing OrElse frmKundenBearbeiten.IsDisposed Then
            KundenBearbeiten = New frmKundenBearbeiten
        End If
        If Not KundenBearbeiten.Visible Then
            KundenBearbeiten.Show(Me)
        End If
        If KundenBearbeiten.WindowState = FormWindowState.Minimized Then
            KundenBearbeiten.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    '### Hauptfunktionalität ###
    Private Sub cmdFindPhoneNr_Click(sender As Object, e As EventArgs) Handles cmdKundenFinden.Click
        Dim FindeDenKunden As New frmKundenBearbeiten
        Dim Eingabe As Integer
        Try
            Eingabe = Convert.ToInt32(txtFrmMainKundennummer.Text)
        Catch ex As Exception
            Eingabe = Nothing
        End Try

        If Eingabe = Nothing Then
            MessageBox.Show("Keine gültige Zahl eingegeben")
        End If
        Dim gefundenKunden = FindeDenKunden.KundenFinden(Eingabe)
        If gefundenKunden Is Nothing Then
            MessageBox.Show("Kein Kunden gefunden")
        Else
            lblFrmMainKundenTeleNr.Text = gefundenKunden.KundeRow.Name
        End If
    End Sub
End Class