Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace PreviewAndPrint

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' set advanced print options, if needed
            chartControl1.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom
            printableComponentLink1.Landscape = True
            printableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            printableComponentLink1.ShowPreview()
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            printableComponentLink1.Print(String.Empty)
        End Sub
    End Class
End Namespace
