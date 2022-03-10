Imports CarLibrary

Module Program
    Sub Main()
        Console.WriteLine("***** VB CarLibrary Client App *****")
        Dim miniVan As New MiniVan()
        miniVan.TurboBoost()
        
        Dim mySportsCar As New SportsCar()
        mySportsCar.TurboBoost()
        
        Dim dreamCar As New PerformanceCar()
        dreamCar.PetName = "Hank"
        dreamCar.TurboBoost()
        
'        Dim internalClassInstance As New MyInternalClass()
        
        Console.ReadLine()
    End Sub
End Module
