Imports System.Data.SqlClient
Module mesFonctions
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public ds As New DataSet
    Public Sub connecter()
        con.ConnectionString = "Data Source=DESKTOP-6M7BF42\SQLEXPRESS;Initial Catalog=biblioteques;Integrated Security=True"
        con.Open()
    End Sub
    Public Sub deconnecter()
        con.Close()
    End Sub

    Public Sub remplirDGV(dgv As DataGridView, table As String)
        Call connecter()
        cmd.CommandText = "select * from " & table
        cmd.Connection = con
        da.SelectCommand = cmd
        'Fill synonime de charger en anglais 
        da.Fill(ds, "dt_" & table)
        dgv.DataSource = ds.Tables("dt_" & table)

        Call deconnecter()
    End Sub

    Public Sub chercherLiv(dgv As DataGridView, ch As String)
        Call connecter()
        cmd.CommandText = "select * from kteb where titre like '" & ch & "%'"
        cmd.Connection = con
        da.SelectCommand = cmd
        'Fill synonime de charger en anglais 
        ds.Tables("dt_kteb").Clear()
        da.Fill(ds, "dt_kteb")
        dgv.DataSource = ds.Tables("dt_kteb")

        Call deconnecter()
    End Sub
    Public Sub viderformulaire(f As Form)
        For Each ctl As Control In f.Controls



            If TypeOf ctl Is TextBox Then

                ctl.Text = ""

            End If
            If TypeOf ctl Is DateTimePicker Then
                CType(ctl, DateTimePicker).Value = Now

            End If
            If TypeOf ctl Is GroupBox Then
                For Each ctl2 As Control In ctl.Controls
                    If TypeOf ctl2 Is RadioButton Then
                        CType(ctl2, RadioButton).Checked = False
                    End If
                Next
            End If
        Next
    End Sub

End Module
