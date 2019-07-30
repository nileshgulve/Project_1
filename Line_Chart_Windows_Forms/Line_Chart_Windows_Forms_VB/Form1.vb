Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Form1
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Fetch the Statistical data from database.
        Dim query As String = "SELECT ShipCity, COUNT(OrderId) [Total]"
        query &= " FROM Orders WHERE ShipCountry = 'Brazil'"
        query &= " GROUP BY ShipCity"

        Dim dt As DataTable = GetData(query)

        'Get the names of Cities.
        Dim x As String() = (From p In dt.AsEnumerable() _
                             Order By p.Field(Of String)("ShipCity") _
                             Select p.Field(Of String)("ShipCity")).ToArray()

        'Get the Total of Orders for each City.
        Dim y As Integer() = (From p In dt.AsEnumerable() _
                              Order By p.Field(Of String)("ShipCity") _
                              Select p.Field(Of Integer)("Total")).ToArray()

        Chart1.Series(0).LegendText = "Brazil Order Statistics"
        Chart1.Series(0).ChartType = SeriesChartType.Line
        Chart1.Series(0).BorderWidth = 3
        Chart1.Series(0).IsValueShownAsLabel = True
        Chart1.Series(0).Points.DataBindXY(x, y)
    End Sub

    Private Shared Function GetData(ByVal query As String) As DataTable
        Dim constr As String = "Data Source=.\SQL2005;Initial Catalog=Northwind;User ID=sa;Password=pass@123"
        Using con As SqlConnection = New SqlConnection(constr)
            Using sda As SqlDataAdapter = New SqlDataAdapter(query, con)
                Dim dt As DataTable = New DataTable()
                sda.Fill(dt)
                Return dt
            End Using
        End Using
    End Function
End Class
