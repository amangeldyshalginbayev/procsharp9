Imports CommonSnappableTypes

<CompanyInfo(CompanyName := "Chucky's Software", CompanyUrl := "www.ChuckySoft.com")>
Public Class VBSnapIn
    Implements IAppFunctionality

    Public Sub DoIt() Implements IAppFunctionality.DoIt
        Console.WriteLine("You have just used the VB snapin!")
    End Sub
End Class