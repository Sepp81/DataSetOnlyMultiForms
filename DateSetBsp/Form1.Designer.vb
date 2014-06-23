<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.KundeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New DateSetBsp.DataSet1()
        Me.KundeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetailsBestellungBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KundeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KundenEingebenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtFrmMainKundennummer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdFindPhoneNr = New System.Windows.Forms.Button()
        Me.lblFrmMainKundenTeleNr = New System.Windows.Forms.Label()
        CType(Me.KundeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KundeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsBestellungBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KundeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KundeBindingSource
        '
        Me.KundeBindingSource.DataMember = "Kunde"
        Me.KundeBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KundeBindingSource2
        '
        Me.KundeBindingSource2.DataMember = "Kunde"
        Me.KundeBindingSource2.DataSource = Me.DataSet1
        '
        'DetailsBestellungBindingSource
        '
        Me.DetailsBestellungBindingSource.DataMember = "FK_Kunde_DetailsBestellung"
        Me.DetailsBestellungBindingSource.DataSource = Me.KundeBindingSource
        '
        'KundeBindingSource1
        '
        Me.KundeBindingSource1.DataMember = "Kunde"
        Me.KundeBindingSource1.DataSource = Me.DataSet1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KundenEingebenToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'KundenEingebenToolStripMenuItem
        '
        Me.KundenEingebenToolStripMenuItem.Name = "KundenEingebenToolStripMenuItem"
        Me.KundenEingebenToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.KundenEingebenToolStripMenuItem.Text = "Kunden eingeben"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'txtFrmMainKundennummer
        '
        Me.txtFrmMainKundennummer.Location = New System.Drawing.Point(102, 57)
        Me.txtFrmMainKundennummer.Name = "txtFrmMainKundennummer"
        Me.txtFrmMainKundennummer.Size = New System.Drawing.Size(246, 20)
        Me.txtFrmMainKundennummer.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kundennummer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Kundentelefonnr.:"
        '
        'cmdFindPhoneNr
        '
        Me.cmdFindPhoneNr.Location = New System.Drawing.Point(15, 83)
        Me.cmdFindPhoneNr.Name = "cmdFindPhoneNr"
        Me.cmdFindPhoneNr.Size = New System.Drawing.Size(129, 23)
        Me.cmdFindPhoneNr.TabIndex = 8
        Me.cmdFindPhoneNr.Text = "Telefonnr. suchen"
        Me.cmdFindPhoneNr.UseVisualStyleBackColor = True
        '
        'lblFrmMainKundenTeleNr
        '
        Me.lblFrmMainKundenTeleNr.AutoSize = True
        Me.lblFrmMainKundenTeleNr.Location = New System.Drawing.Point(110, 132)
        Me.lblFrmMainKundenTeleNr.Name = "lblFrmMainKundenTeleNr"
        Me.lblFrmMainKundenTeleNr.Size = New System.Drawing.Size(16, 13)
        Me.lblFrmMainKundenTeleNr.TabIndex = 9
        Me.lblFrmMainKundenTeleNr.Text = "..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 440)
        Me.Controls.Add(Me.lblFrmMainKundenTeleNr)
        Me.Controls.Add(Me.cmdFindPhoneNr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFrmMainKundennummer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.KundeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KundeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsBestellungBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KundeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KundeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As DateSetBsp.DataSet1
    Friend WithEvents KundeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DetailsBestellungBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KundeBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KundenEingebenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtFrmMainKundennummer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdFindPhoneNr As System.Windows.Forms.Button
    Friend WithEvents lblFrmMainKundenTeleNr As System.Windows.Forms.Label

End Class
