Imports System.Drawing.Drawing2D
Public NotInheritable Class SplashScreen
    Private i As Integer
    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  
        Version.Text = System.String.Format("V {0}.{1}.{2}", My.Application.Info.Version.Major,
                                            My.Application.Info.Version.Minor, My.Application.Info.Version.Build)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright
    End Sub
    Private Sub Wheel_Paint(sender As Object, e As PaintEventArgs) Handles Wheel.Paint
        'Increment i for filling progress wheel
        i += 1
        'If i exceeds 360 degrees, then don't draw, this avoids having percentage > 100
        If i > 360 Then
            Return
        End If
        'Set the background image of the wheel
        'use e.Graphics for g in DrawWheelProgress function and i for the angle
        Wheel.BackgroundImage = DrawWheelProgress(e.Graphics, i)
    End Sub
    Private Function DrawWheelProgress(g As Graphics, angle As Integer) As Bitmap
        'Declare/create the bitmap which will be used as our wheel
        Dim bit As New Bitmap(Wheel.ClientRectangle.Width, Wheel.ClientRectangle.Height)
        'Use the graphics of the bitmap
        g = Graphics.FromImage(bit)
        'Declare variable to be used to calculate percentage completed of loading
        Dim percent As Double = Math.Round(angle * 100 / 360, 0) 'Calculate the percentage to nearest number
        'Declare the graphics path for drawing later
        Dim path As New GraphicsPath
        'Rectangle for the image
        Dim rec As Rectangle = New Rectangle(0, 0, bit.Width, bit.Height)
        'Declare the string. This will be used to display percentage completed.
        Dim strFormat As New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }
        g.DrawString(percent & "%", New Font(Font.FontFamily, 11, FontStyle.Bold), Brushes.AntiqueWhite,
               New Point(rec.Width / 2, rec.Height / 2), strFormat) 'Show what percentage is completed
        'Draw the circle/ellipse 
        g.DrawEllipse(Pens.Black, rec)
        'Add outline of pie shape for path
        path.AddPie(rec, 180, angle)
        'This creates an outside rectangle (which we use for the outer curve)
        Dim holdRect As Rectangle = New Rectangle(rec.X + 10, rec.Y + 10, rec.Width - 20, rec.Height - 20)
        g.DrawEllipse(Pens.Black, holdRect)
        'Use clip to set the region in which to draw
        g.Clip = New Region(path)
        path.AddPie(holdRect, 180, angle)
        'Create a gradient as the loading progress
        Dim solid As New SolidBrush(Color.Aqua)
        g.FillPath(solid, path)

        Return bit
    End Function
End Class
