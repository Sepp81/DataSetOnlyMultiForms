'Verweis Microsoft.VisualBasic entfernt
Option Strict On
Option Explicit On

Imports DateSetBsp.DataSet1
Imports System.IO

Public Class frmKundenBearbeiten

    Sub New()
        InitializeComponent()
        Me.AlignOnTop()
        DataSet1.Register(Me, False)
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
    End Sub

End Class