'Verweis Microsoft.VisualBasic entfernt
'Helpers Projekt bereitgestellt von ErfinderDesRades
'Projekt zeigt wie die BindingSurce des DataSet auf verschiede Forms umgehängt werden kann
Option Strict On
Option Explicit On


Imports System.IO

Public Class Form1

    Private _kundendaten As New FileInfo("Kundendaten.xml")

    Sub New()
        InitializeComponent()
        Me.AlignOnTop()
        DataSet1.DataFile(_kundendaten.FullName).Register(Me, True).Fill()
    End Sub

    Private Sub KundenEingebenToolStripMenuItem_Click(sender As Object, e As  _
      EventArgs) Handles KundenEingebenToolStripMenuItem.Click
        frmKundenBearbeiten.Show(Me)
    End Sub

    Private Sub cmdFindPhoneNr_Click(sender As Object, e As EventArgs) Handles _
      cmdKundenFinden.Click
        Dim Eingabe = 0
        If Integer.TryParse(txtFrmMainKundennummer.Text, Eingabe) Then
            Dim rwKunde = DataSet1.Kunde.FindByKundennummer(Eingabe)
            If rwKunde.NotNull Then
                lblFrmMainKundenTeleNr.Text = rwKunde.Telefon
                Return
            End If
        End If
        MessageBox.Show("Keine gültige Zahl eingegeben oder Kein Kunden gefunden")
    End Sub

End Class